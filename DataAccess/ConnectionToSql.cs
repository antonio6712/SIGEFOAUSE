using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
     
namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        public static MySqlConnection getConnection()
        {
            string servidor = "localhost";
            string port = "3306";
            string bd = "sigefoause";
            string usuario = "root";
            string password = "admin";

            string cadenaConnection = "server="+servidor+";port="+port+
                ";database="+bd+";user="+usuario+";password="+password+";old guids=true; default command timeout=800";
                       
                MySqlConnection connectionBD = new MySqlConnection(cadenaConnection);
                return connectionBD;
           
        }

    }
}
