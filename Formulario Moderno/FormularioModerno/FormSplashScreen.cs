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
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)  //a cada contagem do timer, executa esse método...
        {
            progressBar1.Increment(2);    //conta de 2 em 2 na barra de progresso
            if (progressBar1.Value == 100)  //se a barra chegar em 100%...
            {
                timer1.Stop();              //para de contar....
                timerFadeOUT.Start();       //ligar o timer do fade out...
            }
        }

        private void timerFadeIN_Tick(object sender, EventArgs e) //timer do fade IN
        {
            if(this.Opacity == 1)
            {
                timerFadeIN.Stop();
            }
            else
            {
                this.Opacity = this.Opacity + 0.02;
            } 
        }

        private void FormSplashScreen_Load(object sender, EventArgs e) //inicialização do formSPlashScreen
        {
            this.Opacity = 0;
        }

        private void timerFadeOUT_Tick(object sender, EventArgs e) //contagem para desaparecimento suave da tela de splashScreen
        {
            if(this.Opacity == 0)  //se desapareceu por completo...
            {
                timerFadeOUT.Stop();
                this.Dispose();
                
                if(Program.login == "admin")
                {
                    FormAdmin fa = new FormAdmin();
                    fa.Show();
                }
                else if(Program.login == "user")
                {
                    FormUser fu = new FormUser();
                    fu.Show();
                }
                else
                {
                    MessageBox.Show("Não foi possível estabelecer a conexão...");
                }
                
            }
            else
            {
                this.Opacity = this.Opacity - 0.02;
            }
        }
    }
}
