using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDisaster0030482321007
{
    public partial class frmCidade : Form
    {

        private BindingSource bnCidade = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsCidade = new DataSet();

        public frmCidade()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }
            bnCidade.AddNew();

            txtNome.Enabled = true;
            cbxUF.Enabled = true;
            cbxUF.SelectedIndex = 0;
            mskbxPopulacao.Enabled = true;
            txtNome.Focus();

            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = true;

            bInclusao = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }

            txtNome.Enabled = true;
            cbxUF.Enabled = true;
            mskbxPopulacao.Enabled = true;
            txtNome.Focus();

            btnSalvar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;

            bInclusao = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int auxiliar = 0;

            if (txtNome.Text == "")
            {
                MessageBox.Show("Cidade inválida!");
            }
            else if (!int.TryParse(mskbxPopulacao.Text, out auxiliar) || auxiliar <= 0)
            {
                MessageBox.Show("População inválida!");
            }
            else
            {               
                Cidade RegCid = new Cidade();

                RegCid.Nome = txtNome.Text;
                RegCid.UF = cbxUF.SelectedItem.ToString();
                RegCid.Populacao = Convert.ToInt32(mskbxPopulacao.Text);

                if (bInclusao)
                {
                    if (RegCid.Incluir() > 0)
                    {
                        MessageBox.Show("Cidade adicionada com sucesso!");

                        txtIDCidade.Enabled = false;
                        txtNome.Enabled = false;
                        cbxUF.Enabled = false;
                        mskbxPopulacao.Enabled = false;

                        btnSalvar.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        bnCidade.DataSource = dsCidade.Tables["Cidade"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Cidade!");
                    }
                }
                else
                {
                    RegCid.IDCidade = Convert.ToInt32(txtIDCidade.Text);

                    if (RegCid.Alterar() > 0)
                    {
                        MessageBox.Show("Cidade alterada com sucesso!");

                        txtNome.Enabled = false;
                        txtIDCidade.Enabled = false;
                        cbxUF.Enabled = false;
                        mskbxPopulacao.Enabled = false;

                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        bnCidade.DataSource = dsCidade.Tables["Cidade"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Cidade!");
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }

            if (MessageBox.Show("Confirma exclusão?", "Sim ou Não", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Cidade RegCid = new Cidade();
                RegCid.IDCidade = Convert.ToInt32(txtIDCidade.Text);

                if (RegCid.Excluir() > 0)
                {
                    MessageBox.Show("Cidade excluído com sucesso!");

                    Cidade R = new Cidade();
                    dsCidade.Tables.Clear();
                    dsCidade.Tables.Add(R.Listar());
                    bnCidade.DataSource = dsCidade.Tables["Cidade"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir Cidade!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnCidade.CancelEdit();

            txtNome.Enabled = false;
            txtIDCidade.Enabled = false;
            cbxUF.Enabled = false;
            mskbxPopulacao.Enabled = false;

            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;

            bInclusao = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCidade_Load(object sender, EventArgs e)
        {
            try
            {
                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                bnCidade.DataSource = dsCidade.Tables["Cidade"];
                dgvCidade.DataSource = bnCidade;
                bnvCidade.BindingSource = bnCidade;

                txtIDCidade.DataBindings.Add("TEXT", bnCidade, "IDCidade");
                txtNome.DataBindings.Add("TEXT", bnCidade, "Nome");
                cbxUF.DataBindings.Add("SelectedItem", bnCidade, "UF");
                mskbxPopulacao.DataBindings.Add("TEXT", bnCidade, "Populacao");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
