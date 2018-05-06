using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json.Linq;

namespace Escapade
{
    class MainClass
    {

        public static void Main(string[] args)
        {
			string connexionString = "SERVER=localhost;PORT=3306;DATABASE= escapade;UID=akeris;SslMode=none";
            MySqlConnection connexion = new MySqlConnection(connexionString);

			Deal demonstration = null;
			try
            {
                Console.WriteLine("Reservation\n");
                XmlSerializer xs = new XmlSerializer(typeof(Deal));
                StreamReader rd = new StreamReader("M1.xml");
                demonstration = xs.Deserialize(rd) as Deal;
                rd.Close();
                demonstration.State = "unconfirmed";
                Console.WriteLine("XML M1 Message : reception and deserialization successful\nReady to query database for client " + demonstration.Client.Firstname + " " + demonstration.Client.Lastname);
                Console.WriteLine("\nE1 DONE : PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
                connexion.Open();
                string[] queryResult = Query_mysql_server(connexion, "select count(id) from client where firstname ='" + demonstration.Client.Firstname + "' and lastname ='" + demonstration.Client.Lastname + "';");
                connexion.Close();
                int result = int.Parse(queryResult[0]);
                if (result == 0)
                {
                    Console.WriteLine("\nClient not found, inserting new client to database\n");

                    connexion.Open();
                    queryResult = Query_mysql_server(connexion, "insert into escapade.client(firstname, lastname, phone, adress, email) values('" + demonstration.Client.Firstname + "', '" + demonstration.Client.Lastname + "', '" + demonstration.Client.Phone + "', '" + demonstration.Client.Adress + "', '" + demonstration.Client.Email + "');");
                    connexion.Close();

                    Console.WriteLine("\nInsertion successful\nDouble-checking\n");
                }
                connexion.Open();
                queryResult = Query_mysql_server(connexion, "select count(id) from stay where theme = '" + demonstration.Stay.Theme + "';");
                connexion.Close();
                if (int.Parse(queryResult[0]) == 0)
                {
                    connexion.Open();
                    queryResult = Query_mysql_server(connexion, "insert into escapade.stay(theme) values('" + demonstration.Stay.Theme + "');");
                    connexion.Close();
                }
                connexion.Open();
                queryResult = Query_mysql_server(connexion, "select id from client where firstname ='" + demonstration.Client.Firstname + "' and lastname ='" + demonstration.Client.Lastname + "';");
                connexion.Close();
                demonstration.Client.Id = int.Parse(queryResult[0]);
                connexion.Open();
                queryResult = Query_mysql_server(connexion, "select id from stay where theme = '" + demonstration.Stay.Theme + "';");
                connexion.Close();
                demonstration.Stay.Id = int.Parse(queryResult[0]);
                Console.WriteLine("\nClient Found : " + demonstration.Client.ToString() + "\n");
                Console.WriteLine("\nE2 DONE : PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
                Console.WriteLine("\nSearching for an available car in the area\n");

                connexion.Open();
                queryResult = Query_mysql_server(connexion, "select * from car c inner join parking p on c.id_parking = p.theme where p.theme = '" + demonstration.Stay.Theme + "' and c.available = true;");
                connexion.Close();

                if (queryResult[0] != null)
                {
                    Console.WriteLine("\nAvailable car found\n");
                }
                else
                {
                    Console.WriteLine("\nNo available car found, increasing range to other boroughs\n");

                    connexion.Open();
                    queryResult = Query_mysql_server(connexion, "select * from car where available = true limit 1;");
                    connexion.Close();
                }
                if (queryResult[0] != null)
                {
                    string[] temp = queryResult[0].Split(',');

                    connexion.Open();
                    queryResult = Query_mysql_server(connexion, "select s.id, firstname, lastname from supervisor s inner join car c on s.id = c.id_supervisor where c.id = '" + temp[0] + "';");
                    connexion.Close();

                    string[] temp2 = queryResult[0].Split(',');
                    Supervisor superviseur = new Supervisor(int.Parse(temp2[0]), temp2[1], temp2[2]);

                    connexion.Open();
                    queryResult = Query_mysql_server(connexion, "select * from parking p inner join car c on p.id = c.id_parking where c.id_parking ='" + temp[7] + "';");
                    connexion.Close();

                    temp2 = queryResult[0].Split(',');
                    Parking parking = new Parking(int.Parse(temp2[0]), temp2[3], temp2[1], temp2[2]);
                    demonstration.Car = new Car(temp[0], temp[1], temp[2], temp[3], true, superviseur, temp[6], parking);
                    Console.WriteLine("\nCar selected : \n" + demonstration.Car.ToString() + "\n");
                    Console.WriteLine("\nE3 DONE : PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                    Console.WriteLine("\nQuerying RBNP for housings\n");

                    rd = new StreamReader("AirBNPfinal.json");
                    JArray jArray = JArray.Parse(rd.ReadToEnd());
                    Console.WriteLine("Receving response from RBNP\n");
                    Console.WriteLine("\nE4 DONE : PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                    IEnumerable<JToken> jResult = jArray.SelectTokens("$.[?(@.availability == 'yes' && @.bedrooms == 1 && @.overall_satisfaction >= 4.5 && @.borough == 16)]");

                    demonstration.Housing = jResult.First().ToObject<Housing>();
                    demonstration.Housing.Availabilty = true; // pas déserialisable à cause de la différence des types string/bool de la propriété entre le fichier json et la classe C#
                    connexion.Open();
                    queryResult = Query_mysql_server(connexion, "select count(id) from housing where host_id = " + demonstration.Housing.Host_id + " and room_id = " + demonstration.Housing.Room_id + ";");
                    connexion.Close();
                    int verification = int.Parse(queryResult[0]);
                    if (jResult != null && verification == 0)
                    {
                        connexion.Open();
                        queryResult = Query_mysql_server(connexion, "insert into escapade.housing (bedroomNumber, theme, rating, available, host_id, room_id, price) values (" + demonstration.Housing.Bedrooms + ", '" + demonstration.Housing.Borough + "', " + demonstration.Housing.Overall_satisfaction + ", " + Convert.ToInt32(demonstration.Housing.Availabilty) + ", " + demonstration.Housing.Host_id + ", " + demonstration.Housing.Room_id + ", " + demonstration.Housing.Price + ");");
                        connexion.Close();
                    }
                    else if (jResult != null && verification == 1)
                    {
                        Console.WriteLine("housing already registered in our database\n");
                    }
                    else
                    {
                        Console.WriteLine("\nNo housings available, aborting reservation attempt\n");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    connexion.Open();
                    queryResult = Query_mysql_server(connexion, "select id from housing where host_id =" + demonstration.Housing.Host_id + " and room_id =" + demonstration.Housing.Room_id + ";");
                    connexion.Close();
                    demonstration.Housing.Id = int.Parse(queryResult[0]);
                    Console.WriteLine("housing found : " + demonstration.Housing.ToString() + "\n");
                    Console.WriteLine("\nE5 DONE : PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                    connexion.Open();
					queryResult = Query_mysql_server(connexion, "select count(id) from deal where id_client =" + demonstration.Client.Id + " and week =" + demonstration.Week + " and year =" + demonstration.Year + ";");
                    connexion.Close();
				    verification = int.Parse(queryResult[0]);
					if (verification == 0) // Problem : query not working, result full of null
                    {
                        connexion.Open();
                        queryResult = Query_mysql_server(connexion, "insert into escapade.deal (id_stay, id_car, id_client, id_housing, week, year, state) values (" + demonstration.Stay.Id + ", '" + demonstration.Car.Id + "', " + demonstration.Client.Id + ", " + demonstration.Housing.Id + ", " + demonstration.Week + ", " + demonstration.Year + ", '" + demonstration.State + "');");
                        connexion.Close();
                    }

                    connexion.Open();
                    queryResult = Query_mysql_server(connexion, "select id from deal where id_client =" + demonstration.Client.Id + " and week =" + demonstration.Week + " and year =" + demonstration.Year + ";");
                    connexion.Close();

                    demonstration.Id = int.Parse(queryResult[0]);
                    Console.WriteLine("Deal registered in database : " + demonstration.ToString() + "\n");

                    StreamWriter wr = new StreamWriter("M2.xml");
                    xs.Serialize(wr, demonstration);
                    wr.Close();
                    Console.WriteLine("Object Deal Serialized\nSerialized Xml M2 message sent to client\n");
                    Console.WriteLine("\nE6 DONE : PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                    XPathDocument doc = new XPathDocument("M3.xml");
                    XPathNavigator nav = doc.CreateNavigator();
                    string myXPath = "/Deal/State";
                    XPathExpression expr = nav.Compile(myXPath);
                    XPathNodeIterator nodes = nav.Select(expr);
                    demonstration.State = nodes.Current.Value;
                    expr = nav.Compile(myXPath);
                    Console.WriteLine("XML M3 message received from client\ndeal state : " + demonstration.State + "\n");

                    if (demonstration.State == "confirmed")
                    {
                        connexion.Open();
                        queryResult = Query_mysql_server(connexion, "update deal set state ='" + demonstration.State + "' where id =" + demonstration.Id + ";");
                        connexion.Close();
                        Console.WriteLine("Validation sent to database\n");
                    }
                    else
                    {
                        Console.WriteLine("aborting operation\n");
                        Console.ReadKey();
                        Environment.Exit(0);

                    }
                    Console.WriteLine("\nE7 DONE : PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
					Console.WriteLine("CHECK OUT : initiated, Xml file receved with client's car location\n");
                    doc = new XPathDocument("checkOut.xml");
                    nav = doc.CreateNavigator();
                    myXPath = "/Parking/Theme";
                    expr = nav.Compile(myXPath);
                    nodes = nav.Select(expr);
                    connexion.Open();
                    queryResult = Query_mysql_server(connexion, "select * from parking where theme ='" + nodes.Current.Value + "';");
                    connexion.Close();
                    expr = nav.Compile(myXPath);
                    temp = queryResult[0].Split(',');
                    demonstration.Car.Parking = new Parking(int.Parse(temp[0]), temp[3], temp[1], temp[2]);
                    connexion.Open();
                    queryResult = Query_mysql_server(connexion, "update car set id_parking=" + demonstration.Car.Parking.Id + " where id ='" + demonstration.Car.Id + "';");
                    connexion.Close();
                    Console.WriteLine("Car location updated, new location : " + demonstration.Car.Parking.ToString() + "\n");
                    Console.WriteLine("\nE1 : DONE, PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                    Console.WriteLine("\nmessage sent to supervisor : " + demonstration.Car.Supervisor.ToString() + "\n");
                    
                    xs = new XmlSerializer(typeof(Car));
                    wr = new StreamWriter("carInfoSupervisor");
                    xs.Serialize(wr, demonstration.Car);
                    wr.Close();
                    Console.WriteLine("\nE2 : DONE, PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                    Console.WriteLine("Car needs to be washed\n");
                    connexion.Open();
                    queryResult = Query_mysql_server(connexion, "update car set available=0 where id ='" + demonstration.Car.Id + "';");
                    connexion.Close();
                    demonstration.Car.Available = false;
                    Maintenance maintenance = null;
                    Console.WriteLine("Car availability updated => bit set to 0, not available\n");
                    Console.WriteLine("\nE3 : DONE, PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                    Console.WriteLine("Maintenance info recieved from supervisor\n");
                    xs= new XmlSerializer(typeof(Maintenance));
                    rd = new StreamReader("maintenance.xml");
                    maintenance = xs.Deserialize(rd) as Maintenance;
                    maintenance.Car = demonstration.Car;
                    connexion.Open();
                    queryResult = Query_mysql_server(connexion, "select count(id) from maintenance where id_car='" + maintenance.Car.Id + "' and week=" + maintenance.Week + " and year=" + maintenance.Year + ";");
                    connexion.Close();
                    if (int.Parse(queryResult[0]) == 0)
                    {
                        connexion.Open();
						queryResult = Query_mysql_server(connexion, "insert into maintenance(id_car, cause, intervention, week, year, done) values ('" + maintenance.Car.Id + "', '" + maintenance.Cause + "', '" + maintenance.Intervention + "', " + maintenance.Week + ", " + maintenance.Year + ", " + Convert.ToInt32(maintenance.Done) + ");");
                        connexion.Close();
                        Console.WriteLine("Maintenance added to database");
                    }
                    connexion.Open();
                    queryResult = Query_mysql_server(connexion, "select id from maintenance where id_car='" + maintenance.Car.Id + "' and week=" + maintenance.Week + " and year=" + maintenance.Year + ";");
                    connexion.Close();
                    maintenance.Id = int.Parse(queryResult[0]);
                    Console.WriteLine("\nE4 : DONE, PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                    maintenance.Done = true;
                    connexion.Open();
                    queryResult = Query_mysql_server(connexion, "update maintenance set done=" + Convert.ToInt32(maintenance.Done) + " where id=" + maintenance.Id + ";");
                    connexion.Close();
                    Console.WriteLine("Maintenance finished");
                    maintenance.Car.Available = true;
                    connexion.Open();
					queryResult = Query_mysql_server(connexion, "update car c set available =" + Convert.ToInt32(maintenance.Car.Available) + " where id='" + maintenance.Car.Id + "';");
                    connexion.Close();
                    Console.WriteLine("Car available\n");
                    Console.WriteLine("\nE5 : DONE, PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nNo car available, aborting reservation attempt\n");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

            }
            catch (Newtonsoft.Json.JsonException ex)
            {
                Console.WriteLine("Error :" + ex.ToString());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error :" + ex.ToString());
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error :" + ex.ToString());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error :" + ex.ToString());
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error :" + ex.ToString());
            }
        }
		public static string[] Query_mysql_server(MySqlConnection connexion, string query)
		{
            MySqlCommand command = connexion.CreateCommand();
            command.CommandText = query; // exemple de requete bien-sur !
            MySqlDataReader reader;
            reader = command.ExecuteReader();
			string[] toReturn = new string[reader.FieldCount]; //pas plus de 10 individus par requête
			int individu = 0;
            while (reader.Read())                           // parcours ligne par ligne
            {
                string currentRowAsString = "";
                for (int i = 0; i < reader.FieldCount; i++)    // parcours cellule par cellule
                {
                    string valueAsString = reader.GetValue(i).ToString();  // recuperation de la valeur de chaque cellule sous forme d'une string (voir cependant les differentes methodes disponibles !!)
					if (i < reader.FieldCount - 1)
					{
						currentRowAsString += valueAsString + ", ";
					}
					else
					{
						currentRowAsString += valueAsString;
					}
                }
				toReturn[individu] = currentRowAsString;
				individu++;
            }
			return toReturn;
        }
		public static void TypeLine(string line)
        {
			System.Threading.Thread.Sleep(1500);
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                System.Threading.Thread.Sleep(150); // Sleep for 150 milliseconds
            }
        }
    }
}
