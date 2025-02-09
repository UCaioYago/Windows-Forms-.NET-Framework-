using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class Form1 : Form
    {
        int speedY = 8;
        int speedX = 8;
        int speedBall = 1;
        int points = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(panelBall.Top >= panelArea.Height - panelBall.Height)  //colisão com a base
            {
                speedY = speedY * -1;
            }
            if(panelBall.Left >= panelArea.Width - panelBall.Width)  //colisão P2 (direita)
            {
                speedBall++;
                speedX = speedX + 4;
                speedY = speedY + 4;
                speedX = speedX * -1;
                label4.Text = Convert.ToString(speedBall);
            }
            if(panelBall.Top <= 0)                                  //colisão com o topo
            {
                speedY = speedY * -1;
            }
            if(panelBall.Left <= 0)                                 //colisão com P1 (esquerda)
            {
                speedX = speedX * -1;
                points++;
                label2.Text = Convert.ToString(points);
            }

            panelBall.Top = panelBall.Top + speedY;  //desloca bolinha na vertical
            panelBall.Left = panelBall.Left + speedX; //desloca bolinha na horizontal

            //MOVIMENTAÇÃO DO PLAYER 1
            if(Cursor.Position.Y - this.Top - 125 >= 0  && Cursor.Position.Y - this.Top -32 <= panelArea.Height)
            {
                panelPlayer1.Top = Cursor.Position.Y - this.Top - 125; //movimentação do P1
            }

            //MOVIMENTAÇÃO DO PLAYER 2
            panelPlayer2.Top = panelBall.Top;

            //DETECÇÃO DE COLISÃO
            if(panelBall.Left < panelPlayer1.Left && (panelBall.Top < panelPlayer1.Top - panelBall.Height || panelBall.Top > panelPlayer1.Top + panelPlayer1.Height))
            {
                timer1.Enabled = false;
                MessageBox.Show("GAME OVER...");
            }
            
        }
    }
}
