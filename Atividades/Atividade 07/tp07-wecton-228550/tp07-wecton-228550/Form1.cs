using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace tp07_wecton_228550
{
    public partial class frmPrincipal : Form
    {
        #region variáveis globais
        string[,] labirinto = new string[23, 31]
            {
                {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1"},
                {"1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"1","1","1","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
                {"0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0"},
            };

        int posLinha = 0, posColuna = 31;
        string controle;
        private int timeLeft = 60;
        #endregion
        public frmPrincipal()
        {
            InitializeComponent();
            timer1.Interval = 1000; 

        }
        #region timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTempo.Text = "" + timeLeft;
            if (timeLeft > 0)
            {
                timeLeft--;
                lblTempo.Text = $"{timeLeft}";
            }
            else
            {
                timer1.Stop();
                lblTempo.Text = "Tempo esgotado!";
            }

            int x = pbPersonagem.Location.X;
            int y = pbPersonagem.Location.Y;


            if ((x == 953) && (y == 617))
            {
                timer1.Stop();
                MessageBox.Show("Chegou na saída...", "Fim de Jogo");
            }

            else if (controle == "A")
            {
                pbPersonagem.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\esquerda.png");
                pbPersonagem.Size = new Size(37, 48);

                if (posColuna == 0) return;

                if (labirinto[posLinha, posColuna - 1] == "1")
                {
                    pbPersonagem.Location = new Point(x - 20, y);
                    posColuna--;

                }
            }

            else if (controle == "D")
            {
                pbPersonagem.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\direita.png");
                pbPersonagem.Size = new Size(37, 48);

                if (posColuna == 16) return;

                if (labirinto[posLinha, posColuna + 1] == "1")
                {
                    pbPersonagem.Location = new Point(x + 20, y);
                    posColuna++;
                }
            }

            else if (controle == "W")
            {
                pbPersonagem.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\sobe.png");
                pbPersonagem.Size = new Size(37, 48);

                if (posLinha == 0) return;

                if (labirinto[posLinha - 1, posColuna] == "1")
                {
                    pbPersonagem.Location = new Point(x, y - 20);
                    posLinha--;
                }
            }

            else if (controle == "S")
            {
                pbPersonagem.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\desce.png");
                pbPersonagem.Size = new Size(37, 48);

                if (posLinha == 8) return;

                if (labirinto[posLinha + 1, posColuna] == "1")
                {
                    pbPersonagem.Location = new Point(x, y + 20);
                    posLinha++;
                }
            }

            if(timeLeft == 0)
            {
                
            }

        }
        #endregion
        #region teclas
        private void frmPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().ToUpper() == "A" || e.KeyChar.ToString().ToUpper() == "D" ||
                e.KeyChar.ToString().ToUpper() == "W" || e.KeyChar.ToString().ToUpper() == "S")
            {
                controle = e.KeyChar.ToString().ToUpper();
                timer1.Start();
            }

            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
