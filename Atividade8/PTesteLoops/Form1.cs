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
    public partial class frm_inicial : Form
    {
        public frm_inicial()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_ex1>().Count() > 0)
            {
                Application.OpenForms["frmExercicio1"].BringToFront();
            }
            else
            {
                frm_ex1 objFrm1 = new frm_ex1();
                objFrm1.MdiParent = this;
                objFrm1.WindowState = FormWindowState.Maximized;
                objFrm1.Show();
            }
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_ex2>().Count() > 0)
            {
                Application.OpenForms["frmExercicio2"].BringToFront();
            }
            else
            {
                frm_ex2 objFrm2 = new frm_ex2();
                objFrm2.MdiParent = this;
                objFrm2.WindowState = FormWindowState.Maximized;
                objFrm2.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_ex3>().Count() > 0)
            {
                Application.OpenForms["frmExercicio3"].BringToFront();
            }
            else
            {
                frm_ex3 objFrm3 = new frm_ex3();
                objFrm3.MdiParent = this;
                objFrm3.WindowState = FormWindowState.Maximized;
                objFrm3.Show();
            }
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_ex4>().Count() > 0)
            {
                Application.OpenForms["frmExercicio4"].BringToFront();
            }
            else
            {
                frm_ex4 objFrm4 = new frm_ex4();
                objFrm4.MdiParent = this;
                objFrm4.WindowState = FormWindowState.Maximized;
                objFrm4.Show();
            }
        }
    }
}
