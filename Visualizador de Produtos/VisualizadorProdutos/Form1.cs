using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizadorProdutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string[] nomeFotosDosCarros = Directory.GetFiles(@"C:\Users\ricar\Desktop\Curso VS - Aplicado\App07-visualizadorDeProdutos\imagens\carros");
            foreach (string img in nomeFotosDosCarros)
            {
                string[] separador = img.Split('\\');
                string[] nomeSelecionado = separador[8].Split('.');
   
                if(comboBox2.Text == nomeSelecionado[0])
                {
                    pictureBox2.ImageLocation = @"C:\Users\ricar\Desktop\Curso VS - Aplicado\App07-visualizadorDeProdutos\imagens\carros\" + comboBox2.Text +  ".jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;

            if(comboBox1.Text == "FIAT")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("UNO");
                comboBox2.Items.Add("PALIO");
            }
            else if(comboBox1.Text == "FORD")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ECOSPORT");
                comboBox2.Items.Add("KA");
            }
            else if(comboBox1.Text == "CHEVROLET")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("CELTA");
                comboBox2.Items.Add("AGILE");
            }
            else if(comboBox1.Text == "VOLKSWAGEN")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("GOL");
                comboBox2.Items.Add("POLO");
            }

        }
    }
}
