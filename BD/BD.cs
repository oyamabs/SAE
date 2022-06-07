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

        public static void addStation(Station station)
        {
            int hasElevator = station.hasElevator ? 1 : 0;
            int hasParking = station.hasParking ? 1 : 0;

            string query = $"INSERT INTO gare(nom_gare, ascenseur, stationnement) VALUES (\"{station.stationName}\", {hasElevator}, {hasParking});";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

        }

        public static void updateStation(int id, bool hasElevator, bool hasParking)
        {
            int _hasElevator = hasElevator ? 1 : 0;
            int _hasParking = hasParking ? 1 : 0;

            string query = $"UPDATE gare SET ascenseur = {_hasElevator}, stationnement = {_hasParking} WHERE num_gare = {id};";

            MySqlCommand sql = new MySqlCommand(query, conn);

            MySqlDataReader reader = sql.ExecuteReader();
        }

        public static void deleteStation(int id)
        {
            string query = $"DELETE FROM gare WHERE num_gare = {id};";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

        }

        public static List<Line> getLines()
        {
            List<Line> lines = new List<Line>();

            string query = "SELECT * FROM ligne;";

            MySqlCommand cmd = new MySqlCommand(query, conn); // initialisation d'une commande SQL

            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows) // on vérifie qu'il y a bien des données dans la table
                    {
                        while (reader.Read())
                        {
                            lines.Add(new Line(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3))); // on ajoute les stations dans la liste
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
                lines.Add(new Line(0, "Erreur de lecture de la base de données", 0, 0));
            }

            return lines;
        }

        public static void addLine(Line line)
        {
            string query = $"INSERT INTO ligne (nom_ligne, num_gare, num_gare_1) VALUES (\"{line.lineName}\", {line.station1}, {line.station2})";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();
        }

        public static void updateLine(Line line)
        {
            string query = $"UPDATE ligne SET num_gare = {line.station1}, num_gare_1 = {line.station2} WHERE nom_ligne = \"{line.lineName}\"";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();
        }

        public static void deleteLine(int id)
        {
            string query = $"DELETE FROM ligne WHERE num_ligne = {id};";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
        }
    }
}