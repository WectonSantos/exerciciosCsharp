using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp10_wecton_228550
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            if (tituloEleitor.ClsTitulo.ValidaTitulo(txtTitulo.Text) == true)
            {
                lblResultado.Text = "TITULO Correto";
            }
            else
            {
                lblResultado.Text = "TITULO Errado";
            }
        }
    }
}