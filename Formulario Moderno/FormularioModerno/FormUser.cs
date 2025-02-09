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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) //ícone de menu
        {
            if(panelMenuLateralUser.Width > 63)
            {
                panelMenuLateralUser.Width = 63;
            }
            else
            {
                panelMenuLateralUser.Width = 232;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)  //botão de fechar
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)  //timer para atualização de data e hora...
        {
            label2.Text = DateTime.Now.ToLongTimeString();  //exibe a hora atual
            label3.Text = DateTime.Now.ToLongDateString();  //exibe a data atual
            label1.Text = Program.nome;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)  //botão de produtos
        {
            FormUserProdutos fup = new FormUserProdutos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(fup);
            fup.Show();
        }

        private void button2_Click(object sender, EventArgs e) //botão de vendas
        {
            FormUserVendas fuv = new FormUserVendas() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(fuv);
            fuv.Show();
        }

        private void button3_Click(object sender, EventArgs e)  //botão de clientes
        {
            FormUserClientes fuc = new FormUserClientes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(fuc);
            fuc.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)  //home - retorno a tela principal...
        {
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(label1);
            this.panel3.Controls.Add(label2);
            this.panel3.Controls.Add(label3);
            this.panel3.Controls.Add(pictureBox6);
        }
    }
}
