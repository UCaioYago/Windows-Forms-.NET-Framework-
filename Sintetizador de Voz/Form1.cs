using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;  //namespace para utilização do sintetizador de voz...

namespace SintetizadorDeVoz
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer ss = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)         //carrega o formulário 1
        {

            //carregamento de valores iniciais (padrão)
            foreach (InstalledVoice vozes in ss.GetInstalledVoices())    //carrega as vozes instaladas no Windows
            {
                Program.vozesInstaladas = vozes.VoiceInfo.Name;          //Adiciona a última voz encontrada no sistema para inicializar a "variável" vozes instaladas 
            }
            Program.volume = 60;        //variação de 0 a 100
            Program.taxaReproducao = 1; //variação de -1- a 10.
        }

        private void Form1_Activated(object sender, EventArgs e) //evento de ativação do formulário
        {
            ss.SelectVoice(Program.vozesInstaladas);
            ss.Volume = Program.volume;
            ss.Rate = Program.taxaReproducao;
        }


        #region BOTÃO CONFIGURAR
        private void button4_Click(object sender, EventArgs e) //botão configurar
        {
            FormConfig fc = new FormConfig();
            fc.Show();
            
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)  //botão Ler
        {
            if(textBox1.Text != string.Empty)  //se for diferente de vazio....
            {
                ss.SpeakAsync(textBox1.Text);  //faça a leitura
            }
            else
            {
                MessageBox.Show("Por favor, digite um texto para ser lido...");
            }
            
        }

        private void button2_Click(object sender, EventArgs e) //botão pausar
        {
            ss.Pause();
        }

        private void button3_Click(object sender, EventArgs e)  //botão continuar
        {
            ss.Resume();
        }
    }
}
