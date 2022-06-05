using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BD
{
    public class BD
    {
        private static MySqlConnection conn;

        public static bool initConnection()
        {
            string server = "10.1.139.236";
            string login = "d1";
            string password = "mdp";
            string DB = "based1";

            string connectString = $"server={server};uid={login};pwd={password};database={DB}";

            conn = new MySqlConnection(connectString);

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!! {e.Message}");
                return false;
            }

            return true;
        }

        public static bool closeConnection()
        {
            try
            {
                conn.Close();
                conn.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error!! Message: {e.Message}");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Chercher toutes les stations de la BDD
        /// </summary>
        /// <returns>la liste des stations</returns>
        /// <exception cref="Exception">En cas de table vide</exception>
        public static List<Station> getStations()
        {
            List<Station> stations = new List<Station>();

            string query = "SELECT * FROM gare;";

            MySqlCommand cmd = new MySqlCommand(query, conn); // initialisation d'une commande SQL

            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows) // on vérifie qu'il y a bien des données dans la table
                    {
                        while (reader.Read())
                        {
                            stations.Add(new Station(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2), reader.GetBoolean(3))); // on ajoute les stations dans la liste
                        }
                    }
                    else
                    {
                        throw new Exception("No stations were found");
                    }
                }
            }
            catch
            {
                stations.Add(new Station(0, "Erreur de lecture de la base de données", false, false));
            }
            

            return stations;
        }
    }
}