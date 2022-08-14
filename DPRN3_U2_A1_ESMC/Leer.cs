using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace DPRN3_U2_A1_ESMC
{
    internal class Leer
    {
        protected internal DataTable Tabla;
        
        protected MySqlDataAdapter leer;


        public DataTable Consulta()
        {
            Tabla = new DataTable();

            try
            {
               //Instrucción SQL del Query
                string query = "SELECT idautos, tipo, serie, anio_ad, marca, modelo, anio_mod, imagen, color, verificacion, date FROM autos";
                leer = new MySqlDataAdapter(query,conexionBD.conexBD());
                //Se llena la tabla con lo encontrado en la base de datos.
                leer.Fill(Tabla);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            return Tabla;
        }
       

    }
}
