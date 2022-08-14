using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace DPRN3_U2_A1_ESMC
{
    internal class ConvertirImagen
    {   //Esta función convierte de Byte a Imagen para la lectura. 
        public static MemoryStream BytesToImage(byte [] array) 
        { 
            MemoryStream memory = new MemoryStream((byte[])array);
            return memory; 
        }
        //Esta función convierte una Imagen a Bytes
        public static byte [] ImageToBytes(Image imageIn) 
        {
            MemoryStream memory = new MemoryStream();
            imageIn.Save(memory, ImageFormat.Jpeg);
            return memory.ToArray();
        }
    }
}
