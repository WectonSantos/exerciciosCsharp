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

namespace aula04
{
    public partial class frmJogo : Form
    {
        #region variaveis globais
        int x, define, venceu = 0, empatou = 0, perdeu = 0;
        #endregion
        public frmJogo()
        {
            InitializeComponent();
        }
        #region escolhe
        void escolhe()
        {
            Random sorteio = new Random();
            x = sorteio.Next(1,100);
            define = x % 3;
        }
        #endregion
        private void pbC4_Click(object sender, EventArgs e)
        {
            if(define == 1)
            {
                empatou++;
                lblEmpatou.Text = empatou.ToString();
                pbC1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\pedra1.png");
            }else if(define==2){
                perdeu++;
                lblPerdeu.Text = perdeu.ToString();
                pbC2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\tesoura.png");
            }
            else if (define == 3) {
                venceu++;
                lblVenceu.Text = venceu.ToString();
                pbC2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\papel.png");
            }
            continua();
        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            escolhe();
        }

        private void pbC5_Click(object sender, EventArgs e)
        {
            if (define == 1)
            {
                perdeu++;
                lblPerdeu.Text = perdeu.ToString();
                pbC1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\pedra1.png");
            }
            else if (define == 2)
            {
                empatou++;
                lblEmpatou.Text = empatou.ToString();
                pbC2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\tesoura.png");
            }
            else if (define == 3)
            {
                venceu++;
                lblVenceu.Text = venceu.ToString();
                pbC2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\papel.png");
            }
            continua();
        }

        private void pbC6_Click(object sender, EventArgs e)
        {
            if (define == 1)
            {
                venceu++;
                lblVenceu.Text = venceu.ToString();
                pbC1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\pedra1.png");
            }
            else if (define == 2)
            {
                perdeu++;
                lblPerdeu.Text = perdeu.ToString();
                pbC2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\tesoura.png");
            }
            else if (define == 3)
            {
                empatou++;
                lblEmpatou.Text = empatou.ToString();
                pbC2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\papel.png");
            }
            continua();
        }

        void continua()
        {
            MessageBox.Show("Nova Jogada", "Próximo jogo...");
            pbC1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\pergunta.png");
            pbC2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\pergunta.png");
            pbC3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\pergunta.png");
            escolhe();
        }

        #region lixo
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void lblEmpatou_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region mudarNome
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            gbJogador.ForeColor = Color.Red;
            gbJogador.Text = "Jogador(a) - " + txtNome.Text;
        }
        #endregion
    }
}
