using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorCPF
{
    public partial class Form1 : Form
    {
        Validador validar = new Validador();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //botão de verificação do CPF
        {
            try
            {
                
                if(validar.CPF(maskedTextBox1.Text) ==  true)
                {
                    MessageBox.Show("SUCESSO", "CPF Válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ATENÇÃO", "CPF Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Verifique o número do CPF");
            }
        }

        private void button3_Click(object sender, EventArgs e)  //botão de verificação do Telefone
        {
            try
            {
                if(validar.Telefone(maskedTextBox3.Text) == true)
                {
                    MessageBox.Show("SUCESSO", "Telefone Válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ATENÇÃO", "Telefone Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Verifique o número do Telefone");
            }
        }

        private void button2_Click(object sender, EventArgs e)  //botão de verificação do E-mail
        {
            try
            {
                if (validar.Email(textBox1.Text) == true)
                {
                    MessageBox.Show("SUCESSO", "E-mail Válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ATENÇÃO", "E-mail Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Verifique o endereço do E-mail");
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e) //e-mail
        {
            textBox1.Clear();  //apaga o exemplo de e-mail ao clicar
            textBox1.ForeColor = Color.Black;  //muda a cor da fonte
        }

        private void maskedTextBox1_MouseDown(object sender, MouseEventArgs e) //cpf
        {
            maskedTextBox1.SelectionStart = 0;  //ao clicar em qualquer posição do campo, o cursor vaia para o início da linha (posição 0).
        }

        private void maskedTextBox3_MouseDown(object sender, MouseEventArgs e) //telefone
        {
            maskedTextBox3.SelectionStart = 0; //ao clicar em qualquer posição do campo, o cursor vaia para o início da linha (posição 0).
        }
    }
}
