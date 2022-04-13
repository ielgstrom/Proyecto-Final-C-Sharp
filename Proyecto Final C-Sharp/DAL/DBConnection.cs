using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Proyecto_Final_C_Sharp.DAL
{
    public class DBConnection
    {
        public static SqlConnection Connect(string dataSource, string initialCatalog, string user, string password)
        {
            SqlConnection connection = new SqlConnection("Data Source=" + dataSource + ";Initial Catalog=" + initialCatalog + ";Persist Security Info=True;User ID=" + user + ";Password=" + password);
            connection.Open();
            return connection;
        }

        public static SqlConnection ConnectLearnifyDB()
        {
            return Connect("217.71.207.123,54321", "LearnifyDB", "sa", "123456789");
        }
    }
}