using MySql.Data.MySqlClient;
using System.Configuration;

namespace HelperProject
{
    public static class SqlConnectionProvider
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ToString();
            MySqlConnection connection;
            connection = new MySqlConnection(connectionString);
            connection.ConnectionString = connectionString;
            connection.Open();

            return connection;
        }
    }
}
