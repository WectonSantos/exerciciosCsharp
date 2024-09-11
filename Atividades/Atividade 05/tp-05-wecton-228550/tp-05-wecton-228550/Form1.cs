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

namespace tp_05_wecton_228550
{
    public partial class frmPrincipal : Form
    {
        #region variaveis globais
        int contador = 1, apoio, tipo;
        Double af, c1, f;
        Double r1, r2, r3, c2;
        #endregion
        #region data
        private void tmrData_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString();  
        }
        #endregion

        #region verificacoes texto
        private void txtAmp_TextChanged(object sender, EventArgs e)
        {
            verifica();
        }

        private void txtCap_TextChanged(object sender, EventArgs e)
        {
            verifica();
        }

        private void txtFreq_TextChanged(object sender, EventArgs e)
        {
            verifica();
        }
        void verifica()
        {

            if(txtAmp.TextLength>0 && txtCap.TextLength>0 && txtFreq.TextLength>0)
            {
                btnCalcular.Enabled = true;
                btnLimpar.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }
        #endregion

        #region validando numeros
        private void txtAmp_Validating(object sender, CancelEventArgs e)
        {
            if (txtAmp.Text != "")
            {
                try
                {
                    tipo = 1;
                    af = Convert.ToDouble(txtAmp.Text);
                }
                catch
                {
                    Tipo(sender, e);
                }
            }
        }

        private void txtCap_Validating(object sender, CancelEventArgs e)
        {
            if (txtCap.Text != "")
            {
                try
                {
                    tipo = 2;
                    c1 = Convert.ToDouble(txtCap.Text);
                }
                catch
                {
                    Tipo(sender, e);
                }
            }
        }

        private void txtFreq_Validating(object sender, CancelEventArgs e)
        {
            if (txtFreq.Text != "")
            {
                try
                {
                    tipo = 3;
                    f = Convert.ToDouble(txtFreq.Text);
                }
                catch
                {
                    Tipo(sender, e);
                }
            }
        }

        private void Tipo(object sender, CancelEventArgs e)
        {
            switch (tipo)
            {
                case 1:
                    MessageBox.Show("Amplificação Errada", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmp.Clear();
                    txtAmp.Focus();
                    break;
                case 2:
                    MessageBox.Show("Capacitor Incorreto", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCap.Clear();
                    txtCap.Focus();
                    break;
                case 3:
                    MessageBox.Show("Frequência Incorreta", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFreq.Clear();
                    txtFreq.Focus();
                    break;
            }
        }
        #endregion
        #region carregar
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            btnCalcular.Enabled = false;
            btnLimpar.Enabled = false;
        }
        #endregion
        #region limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma", "Limpar dados...",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                txtAmp.Clear();
                txtCap.Clear();
                txtFreq.Clear();
                lbxC2.Items.Clear();
                lbxR1.Items.Clear();
                lbxR2.Items.Clear();
                lbxR3.Items.Clear();
            }
        }
        #endregion
        #region fechar
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair", "Encerando o Aplicativo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
        #endregion

        #region calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            af = Convert.ToDouble(txtAmp.Text);
            c1 = Convert.ToDouble(txtCap.Text);
            f = Convert.ToDouble(txtFreq.Text);

            try
            {
                for(int i =0; i<af; i++)
                {
                    r1 = (Math.Sqrt(2)) / 2 * af * 2 * Math.PI * f * c1;
                    r2 = i * r1;
                    r3 = r2 / (i + 1);
                    c2 = 2 * (i + 1) * c1;
                    lbxR1.Items.Add("R1 = " + r1.ToString("#00.00"));
                    lbxR2.Items.Add("R2 = " + r2.ToString("#00.00"));
                    lbxR3.Items.Add("R3 = " + r3.ToString("#00.00"));
                    lbxC2.Items.Add("C2 = " + c2.ToString("#00.00"));
                }
            }
            catch
            {

            }
        }
        #endregion
        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region animacao
        private void tmrAnimacao_Tick(object sender, EventArgs e)
        {
            contador = contador % 9 + 1;
            // chamada a respectiva imagem no objeto PictureBox
            pbxImagem.Image = Image.FromFile(Directory.GetCurrentDirectory() +
                "\\res" + Convert.ToString(contador) + ".png");
        }
        #endregion
    }
}
