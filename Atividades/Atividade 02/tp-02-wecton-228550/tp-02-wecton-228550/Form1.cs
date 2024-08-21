using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_02_wecton_228550
{
    public partial class frmForcaAtrito : Form
    {
        #region variaveis globais
        string msg, titulo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        #endregion
        public frmForcaAtrito()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double g = 10;
            double m = double.Parse(txtMassa.Text);
            double atrito = double.Parse(txtAtrito.Text);
            double F = double.Parse(txtForca.Text);
            double a = double.Parse(txtAngulo.Text);
            a = a * (180/Math.PI);
            double fat;
            double d = double.Parse(txtDeslocamento.Text);
            double sinA = Math.Sin(a);
            double cosA = Math.Cos(a);

            fat = atrito * (m * g - F * sinA) * d * cosA;
            fat = Math.Round(fat, 2);
            txtResultado.Text = ""+fat+"º";

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
                txtMassa.Text = "";
                txtAtrito.Text = ""; // ou txtIdade.Clear();
                txtForca.Text = "";
                txtAngulo.Text = "";
                txtResultado.Text = "";
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
        #region lixo
        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }

}
