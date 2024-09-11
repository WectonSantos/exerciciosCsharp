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

namespace aula05
{
    public partial class frmPrincipal : Form
    {
        #region variaveis globais
        int contador = 1, seleciona = 0, tipo = 0;
        Double comprimento, angulo, anguloRad, tempo;
        #endregion

        #region data
        private void tmrData_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString();
        }
        #endregion

        #region fechar
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Deseja Sair?","Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            e.Cancel = true;
            
        }
        #endregion

        #region botao limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirma","Limpar dados...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                seleciona = 0;
                contador = 1;
                rbDeslocamento.Checked = false;
                rbPeriodo.Checked = false;
                txtComprimento.Clear();
                txtAngulo.Clear();
                txtTempo.Clear();
                txtComprimento.Visible = false;
                txtAngulo.Visible = false;
                txtTempo.Visible = false;
                lbxResultado.Items.Clear();
            }
        }
        #endregion
        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region carregar
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            seleciona=0;
            tipo = 0;
            contador = 1;
            btnLimpar.Enabled = false;
            btnCalcular.Enabled = false;
            txtComprimento.Visible=false;
            txtAngulo.Visible=false; 
            txtTempo.Visible=false;
        }
        #endregion

        #region pendulo animacao
        private void tmrAnimacao_Tick(object sender, EventArgs e)
        {
            contador = contador % 16 + 1;
            pbPendulo.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Pend" +
                Convert.ToString(contador) + ".bmp");
        }
        #endregion

        #region radio buttons
        private void rbPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            seleciona = 1;
            txtComprimento.Visible=true;
            txtAngulo.Visible = false;
            txtTempo.Visible = false;
            txtComprimento.Focus();
            grbResultado.Text= "Ensaio - "+rbPeriodo.Text;
        }

        private void rbDeslocamento_CheckedChanged(object sender, EventArgs e)
        {
            seleciona = 2;
            txtComprimento.Visible = true;
            txtAngulo.Visible = true;
            txtTempo.Visible = true;
            txtComprimento.Focus();
            grbResultado.Text = "Ensaio - " + rbDeslocamento.Text;
        }
        #endregion

        #region rotina que verifica numericos
        private void verifica(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 44 || e.KeyChar == 45 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion

        #region Caixa de Erros
        private void Tipo(object sender, CancelEventArgs e)
        {
            switch (tipo)
            {
                case 1:
                    MessageBox.Show("Comprimento Errado", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtComprimento.Clear();
                    txtComprimento.Focus();
                    break;
                case 2:
                    MessageBox.Show("Ângulo Incorreto", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAngulo.Clear();
                    txtAngulo.Focus();
                    break;
                case 3:
                    MessageBox.Show("Tempo Incorreto", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTempo.Clear();
                    txtTempo.Focus();
                    break;
            }
        }
        #endregion

        #region validando comprimento
        private void txtComprimento_Validating(object sender, CancelEventArgs e)
        {
            if (txtComprimento.Text != "")
            {
                try
                {
                    tipo = 1;
                    comprimento = Convert.ToDouble(txtComprimento.Text);
                    if (comprimento <= 0)
                    {
                        Tipo(sender, e);
                    }

                }
                catch
                {
                    Tipo(sender, e);
                }
            }
        }
        #endregion


        #region lixo
        private void txtComprimento_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
