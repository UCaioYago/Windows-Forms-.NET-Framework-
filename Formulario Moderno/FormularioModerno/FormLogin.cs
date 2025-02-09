using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioModerno
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
  
        private void textBox1_MouseDown(object sender, MouseEventArgs e)  //ao clicar sobre o campo de login
        {
            if (textBox1.Text == "USUÁRIO")
            {
                textBox1.Clear();  //limpa o texto inicial
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e) //ao clicar sobre o campo de password
        {
            textBox2.Clear();  //limpa o texto inicial
            textBox2.ForeColor = Color.LightGray;
            textBox2.UseSystemPasswordChar = true;
        }

        private void textBox1_Enter(object sender, EventArgs e)  //Acessar o campo de login
        {
            if(textBox1.Text == "USUÁRIO"){
                textBox1.Clear();  //limpa o texto inicial
                textBox1.ForeColor = Color.LightGray;
            }
            
        }

        private void textBox2_Enter(object sender, EventArgs e) //Acessar o campo de passwrd
        {
            textBox2.Clear();  //limpa o texto inicial
            textBox2.ForeColor = Color.LightGray;
            textBox2.UseSystemPasswordChar = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)  //sair do campo de login
        {
            if(textBox1.Text == string.Empty)   //se estiver vazio...
            {
                textBox1.Text = "USUÁRIO";              //volta a escrever "usuário"
                textBox1.ForeColor = Color.DimGray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text == string.Empty)
            {
                textBox2.Text = "SENHA";
                textBox2.ForeColor = Color.DimGray;
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)  //se clicar no "xizinho"
        {
            Application.Exit();  //fecha tudo!!
        }




        private void exibirTelaSplashScreen(string nivel)
        {
            Program.nome = textBox1.Text;  //captura o nome de quem fez a conexão (campo usuário)
            this.Hide();   //ocultar o form login
            FormSplashScreen fss = new FormSplashScreen();
            fss.Show();
            Program.login = nivel;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "1234") //se o usuário for "admin" com senha 1234....
            {
                exibirTelaSplashScreen("admin"); 
            }
            else if(textBox1.Text == "Maria" && textBox2.Text == "mar1") //login do operador 1
            {
                exibirTelaSplashScreen("user");
            }
            else if(textBox1.Text == "Paulo" && textBox2.Text == "pandre") //login do operador 2
            {
                exibirTelaSplashScreen("user");
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos...");
            }
        }
    }
}
