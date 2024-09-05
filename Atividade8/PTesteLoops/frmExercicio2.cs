using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteLoops
{
    public partial class frm_ex2 : Form
    {
        public frm_ex2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbx_numero.Text, out int n) && n > 0)
            {
                double numero = 0.0;
                for (int i = 1; i <= n; i++)
                    numero += 1.0 / i;

                tbx_resultado.Text = numero.ToString();
            }
            else
            {
                MessageBox.Show("Insira um valor válido!!!");
                tbx_numero.Text = string.Empty;
                n = 0;
                tbx_numero.Focus();
            }
        }
    }
}
