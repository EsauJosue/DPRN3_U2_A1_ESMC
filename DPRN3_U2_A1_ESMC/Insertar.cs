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
    internal class Insertar
    {
        protected MySqlCommand command;
        public Boolean ingreso(string tipo, string serie, string anio_ad, string marca, string modelo, string anio_mod, PictureBox foto, string color, string esVerificado, string fecha)
        {
            try
            {
                //Se crea la cadena con la instrucción SQL, el campo imagen se asigna su valor posteriormente para que primero se convierta en Bytes en la clase Convertir Imagen, es por eso que solo se le asigna @imagen
                string cadena = "INSERT INTO autos SET tipo='"+ tipo +"', serie='"+serie+"', anio_ad='"+anio_ad+"', marca='"+marca+"', modelo='"+modelo+"', anio_mod='"+anio_mod+"', imagen=@imagen, color='"+color+"', verificacion='"+esVerificado+"', date='"+fecha+"'";
                //El método ImageToBytes retorna un array y se almacena en la variable image
                byte[] image = ConvertirImagen.ImageToBytes(foto.Image);
                //Se crea la instancia a la clase conexionBD 
                command = new MySqlCommand(cadena,conexionBD.conexBD());
                //Se agrega el parámetro que estaba pendiente para el campo imagen ya convertido en un array de bytes
                command.Parameters.AddWithValue("@imagen", image);
                //Se ejecuta la instrucción SQL 
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
                throw;
            }

        }
    }
}
