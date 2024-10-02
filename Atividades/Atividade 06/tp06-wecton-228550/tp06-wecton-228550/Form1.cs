using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp06_wecton_228550
{
    public partial class frmPrincipal : Form
    {
        #region variaveis globais
        int[] x = new int[50];
        int[] y = new int[50];
        int soma = 0, media = 0, total = 0;
        int i, quantidade = 50;
        Boolean muda;
        #endregion
        public frmPrincipal()
        {
            InitializeComponent();
        }
        #region animacaoTexto
        private void tmrLuz_Tick(object sender, EventArgs e)
        {
            if (muda == true)
            {
                lblMensagem.ForeColor = Color.Red;
                muda = false;
            }
            else
            {
                lblMensagem.ForeColor = Color.Black;
                muda = true;
            }
        }
        #endregion
        #region botoes
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma?", "Limpar",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                txtAltura.Clear();
                lbxAlturasF.Items.Clear();
                lbxRol.Items.Clear();
                txtAltura.Focus();
            }
        }


        private void sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome do aluno: Wecton Santos\nR.A: 228550","Desenvolvido por", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        #endregion



        #region validacao, adicionar altura, media, e rol
        private void txtAltura_Validating(object sender, CancelEventArgs e)
        {
            if (txtAltura.Text != "")
            {
                if (i < quantidade)
                {
                    try
                    {
                        x[i] = int.Parse(txtAltura.Text);
                        lbxRol.Items.Clear();

                        if (x[i]<140 || x[i] > 240)
                        {
                            MessageBox.Show("Altura Inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            for (int a = 1; a < 50; a++)
                            {
                                if (y[a] != 0)
                                {
                                    lbxRol.Items.Add(Convert.ToString(y[a]));
                                }
                            }
                        }
                        else
                        {
                            lbxAlturasF.Items.Add(Convert.ToString(x[i]));
                            soma += x[i];
                            total++;
                            media = soma / total;
                            y[i] = x[i];
                            lblResultado.Text = Convert.ToString(media);
                            Array.Sort(y, 0, i + 1);
                            for(int a = 1; a<50; a++)
                            {
                                if (y[a] != 0)
                                {
                                  lbxRol.Items.Add(Convert.ToString(y[a]));
                                }
                            }
                            i++;
                            txtAltura.Clear(); txtAltura.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Valor Inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAltura.Clear(); txtAltura.Focus();
                    }
                }
            }
            else
            {
                return;
            }
        }
        #endregion

        #region load
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            i = 1;
            muda = true;
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
        #region lixo
        private void detalgesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        #endregion
    }
}
