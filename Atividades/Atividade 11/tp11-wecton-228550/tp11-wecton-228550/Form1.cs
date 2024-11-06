using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp11_wecton_228550
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dllCartao2.Validacoes.ValidaCartao(txtCartao.Text) == true)
                {
                    lblResultado.Text = "VÁLIDO";
                    lblResultado.ForeColor = Color.Green;

                }
                else
                {
                    lblResultado.Text = "INVÁLIDO";
                    lblResultado.ForeColor = Color.Red;

                }
            }
            catch
            {
                MessageBox.Show("Valor Inválido!");
            }
 
        }
    }
}
