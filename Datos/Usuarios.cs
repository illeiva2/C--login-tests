using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace PracticaLogin.Datos
{
    internal class Usuarios
    {
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado;
            DataTable tabla = new();
            MySqlConnection sqlCon = new();
            Conexion con = new();
            try
            {
                sqlCon = con.OpenConnection();
                MySqlCommand comando = new("IngresoLogin", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
