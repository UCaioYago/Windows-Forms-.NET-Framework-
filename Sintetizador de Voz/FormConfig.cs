using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SintetizadorDeVoz
{
    public partial class FormConfig : Form
    {
        SpeechSynthesizer ss = new SpeechSynthesizer();
        int ajusteVolume = Program.volume;
        int ajusteVelocidade = Program.taxaReproducao;

        public FormConfig()
        {
            InitializeComponent();
           
        }

        private void FormConfig_Load(object sender, EventArgs e)  //carregamento inicial do formulário de configuração...
        {
            foreach (InstalledVoice vozes in ss.GetInstalledVoices())    //carrega as vozes instaladas no Windows
            {
                comboBox1.Items.Add(vozes.VoiceInfo.Name);              //Adiciona as vozes instaladas no combobx
            }

            textBox1.Text = Convert.ToString(Program.volume);           //escrever na text o valor do volume
            textBox2.Text = Convert.ToString(Program.taxaReproducao);   //escrever na text o valor da velocidade
            comboBox1.Text = Program.vozesInstaladas;                   //carregar um nome de voz na combobox
        }

        private void button5_Click(object sender, EventArgs e) //Botão de aplicar
        {
            Program.vozesInstaladas = comboBox1.Text;
            Program.volume = Convert.ToInt32(textBox1.Text);
            Program.taxaReproducao = Convert.ToInt32(textBox2.Text);
            Close();
           
        }


        #region BOTÕES DE AJUSTE
        private void button1_Click(object sender, EventArgs e) //botão MENOS do volume
        {
            ajusteVolume--;
            if(ajusteVolume < 0)
            {
                ajusteVolume = 0;
                MessageBox.Show("O limite mínimo e volume foi atingido...");
            }
            textBox1.Text = Convert.ToString(ajusteVolume);
            Program.volume = ajusteVolume;
        }

        private void button3_Click(object sender, EventArgs e) //botão MAIS do volume
        {
            ajusteVolume++;
            if(ajusteVolume > 100)
            {
                ajusteVolume = 100;
                MessageBox.Show("O limite máximo de volume foi atingido...");
            }
            textBox1.Text = Convert.ToString(ajusteVolume);
            Program.volume = ajusteVolume;
        }

        private void button2_Click(object sender, EventArgs e) //botão MENOS da velocidade
        {
            ajusteVelocidade--;
            if(ajusteVelocidade < -10)
            {
                ajusteVelocidade = -10;
                MessageBox.Show("O limite mínimo da velocidade de reprodução foi atingido...");
            }
            textBox2.Text = Convert.ToString(ajusteVelocidade);
            Program.taxaReproducao = ajusteVelocidade;
        }

        private void button4_Click(object sender, EventArgs e) //botão MAIS da velocidade
        {
            ajusteVelocidade++;
            if(ajusteVelocidade > 10)
            {
                ajusteVelocidade = 10;
                MessageBox.Show("O limite máximo da velocidade de reprodução foi atingido...");
            }
            textBox2.Text = Convert.ToString(ajusteVelocidade);
            Program.taxaReproducao = ajusteVelocidade;
        }
        #endregion
    }
}
