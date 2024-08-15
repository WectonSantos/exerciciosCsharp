using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp01_wecton_228550
{
    public partial class frmTela : Form
    {
        public frmTela()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtR1.Text = "";
            txtR2.Text = "";
            txtR3.Text = "";
            lblResultado.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float r1 = float.Parse(txtR1.Text);
            float r2 = float.Parse(txtR2.Text);
            float r3 = float.Parse(txtR3.Text);

            float r4, r5, r6;
            r4 = (r1 * r2) / (r1 + r2 + r3);
            r5 = (r2 * r3) / (r1 + r2 + r3);
            r6 = (r3 * r1)/(r1+ r2 + r3);

            lblResultado.Text = "Os resultados são:\nR4 = "+ r4 +"\nR5= "+ r5 + "\nR6= " + r6;
        }
    }
}
