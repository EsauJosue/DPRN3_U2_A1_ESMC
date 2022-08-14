using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace DPRN3_U2_A1_ESMC
{
    internal class conexionBD
    {
        public static MySqlConnection conexBD()
        {
            //Datos de conexión.
            string server = "127.0.0.1";
            string database = "flotilla";
            string Uid = "root";
            string pass = "Admin123$";
            //Instancia a la clase MySqlConnection para realizar la conexión
            MySqlConnection connection = new MySqlConnection("server=" + server + "; database=" + database + ";Uid=" + Uid + "; pwd=" + pass);
            try
            {
                connection.Open();
                Console.WriteLine("Conexión exitosa");
                return connection;
            }
            catch (Exception e)
            {
                Console.WriteLine("Hubo un error de conexión. " + e);
                return connection;
            }
        }
    }
}
