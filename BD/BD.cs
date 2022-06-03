using MySql.Data;
using MySql.Data.MySqlClient;

namespace BD
{
    public class BD
    {
        private static MySqlConnection conn;

        private static bool initConnection()
        {
            string server = "10.1.139.235";
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
    }
}