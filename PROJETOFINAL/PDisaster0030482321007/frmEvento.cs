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
    public partial class frmEvento : Form
    {
        private BindingSource bnEvento = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsEvento = new DataSet();
        private DataSet dsCidade = new DataSet();
        private DataSet dsTipo = new DataSet();

        public frmEvento()
        {
            InitializeComponent();
        }

        private void frmEvento_Load(object sender, EventArgs e)
        {
            try
            {
                Evento Eve = new Evento();
                dsEvento.Tables.Add(Eve.Listar());
                bnEvento.DataSource = dsEvento.Tables["Evento"];
                dgvEvento.DataSource = bnEvento;
                bnvEvento.BindingSource = bnEvento;

                txtIDEvento.DataBindings.Add("TEXT", bnEvento, "IDEvento");
                cbxSeveridade.DataBindings.Add("SelectedItem", bnEvento, "nivelseveridade");
                mskbxAreaAfetada.DataBindings.Add("TEXT", bnEvento, "areaafetada");
                mskbxPopulacaoAfetada.DataBindings.Add("TEXT", bnEvento, "pessoasafetadas");
                txtObservacao.DataBindings.Add("TEXT", bnEvento, "observacao");
                dtpDataOcorrencia.DataBindings.Add("TEXT", bnEvento, "dataocorrencia");

                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                cbxCidade.DataSource = dsCidade.Tables["Cidade"];
                cbxCidade.DisplayMember = "nome";
                cbxCidade.ValueMember = "idcidade";
                cbxCidade.DataBindings.Add("SelectedValue", bnEvento, "cidade_idcidade");

                Tipo Tip = new Tipo();
                dsTipo.Tables.Add(Tip.Listar());
                cbxTipo.DataSource = dsTipo.Tables["Tipo"];
                cbxTipo.DisplayMember = "descricao";
                cbxTipo.ValueMember = "idtipo";
                cbxTipo.DataBindings.Add("SelectedValue", bnEvento, "tipo_idtipo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (tbEvento.SelectedIndex == 0)
            {
                tbEvento.SelectTab(1);
            }
            bnEvento.AddNew();

            cbxCidade.Enabled = true;
            cbxTipo.Enabled = true;
            cbxCidade.SelectedIndex = 0;
            cbxTipo.SelectedIndex = 0;
            cbxSeveridade.Enabled = true;
            cbxSeveridade.SelectedIndex = 0;
            mskbxPopulacaoAfetada.Enabled = true;
            mskbxAreaAfetada.Enabled = true;
            txtObservacao.Enabled = true;
            dtpDataOcorrencia.Enabled = true;

            cbxTipo.Focus();

            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;

            bInclusao = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbEvento.SelectedIndex == 0)
            {
                tbEvento.SelectTab(1);
            }

            cbxCidade.Enabled = true;
            cbxTipo.Enabled = true;
            cbxSeveridade.Enabled = true;
            mskbxPopulacaoAfetada.Enabled = true;
            mskbxAreaAfetada.Enabled = true;
            txtObservacao.Enabled = true;
            dtpDataOcorrencia.Enabled = true;

            cbxTipo.Focus();

            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;

            bInclusao = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int area = 0;
            int pessoas = 0;
            DateTime data = DateTime.Today;

            if (txtObservacao.Text == "")
            {
                MessageBox.Show("Observação inválida!");
            }
            else if (!int.TryParse(mskbxAreaAfetada.Text, out area))
            {
                MessageBox.Show("Área afetada inválida!");
            }
            else if (!int.TryParse(mskbxPopulacaoAfetada.Text, out pessoas))
            {
                MessageBox.Show("Número de pessoas afetadas inválidas!");
            }
            else if (!DateTime.TryParse(dtpDataOcorrencia.Text, out data) || data > DateTime.Today)
            {
                MessageBox.Show("Data evento inválida!");
            }
            else
            {
                Evento RegEv = new Evento();

                RegEv.Tipo_IDTipo = Convert.ToInt32(cbxTipo.SelectedValue.ToString());
                RegEv.Cidade_IDCidade = Convert.ToInt32(cbxCidade.SelectedValue.ToString());
                RegEv.NivelSeveridade = Convert.ToChar(cbxSeveridade.SelectedItem.ToString());
                RegEv.AreaAfetada = Convert.ToInt32(mskbxAreaAfetada.Text);
                RegEv.PessoasAfetadas = Convert.ToInt32(mskbxPopulacaoAfetada.Text);
                RegEv.Observacao = txtObservacao.Text;
                RegEv.DataOcorrencia = Convert.ToDateTime(dtpDataOcorrencia.Value);

                if (bInclusao)
                {
                    if (RegEv.Incluir() > 0)
                    {
                        MessageBox.Show("Evento adicionada com sucesso!");

                        cbxCidade.Enabled = false;
                        cbxTipo.Enabled = false;
                        cbxSeveridade.Enabled = false;
                        mskbxPopulacaoAfetada.Enabled = false;
                        mskbxAreaAfetada.Enabled = false;
                        txtObservacao.Enabled = false;
                        dtpDataOcorrencia.Enabled = false;

                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        Evento R = new Evento();
                        dsEvento.Tables.Clear();
                        dsEvento.Tables.Add(R.Listar());
                        bnEvento.DataSource = dsEvento.Tables["Evento"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Evento!");
                    }
                }
                else
                {
                    RegEv.IDEvento = Convert.ToInt32(txtIDEvento.Text);

                    if (RegEv.Alterar() > 0)
                    {
                        MessageBox.Show("Evento alterado com sucesso!");


                        cbxCidade.Enabled = false;
                        cbxTipo.Enabled = false;
                        cbxSeveridade.Enabled = false;
                        mskbxPopulacaoAfetada.Enabled = false;
                        mskbxAreaAfetada.Enabled = false;
                        txtObservacao.Enabled = false;
                        dtpDataOcorrencia.Enabled = false;

                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        Evento R = new Evento();
                        dsEvento.Tables.Clear();
                        dsEvento.Tables.Add(R.Listar());
                        bnEvento.DataSource = dsEvento.Tables["Evento"];


                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar Evento!");
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbEvento.SelectedIndex == 0)
            {
                tbEvento.SelectTab(1);
            }

            if (MessageBox.Show("Confirma exclusão?", "Sim ou Não", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Evento RegEv = new Evento();
                RegEv.IDEvento = Convert.ToInt16(txtIDEvento.Text);

                if (RegEv.Excluir() > 0)
                {
                    MessageBox.Show("Evento excluído com sucesso!");

                    Evento R = new Evento();
                    dsEvento.Tables.Clear();
                    dsEvento.Tables.Add(R.Listar());
                    bnEvento.DataSource = dsEvento.Tables["Evento"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir Evento!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnEvento.CancelEdit();

            cbxCidade.Enabled = false;
            cbxTipo.Enabled = false;
            cbxSeveridade.Enabled = false;
            mskbxPopulacaoAfetada.Enabled = false;
            mskbxAreaAfetada.Enabled = false;
            txtObservacao.Enabled = false;
            dtpDataOcorrencia.Enabled = false;

            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;

            bInclusao = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

