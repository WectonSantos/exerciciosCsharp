using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp03_wecton_228550
{
    public partial class Form1 : Form
    {
        #region variaveis
        string msg, titulo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        #endregion variaveis

        public Form1()
        {
            InitializeComponent();
        }

        #region botão-calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {

            Double s0, v0, a, t, s, v;

            try
            {
                s0 = Convert.ToDouble(txtEspacoInicial.Text);
                v0 = Convert.ToDouble(txtVelocidadeInicial.Text);
                a = Convert.ToDouble(txtVelocidadeInicial.Text);

                string verificaA = txtAceleracao.Text;
                if (verificaA == "")
                {
                    a = 0;
                }

                t = Convert.ToDouble(txtTempo.Text);

                if (s0 <= 0)
                {
                    MessageBox.Show("Erro!");
                    txtEspacoInicial.Clear();
                    txtEspacoInicial.Focus();
                }
                else
                {
                    if (v0 < 0)
                    {
                        MessageBox.Show("Erro!");
                        txtVelocidadeInicial.Clear();
                        txtVelocidadeInicial.Focus();
                    }
                    else
                    {
                        if (t <= 0)
                        {
                            MessageBox.Show("Erro!");
                            txtTempo.Clear();
                            txtTempo.Focus();
                        }
                        else
                        {
                            if (a <= 0)
                            {
                                s = s0 + v0 * t;
                                txtResultado.Text = s.ToString();
                                txtResultado2.Text = v0.ToString();

                            }
                            else
                            {
                                s = s0 + v0 * t + ((a * (t*t)) / 2);
                                v = v0 + (a * t);
                                txtResultado.Text = s.ToString();
                                txtResultado2.Text = v.ToString();

                            }
                        }
                    }
                    
                   
                }
            }
            catch
            {
                MessageBox.Show("Erro!");
                return;
            }
        }
        #endregion

        #region botao-limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            msg = "Quer mesmo limpar?";
            titulo = "Limpar os campos...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Information;
            definido = MessageBoxDefaultButton.Button2;

            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                txtEspacoInicial.Text = "";
                txtAceleracao.Text = ""; 
                txtVelocidadeInicial.Text = "";
                txtTempo.Text = "";
                txtResultado.Text = "";
                txtResultado2.Text = "";
                txtEspacoInicial.Focus();
            }
        }
        #endregion

        #region data-hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTempo.Text = DateTime.Now.ToString();
        }
        #endregion

        #region botao-sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            msg = "Tem certeza?";
            titulo = "Sair do programa...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            definido = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
