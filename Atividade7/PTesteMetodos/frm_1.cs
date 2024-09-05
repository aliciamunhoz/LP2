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
    public partial class frm_1 : Form
    {
        public frm_1()
        {
            InitializeComponent();
        }

        private void Exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_ex3>().Count() > 0)
            {

                Application.OpenForms["frmExercicio3"].BringToFront();
            }
            else
            {
                frm_ex3 obj3 = new frm_ex3();
                obj3.MdiParent = this;
                obj3.WindowState = FormWindowState.Maximized;
                obj3.Show();

            }
        }
            private void Ex4ToolStripMenuItem_click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_ex4>().Count()>0)
            {

                Application.OpenForms["frmEx4"].BringToFront();
            }
            else
            {
                frm_ex4 obj4 = new frm_ex4();
                obj4.MdiParent = this;
                obj4.WindowState = FormWindowState.Maximized;
                obj4.Show();

            }
        }
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu copiar");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu colar");
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ex2 objfrm = new frm_ex2();
            objfrm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_ex5>().Count() > 0)
            {

                Application.OpenForms["frmEx5"].BringToFront();
            }
            else
            {
                frm_ex5 obj5 = new frm_ex5();
                obj5.MdiParent = this;
                obj5.WindowState = FormWindowState.Maximized;
                obj5.Show();

            }
        }
        private void exercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_ex6>().Count() > 0)
            {

                Application.OpenForms["frmE6"].BringToFront();
            }
            else
            {
                frm_ex6 obj6 = new frm_ex6();
                obj6.MdiParent = this;
                obj6.WindowState = FormWindowState.Maximized;
                obj6.Show();

            }
        }
    }
}
