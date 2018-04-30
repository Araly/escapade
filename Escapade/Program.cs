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

namespace Escapade
{
    class MainClass
    {

        public static void Main(string[] args)
        {
			try
			{
				const string DEMO_PHONE_NUMBER = "0782453482";
				const string DEMO_EMAIL = "adrien.kerisit@devinci.fr";

				string connexionString = "SERVER=localhost;PORT=3306;DATABASE= escapade;UID=akeris;SslMode=none";
                MySqlConnection connexion = new MySqlConnection(connexionString);              

				Deal demonstration = null;
                XmlSerializer xs = new XmlSerializer(typeof(Deal));
                StreamReader rd = new StreamReader("M1.xml");
                demonstration = xs.Deserialize(rd) as Deal;
                rd.Close();

				Console.WriteLine("Bonjour " + demonstration.Client.Firstname + " " + demonstration.Client.Lastname + ", et bienvenue à l'agence de voyage Escapade !\n");
                Console.WriteLine("\nNous interrogeons notre base de donnée...\n");

				connexion.Open();
				string [] queryResult = Query_mysql_server(connexion, "select count(id) from client where firstname ='" + demonstration.Client.Firstname + "' and lastname ='" + demonstration.Client.Lastname + "';");
				connexion.Close();
				int result = int.Parse(queryResult[0]);            
				if(result == 0)
				{
					Console.WriteLine("Vous n'avez pas de compte actuellement, merci de répondre à quelques questions afin que nous puissions vous créer un compte \n\nVeuillez indiquer votre numero de telephone\n");
					TypeLine(DEMO_PHONE_NUMBER);
					Console.WriteLine("\n\n Veuillez renseigner votre email \n");
					TypeLine(DEMO_EMAIL);

					connexion.Open();
					queryResult = Query_mysql_server(connexion, "insert into escapade.client(firstname, lastname, phone, adress, email) values('" + demonstration.Client.Firstname +"', '" + demonstration.Client.Lastname + "', '" + DEMO_PHONE_NUMBER + "', '" + demonstration.Client.Adress + "', '" + DEMO_EMAIL + "');" );
					connexion.Close();
					Console.WriteLine("Enregistrement terminé !");
				}

				connexion.Open();
				queryResult = Query_mysql_server(connexion, "select id from client where firstname ='" + demonstration.Client.Firstname + "' and lastname ='" + demonstration.Client.Lastname + "';");
				connexion.Close();
				int id_client = int.Parse(queryResult[0]);
				Console.WriteLine("Succès, votre identifiant client est : " + id_client+"\n"); 

				Console.WriteLine("Nous vous cherchons une voiture dans le secteur\n");              
				connexion.Open(); 
				queryResult = Query_mysql_server(connexion, "select * from car c inner join parking p on c.id_parking = p.theme where p.theme = '" + demonstration.Stay.Theme + "' and c.available = true;");
				connexion.Close();

				if(queryResult[0]!=null)
				{
					Console.WriteLine("Voiture disponible trouvée !\n");
				}
				else
				{
					Console.WriteLine("Pas de chance, il n'y a aucune voiture disponible dans votre secteur\n");
					Console.WriteLine("Nous élargissons notre champ de recherche\n");

					connexion.Open();
					queryResult = Query_mysql_server(connexion, "select * from car where available = true limit 1;");
					connexion.Close();
				}
				if (queryResult[0] != null)
				{
					Console.WriteLine("Voiture trouvée :\n");
					string[] temp = queryResult[0].Split(',');
					bool av = false;
					int av_tmp = int.Parse(temp[4]);
					if (av_tmp == 1) { av = true; } // nécessaire pour passer du bit mysql au bool c#

					connexion.Open();
					queryResult = Query_mysql_server(connexion, "select s.id, firstname, lastname from supervisor s inner join car c on s.id = c.id_supervisor where c.id = '" + temp[0] + "';");
					connexion.Close();

					string[] temp2 = queryResult[0].Split(',');
					Supervisor superviseur = new Supervisor(int.Parse(temp2[0]),temp2[1], temp2[2]);

					connexion.Open();
					queryResult = Query_mysql_server(connexion, "select p.id, theme from parking p inner join car c on p.id = c.id_parking where c.id_parking ='" + temp[7] + "';");
					connexion.Close();

					string[] temp3 = queryResult[0].Split(',');
					Parking parking = new Parking(int.Parse(temp3[0]), temp3[1]);
					Car voiture = new Car(temp[0], temp[1], temp[2], temp[3],av , superviseur, temp[6], parking);
					Console.WriteLine(voiture.ToString());
				}
				else
				{
					Console.WriteLine("Nous sommes désolés, aucune voiture n'est disponible pour le moment...\n");
				}
           
			}
			catch(MySqlException ex)
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
