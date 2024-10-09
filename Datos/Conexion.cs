using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PracticaLogin.Datos
{
    public class Conexion
    {
        private MySqlConnection connection = null!;
        private string server = null!;
        private string database = null!;
        private string uid = null!;
        private string password = null!;

        public Conexion() => Initialize();

        private void Initialize()
        {
            server = "localhost";
            database = "clubdeportivo";
            uid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection OpenConnection()
        {
            try
            {
                connection.Open();
                return connection;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                connection = null!;
                return connection;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
