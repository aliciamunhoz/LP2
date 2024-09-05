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
    public partial class frm_ex3 : Form
    {
        public frm_ex3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblP1_Click(object sender, EventArgs e)
        {

        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            if (String.Compare(tbx_1.Text,tbx_2.Text,true) == 0)
            {
                MessageBox.Show("Iguais");
            }
            else
            {
                MessageBox.Show("Diferentes");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int meio = tbx_2.Text.Length / 2;
            tbx_2.Text= tbx_2.Text.Substring(0,meio)+tbx_1.Text + tbx_2.Text.Substring(meio,tbx_2.TextLength-meio);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int meio = tbx_1.Text.Length / 2;
            tbx_2.Text = tbx_1.Text.Insert(meio, "**");
        }
    }
}
