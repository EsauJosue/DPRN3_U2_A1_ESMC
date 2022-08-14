using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPRN3_U2_A1_ESMC
{
    public partial class Form1 : Form
    {
        private Leer tbAutos = new Leer();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Toda la inforación llenada por el usuario se asigna a su variable correspondiente para mandarla como argumentos al método ingreso de la clase Insertar
            string tipo = tipocmb.Text;
            string serie = serietxt.Text;
            string anioad = cmbyear.Text;
            string marca = marcatxt.Text;
            string modelo = modelotxt.Text;
            string anioauto = cmbyearauto.Text;
            string color="";
            string date = DateTime.Now.ToString();
            string esVerificado = Isverifacdocmb.Text;
            if (radioButton1.Checked == true)
            {
               color = colorcmb.Text;
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    color = txtColorMixto.Text;
                }
            }
           //Instancia a la clase Insertar
            Insertar frm = new Insertar();
            //Se envían como argumentos la información del vehículo
            Boolean save = frm.ingreso(tipo, serie, anioad, marca, modelo, anioauto, pbImagen,color, esVerificado, date);
            //Si el método ingreso retorna un True se llena el GridView y se manda un mensaje. 
            if (save) 
            {
                this.FillGridView();
                MessageBox.Show("Guardado con éxito.", "Mensaje...");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                amarilloCh.Enabled = false;
                AzulCh.Enabled = false;
                NegroCh.Enabled = false;
                GrisCh.Enabled = false;
                RojoCh.Enabled = false;
                txtColorMixto.Enabled = false;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                amarilloCh.Enabled = true;
                AzulCh.Enabled = true;
                NegroCh.Enabled = true;
                GrisCh.Enabled = true;
                RojoCh.Enabled = true;
                txtColorMixto.Enabled = true;
            }

        }
        private void FillGridView() 
        {
            //Se llena el GridView
            dtAutos.DataSource = tbAutos.Consulta();
            //Se indica al GridView que en la columna 7 lleva un campo con imagen. 
            DataGridViewImageColumn columna = (DataGridViewImageColumn)dtAutos.Columns[7];
            columna.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            timer1.Enabled = true;
            //Se calcula el año actual para ubicarlo en la lista de opciones para año de adquisición del vehículo y para el año del auto.
            int actyear = DateTime.Now.Year;

            for(int i = actyear; i > 1929; i--)
            {
                cmbyear.Items.Add(i.ToString());
                cmbyearauto.Items.Add(i.ToString());
            }
            //Se manda llamar el método para llenado de la tabla con los datos en la base de datos
            this.FillGridView();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Se crea una instancia para que al dar clic en el botón, se pueda seleccionar la imagen desde un explorador de archivos
            OpenFileDialog buscarimg = new OpenFileDialog();
            buscarimg.Title = "Seleccione imagen del auto";
            //Se filtran los archivos para que solo acepte .jpg
            buscarimg.Filter = "*.jpg|*.jpg";
            //Se inicializa el explorador en la ruta c:
            buscarimg.InitialDirectory = "C:\\"; 
            if (buscarimg.ShowDialog() == DialogResult.OK)
            {
                //Se obtiene el nombre del archivo y se guarda en la locación del picture box
                pbImagen.ImageLocation = buscarimg.FileName;
                //Se muestra la url del archivo seleccionado en el textbox
                imgtxt.Text = buscarimg.FileName;
                pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Se muestra la fecha y la hora en el sistema. 
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        //Selección de colores Mixto, se concatenan los checked en el textbox
        private void amarilloCh_CheckedChanged(object sender, EventArgs e)
        {
            if(amarilloCh.Checked == true) 
            {
                txtColorMixto.Text = txtColorMixto.Text + "Amarillo, ";
            }
        }

        private void AzulCh_CheckedChanged(object sender, EventArgs e)
        {
            if (AzulCh.Checked == true)
            {
                txtColorMixto.Text = txtColorMixto.Text + "Azul, ";
            }
        }

        private void GrisCh_CheckedChanged(object sender, EventArgs e)
        {
            if (GrisCh.Checked == true)
            {
                txtColorMixto.Text = txtColorMixto.Text + "Gris, ";
            }
        }

        private void NegroCh_CheckedChanged(object sender, EventArgs e)
        {
            if (NegroCh.Checked == true)
            {
                txtColorMixto.Text = txtColorMixto.Text + "Negro, ";
            }
        }

        private void RojoCh_CheckedChanged(object sender, EventArgs e)
        {
            if (RojoCh.Checked == true)
            {
                txtColorMixto.Text = txtColorMixto.Text + "Rojo, ";
            }
        }

        private void dtAutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
