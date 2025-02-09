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


namespace CadastroClientes
{
    public partial class Form1 : Form
    {
        static string pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string arquivo = "registros.txt";
        string local = Path.Combine(pasta, arquivo);
        int id = 1;

        public Form1()
        {
            InitializeComponent();
        }

        #region Inicialização
        private void Form1_Load(object sender, EventArgs e)  //na inicialização
        {
            try
            {
                id = File.ReadLines(local).Count() + 1;
                textBox1.Text = Convert.ToString(id);
                textBox1.Enabled = false;
            }
            catch
            {
                textBox1.Text = Convert.ToString(1);
                textBox1.Enabled = false;
            }

                
        }
        #endregion


        #region Botão de cadastro de cliente
        private void button1_Click(object sender, EventArgs e)  //Botão de cadastro de cliente
        {
            if (textBox2.Text == string.Empty || textBox3.Text ==string.Empty || textBox4.Text==string.Empty)
            {
                MessageBox.Show("Por favor, preencha todos os campos...");
            }
            else
            {
                StreamWriter sw = new StreamWriter(local, true);
                sw.WriteLine(textBox1.Text + " - " + textBox2.Text + " - " + textBox3.Text + " - " + textBox4.Text);
                sw.Close();
                MessageBox.Show("Cadastro realizado com sucesso!");
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                id++;
                textBox1.Text = Convert.ToString(id);
            }
       
        }
        #endregion


        #region Botão de atualizar
        private void button2_Click(object sender, EventArgs e)  //botão de atualizar
        {
            if (id > 1)
            {

                int numeroLinhas = 0;
                int qtd = File.ReadLines(local).Count();

                dataGridView1.Rows.Clear();

                for (int i = 0; i < qtd; i++)  //inserir linhas no datagrid
                {
                    dataGridView1.Rows.Add();
                }

                StreamReader sr = new StreamReader(local);

                while (sr.EndOfStream == false)
                {
                    string linhaCompleta = sr.ReadLine();
                    string[] campos = linhaCompleta.Split('-');

                    dataGridView1.Rows[numeroLinhas].Cells[0].Value = campos[0];
                    dataGridView1.Rows[numeroLinhas].Cells[1].Value = campos[1];
                    dataGridView1.Rows[numeroLinhas].Cells[2].Value = campos[2];
                    dataGridView1.Rows[numeroLinhas].Cells[3].Value = campos[3];

                    numeroLinhas++;
                }
                sr.Close();
            }
            else
            {
                MessageBox.Show("Ainda não existem dados cadastrados...");
            }

        }
        #endregion
    }
}
