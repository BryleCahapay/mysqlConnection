using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mysqlConnection.myclass
{
    internal class connection_class
    {
        public MySqlConnection connectvs;

        public connection_class() 
        {
            string host = "localhost";
            string database = "studentvs";
            string username = "root";
            string password = "";
            string port = "3306";

            string connection_string = "datasource =" + host + ";database=" + database + "; port=" + port + "; username =" + username + ";" +
                "password=" + password + "; SslMode =none;";

            connectvs = new MySqlConnection(connection_string);
        }
    }
}
