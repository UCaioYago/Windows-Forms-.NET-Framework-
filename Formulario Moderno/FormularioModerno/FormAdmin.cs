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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e) //FECHAR - clicar no botão do "xizinho"
        {
            Application.Exit();  //fecha TUDO!!!!
        }

        private void pictureBox5_Click(object sender, EventArgs e) //botão de minimizar janela
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e) //timer que atualiza a data e a hora ...
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
            label1.Text = Program.nome;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }


        #region BOTÕES DO MENU LATERAL - ADMINISTRADOR
        private void button1_Click(object sender, EventArgs e) //botão de produtos
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

        private void button3_Click(object sender, EventArgs e)//botão de clientes
        {
            FormUserClientes fuc = new FormUserClientes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(fuc);
            fuc.Show();
        }

        private void button4_Click(object sender, EventArgs e) //botão de fornecedores
        {
            FormAdminFornecedores faf = new FormAdminFornecedores() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(faf);
            faf.Show();
        }

        private void button5_Click(object sender, EventArgs e) //botão funcionários
        {
            FormAdminFuncionarios fafu = new FormAdminFuncionarios() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(fafu);
            fafu.Show();
        }

        private void button6_Click(object sender, EventArgs e) //botão relatórios
        {
            FormAdminRelatorios far = new FormAdminRelatorios() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(far);
            far.Show();
        }
        #endregion

        private void pictureBox2_Click(object sender, EventArgs e) // Home - Retorna para tela inicial
        {
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(label1);
            this.panel3.Controls.Add(label2);
            this.panel3.Controls.Add(label3);
            this.panel3.Controls.Add(pictureBox6);
        }

        private void pictureBox1_Click(object sender, EventArgs e)  //Botão de menu - ajuste da largura do menu lateral
        {
            if (panelMenuLateralUser.Width > 63)
            {
                panelMenuLateralUser.Width = 63;
            }
            else
            {
                panelMenuLateralUser.Width = 232;
            }
        }
    }
}
