using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal aporte;
            int prazo;
            decimal taxa;
            decimal valorFinal;

            aporte = Convert.ToDecimal(textBox1.Text);
            prazo = Convert.ToInt32(textBox2.Text);
            taxa = Convert.ToDecimal(textBox3.Text);

            taxa = taxa / 100;
            valorFinal = aporte;

            for (int i = 0; i < prazo; i++)
            {
                valorFinal = valorFinal + (valorFinal * taxa);
            }

            string[] vf; // array
            vf = Convert.ToString(valorFinal).Split(',');
            textBox4.Text = "R$" + vf[0] + "," + vf[1].Substring(0, 2); // Substring decide casas pós virgula

            decimal lucro = valorFinal - aporte; // Obtendo o Lucro Real
            string[] lf;
            lf = Convert.ToString(lucro).Split(',');
            textBox5.Text = "R$ " + lf[0] + "," + lf[1].Substring(0, 2);
            textBox5.Text = Convert.ToString(lucro);
        }
    }
}