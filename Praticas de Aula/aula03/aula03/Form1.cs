using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula03
{
    public partial class frmPrincipal : Form
    {
        #region variaveis
        string msg, titulo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        #endregion variaveis
        public frmPrincipal()
        {
            InitializeComponent();
        }   
        #region btnSair
        private void button1_Click(object sender, EventArgs e)
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
        #endregion btnSair
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double comprimento, largura, espaco, aux, capacitancia;
            try
            {
                comprimento = Convert.ToDouble(txtComprimento.Text);
                largura = Convert.ToDouble(txtLargura.Text);
                espaco = Convert.ToDouble(txtEspaco.Text);
                if(comprimento <= 0)
                {
                    MessageBox.Show("Erro!");
                    txtComprimento.Clear();
                    txtComprimento.Focus();
                }
                else
                {
                    if(largura <= 0)
                    {
                        MessageBox.Show("Erro!");
                        txtLargura.Clear();
                        txtLargura.Focus();
                    }
                    else
                    {
                        if(espaco <= 0)
                        {
                            MessageBox.Show("Erro!");
                            txtEspaco.Clear();
                            txtLargura.Focus();
                        }
                        else{
                            if ((100 * largura) < comprimento)
                            {
                               capacitancia = 0.0885419 * comprimento * (largura / espaco);
                            }
                            else
                            {
                                aux = (espaco / Math.PI) * (1 / largura) * (1 - Math.Log(2 * Math.PI * (largura / espaco)));
                                capacitancia = 0.0885419 * comprimento * (largura / espaco) * (1 + aux);
                            }
                            txtResultado.Text = (Math.Round(capacitancia,2)).ToString();
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

        private void tempo_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            msg = "Quer mesmo limpar?";
            titulo = "Limpar os campos...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Information;
            definido = MessageBoxDefaultButton.Button2;

            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                txtComprimento.Text = "";
                txtLargura.Text = ""; // ou txtIdade.Clear();
                txtResultado.Text = "";
                txtEspaco.Text = "";
                txtComprimento.Focus();
            }
        }
    }
}
