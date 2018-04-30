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
				Client demonstration = new Client("Goku", "Son", "ESILV, La defense", "visite de la défense", 2018, 14);
				string connexionString = "SERVER=localhost;PORT=3306;DATABASE= escapade;UID=escapade;PASSWORD=esilv;SslMode=none";
				MySqlConnection connexion = new MySqlConnection(connexionString);
				Demo1(demonstration);
				connexion.Open();
				string [] queryResult = Query_mysql_server(connexion, "select count(id) from client where firstname ='" + demonstration.Firstname + "' and lastname ='" + demonstration.Lastname + "';");
				int result = int.Parse(queryResult[0]);
				connexion.Close();
				if(result == 0)
				{
					connexion.Open();
					queryResult = Query_mysql_server(connexion, "");
					connexion.Close();
				}
				else if(result == 1)
				{
					connexion.Open();
					queryResult = Query_mysql_server(connexion, "select id from client where firstname ='" + demonstration.Firstname + "' and lastname ='" + demonstration.Lastname + "';");
					int id_client = int.Parse(queryResult[0]);
					connexion.Close();
					Console.WriteLine("Succès, votre identifiant client est : " + id_client);
				}           
			}
			catch(MySqlException ex)
			{
				Console.WriteLine("Error :" + ex.ToString());
			}
        }
        public static void Demo1(Client c)
		{
			Console.WriteLine("Bienvenue à l'agence de voyage Escapade !\n");
            Console.WriteLine("\nVeuillez indiquer votre nom :\n");
			TypeLine(c.Firstname + ' ' + c.Lastname);
            Console.WriteLine("\n\nExcellent, maintenant votre adresse :\n");
			TypeLine(c.Adress);
            Console.WriteLine("\n\nParfait, veuillez à présent préciser le thème de votre séjour :\n");
			TypeLine(c.Stay);
            Console.WriteLine("\n\nPresque fini, quelles sont vos dates ?\n");
			TypeLine("Semaine " + c.Week + ", Année " + c.Year);
            Console.WriteLine("\nNous interrogeons notre base de donnée...");
			System.Threading.Thread.Sleep(1500);
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
