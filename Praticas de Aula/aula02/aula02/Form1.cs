using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula02
{
    public partial class frmDiasVividos : Form
    {
        #region variaveis
        string msg, titulo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        #endregion

        public frmDiasVividos()
        {
            InitializeComponent();
        }
        #region codigos
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            const int dias = 365;
            int anos = Int32.Parse(txtIdade.Text);

            lblResultado.Text = txtNome.Text + ", você tem " + (anos * dias) + " dias de vida.";
        }

        private void frmDiasVividos_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "Bem Vindo!";

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
                txtIdade.Text = "";
                txtNome.Text = ""; // ou txtIdade.Clear();
                lblResultado.Text = "";
            }

        }

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
    }
}
