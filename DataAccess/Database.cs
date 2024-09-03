using MySql.Data.MySqlClient;
using System.Data;

namespace ABCCarTraders.DataAccess
{


    public class Database
    {
        private string connectionString = "server=localhost;database=abc_car_traders;user=springstudent;password=springstudent";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public DataTable ExecuteQuery(string query)
        {
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
        }

        public int ExecuteNonQuery(string query)
        {
            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }

}
