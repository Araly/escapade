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
			DemoReservation(connexion);
			Console.ReadKey();
        }
		public static void DemoReservation(MySqlConnection connexion)
		{
			try
            {            
                Deal demonstration = null;
                XmlSerializer xs = new XmlSerializer(typeof(Deal));
                StreamReader rd = new StreamReader("M1.xml");
                demonstration = xs.Deserialize(rd) as Deal;
                rd.Close();
				demonstration.State = "unconfirmed";
				Console.WriteLine("XML Message : reception successful\n");
				Console.WriteLine("\nQuerying database for client " + demonstration.Client.Firstname + " " + demonstration.Client.Lastname);

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
                    Console.WriteLine("\nInsertion successful\n");
					Console.WriteLine("\nDouble-checking\n");
                }

                connexion.Open();
                queryResult = Query_mysql_server(connexion, "select id from client where firstname ='" + demonstration.Client.Firstname + "' and lastname ='" + demonstration.Client.Lastname + "';");
                connexion.Close();
                int id_client = int.Parse(queryResult[0]);
				demonstration.Client.Id = id_client;
				Console.WriteLine("\nClient Found : id = " + id_client + "\n");

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
                    Console.WriteLine("\nAvailable car not found, increasing range ...\n");

                    connexion.Open();
                    queryResult = Query_mysql_server(connexion, "select * from car where available = true limit 1;");
                    connexion.Close();
                }
                if (queryResult[0] != null)
                {                
                    string[] temp = queryResult[0].Split(',');
                    bool av = false;
                    int av_tmp = int.Parse(temp[4]);
                    if (av_tmp == 1) { av = true; } // nécessaire pour passer du bit mysql au bool c#

                    connexion.Open();
                    queryResult = Query_mysql_server(connexion, "select s.id, firstname, lastname from supervisor s inner join car c on s.id = c.id_supervisor where c.id = '" + temp[0] + "';");
                    connexion.Close();
                    
                    string[] temp2 = queryResult[0].Split(',');
                    Supervisor superviseur = new Supervisor(int.Parse(temp2[0]), temp2[1], temp2[2]);

                    connexion.Open();
                    queryResult = Query_mysql_server(connexion, "select p.id, theme from parking p inner join car c on p.id = c.id_parking where c.id_parking ='" + temp[7] + "';");
                    connexion.Close();

                    string[] temp3 = queryResult[0].Split(',');
                    Parking parking = new Parking(int.Parse(temp3[0]), temp3[1]);
                    Car voiture = new Car(temp[0], temp[1], temp[2], temp[3], av, superviseur, temp[6], parking);
					Console.WriteLine("\nCar selected : \n" + voiture.ToString());
					Console.WriteLine("\nQuerying RBNP...\n");
					Console.WriteLine("\nReceving response from RBNP");
					rd = new StreamReader("AirBNPfinal.json");
					JObject jObject = JObject.Parse(rd.ReadToEnd());
					JToken jQuery = jObject.SelectToken("$..Housing[?(@.borough == 16),?(@.bedrooms == 1),?(@.overall_satisfaction >= 4.5),?(@.availability == 'yes')]");               

                }
                else
                {
                    Console.WriteLine("\nNo car available, aborting reservation attempt\n");
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
			string[] toReturn = new string[reader.FieldCount];
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
