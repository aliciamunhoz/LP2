using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using PDisaster0030482321007;

namespace PDisaster0030482321007
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroTipoDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmTipo>().Count()>0) 
            {
                Application.OpenForms["frmTipo"].BringToFront();
            }
            else
            {
                frmTipo objFrm2 = new frmTipo();
                objFrm2.MdiParent = this;
                objFrm2.WindowState = FormWindowState.Maximized;
                objFrm2.Show();
            }
        }

        private void cadastroCidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCidade>().Count() > 0)
            {
                Application.OpenForms["frmCidade"].BringToFront();
            }
            else
            {
                frmCidade objFrm2 = new frmCidade();
                objFrm2.MdiParent = this;
                objFrm2.WindowState = FormWindowState.Maximized;
                objFrm2.Show();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSobre>().Count() > 0)
            {
                Application.OpenForms["frmSobre"].BringToFront();
            }
            else
            {
                frmSobre objFrm2 = new frmSobre();
                objFrm2.MdiParent = this;
                objFrm2.WindowState = FormWindowState.Maximized;
                objFrm2.Show();
            }
        }

        private void cadastroEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmEvento>().Count() > 0)
            {
                Application.OpenForms["frmEvento"].BringToFront();
            }
            else
            {
                frmEvento objFrm2 = new frmEvento();
                objFrm2.MdiParent = this;
                objFrm2.WindowState = FormWindowState.Maximized;
                objFrm2.Show();
            }
        }

        private void frmPrincipal_Load_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=apolo;Initial Catalog=LP2;User ID=BD2321007;PASSWORD=Aliciafatec007;Encrypt=False");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros erros =/" + ex.Message);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
