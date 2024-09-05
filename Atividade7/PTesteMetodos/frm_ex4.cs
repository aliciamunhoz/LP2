using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class frm_ex4 : Form
    {
        public frm_ex4()
        {
            InitializeComponent();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            tbx_1.Text = tbx_1.Text.ToLower();
            tbx_1.Text = tbx_1.Text.ToUpper();
            tbx_2.Text = tbx_2.Text.Replace(tbx_1.Text, "");
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            char[] vet = tbx_1.Text.ToCharArray();  
            Array.Reverse(vet);
            tbx_2.Text= new string(vet);
        }
    }
}
