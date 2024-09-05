namespace PDisaster0030482321007
{
    partial class frmEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvento));
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.lblPopulacao = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnFechar = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbDados = new System.Windows.Forms.TabPage();
            this.dgvEvento = new System.Windows.Forms.DataGridView();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tbDetalhes = new System.Windows.Forms.TabPage();
            this.dtpDataOcorrencia = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.mskbxAreaAfetada = new System.Windows.Forms.MaskedTextBox();
            this.lblAreaAfetada = new System.Windows.Forms.Label();
            this.cbxSeveridade = new System.Windows.Forms.ComboBox();
            this.lblSeveridade = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.mskbxPopulacaoAfetada = new System.Windows.Forms.MaskedTextBox();
            this.txtIDEvento = new System.Windows.Forms.TextBox();
            this.lblIDTipo = new System.Windows.Forms.Label();
            this.tbEvento = new System.Windows.Forms.TabControl();
            this.bnvEvento = new System.Windows.Forms.BindingNavigator(this.components);
            this.tbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).BeginInit();
            this.tbDetalhes.SuspendLayout();
            this.tbEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnvEvento)).BeginInit();
            this.bnvEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCidade
            // 
            this.cbxCidade.Enabled = false;
            this.cbxCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Items.AddRange(new object[] {
            "AC",
            "BA",
            "CE",
            "DF",
            "SP",
            "SC",
            "PR",
            "RS",
            "TO",
            "PI",
            "MA",
            "GO",
            "MG",
            "MS",
            "MT",
            "ES",
            "RJ",
            "PB",
            "AM",
            "PA",
            "AP",
            "RR",
            "RP",
            "RN",
            "AL",
            "SE"});
            this.cbxCidade.Location = new System.Drawing.Point(84, 116);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(165, 28);
            this.cbxCidade.TabIndex = 8;
            // 
            // lblPopulacao
            // 
            this.lblPopulacao.AutoSize = true;
            this.lblPopulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopulacao.Location = new System.Drawing.Point(26, 240);
            this.lblPopulacao.Name = "lblPopulacao";
            this.lblPopulacao.Size = new System.Drawing.Size(145, 20);
            this.lblPopulacao.TabIndex = 6;
            this.lblPopulacao.Text = "População Afetada";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(27, 124);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(59, 20);
            this.lblCidade.TabIndex = 4;
            this.lblCidade.Text = "Cidade";
            // 
            // btnAlterar
            // 
            this.btnAlterar.AccessibleDescription = "\'";
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(23, 22);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.AccessibleDescription = "\'";
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.AccessibleDescription = "\'";
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.AccessibleDescription = "\'";
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.AccessibleDescription = "\'";
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleDescription = "\'";
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.AccessibleDescription = "\'";
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.AccessibleDescription = "\'";
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.AccessibleDescription = "\'";
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.AccessibleDescription = "\'";
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNovo
            // 
            this.btnNovo.AccessibleDescription = "\'";
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(23, 22);
            this.btnNovo.Text = "Novo Registro";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AccessibleDescription = "\'";
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AccessibleDescription = "\'";
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleDescription = "\'";
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.AccessibleDescription = "\'";
            this.btnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(23, 22);
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // tbDados
            // 
            this.tbDados.Controls.Add(this.dgvEvento);
            this.tbDados.Location = new System.Drawing.Point(4, 22);
            this.tbDados.Name = "tbDados";
            this.tbDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbDados.Size = new System.Drawing.Size(483, 494);
            this.tbDados.TabIndex = 0;
            this.tbDados.Text = "Dados";
            this.tbDados.UseVisualStyleBackColor = true;
            // 
            // dgvEvento
            // 
            this.dgvEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvento.Location = new System.Drawing.Point(6, 9);
            this.dgvEvento.Name = "dgvEvento";
            this.dgvEvento.Size = new System.Drawing.Size(471, 479);
            this.dgvEvento.TabIndex = 0;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(27, 80);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 20);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo";
            // 
            // tbDetalhes
            // 
            this.tbDetalhes.Controls.Add(this.dtpDataOcorrencia);
            this.tbDetalhes.Controls.Add(this.lblData);
            this.tbDetalhes.Controls.Add(this.txtObservacao);
            this.tbDetalhes.Controls.Add(this.lblObservacao);
            this.tbDetalhes.Controls.Add(this.mskbxAreaAfetada);
            this.tbDetalhes.Controls.Add(this.lblAreaAfetada);
            this.tbDetalhes.Controls.Add(this.cbxSeveridade);
            this.tbDetalhes.Controls.Add(this.lblSeveridade);
            this.tbDetalhes.Controls.Add(this.cbxTipo);
            this.tbDetalhes.Controls.Add(this.cbxCidade);
            this.tbDetalhes.Controls.Add(this.mskbxPopulacaoAfetada);
            this.tbDetalhes.Controls.Add(this.lblPopulacao);
            this.tbDetalhes.Controls.Add(this.lblCidade);
            this.tbDetalhes.Controls.Add(this.txtIDEvento);
            this.tbDetalhes.Controls.Add(this.lblTipo);
            this.tbDetalhes.Controls.Add(this.lblIDTipo);
            this.tbDetalhes.Location = new System.Drawing.Point(4, 22);
            this.tbDetalhes.Name = "tbDetalhes";
            this.tbDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this.tbDetalhes.Size = new System.Drawing.Size(483, 494);
            this.tbDetalhes.TabIndex = 1;
            this.tbDetalhes.Text = "Detalhes ";
            this.tbDetalhes.UseVisualStyleBackColor = true;
            // 
            // dtpDataOcorrencia
            // 
            this.dtpDataOcorrencia.CustomFormat = "dd/MM/yyyy";
            this.dtpDataOcorrencia.Enabled = false;
            this.dtpDataOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDataOcorrencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataOcorrencia.Location = new System.Drawing.Point(196, 314);
            this.dtpDataOcorrencia.Name = "dtpDataOcorrencia";
            this.dtpDataOcorrencia.Size = new System.Drawing.Size(200, 26);
            this.dtpDataOcorrencia.TabIndex = 15;
            this.dtpDataOcorrencia.Value = new System.DateTime(2024, 6, 4, 0, 0, 0, 0);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(27, 314);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(147, 20);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "Data da Ocorrência";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Enabled = false;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtObservacao.Location = new System.Drawing.Point(149, 276);
            this.txtObservacao.MaxLength = 50;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(100, 26);
            this.txtObservacao.TabIndex = 13;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(27, 274);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(94, 20);
            this.lblObservacao.TabIndex = 12;
            this.lblObservacao.Text = "Observação";
            // 
            // mskbxAreaAfetada
            // 
            this.mskbxAreaAfetada.Enabled = false;
            this.mskbxAreaAfetada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskbxAreaAfetada.Location = new System.Drawing.Point(177, 192);
            this.mskbxAreaAfetada.Mask = "999999999";
            this.mskbxAreaAfetada.Name = "mskbxAreaAfetada";
            this.mskbxAreaAfetada.Size = new System.Drawing.Size(100, 26);
            this.mskbxAreaAfetada.TabIndex = 7;
            // 
            // lblAreaAfetada
            // 
            this.lblAreaAfetada.AutoSize = true;
            this.lblAreaAfetada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaAfetada.Location = new System.Drawing.Point(27, 195);
            this.lblAreaAfetada.Name = "lblAreaAfetada";
            this.lblAreaAfetada.Size = new System.Drawing.Size(144, 20);
            this.lblAreaAfetada.TabIndex = 11;
            this.lblAreaAfetada.Text = "Área Afetada (km²)";
            // 
            // cbxSeveridade
            // 
            this.cbxSeveridade.Enabled = false;
            this.cbxSeveridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxSeveridade.FormattingEnabled = true;
            this.cbxSeveridade.Items.AddRange(new object[] {
            "L",
            "M",
            "G"});
            this.cbxSeveridade.Location = new System.Drawing.Point(159, 153);
            this.cbxSeveridade.Name = "cbxSeveridade";
            this.cbxSeveridade.Size = new System.Drawing.Size(90, 28);
            this.cbxSeveridade.TabIndex = 7;
            // 
            // lblSeveridade
            // 
            this.lblSeveridade.AutoSize = true;
            this.lblSeveridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeveridade.Location = new System.Drawing.Point(27, 161);
            this.lblSeveridade.Name = "lblSeveridade";
            this.lblSeveridade.Size = new System.Drawing.Size(126, 20);
            this.lblSeveridade.TabIndex = 10;
            this.lblSeveridade.Text = "Nível Severidade";
            // 
            // cbxTipo
            // 
            this.cbxTipo.Enabled = false;
            this.cbxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(111, 72);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(138, 28);
            this.cbxTipo.TabIndex = 9;
            // 
            // mskbxPopulacaoAfetada
            // 
            this.mskbxPopulacaoAfetada.Enabled = false;
            this.mskbxPopulacaoAfetada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskbxPopulacaoAfetada.Location = new System.Drawing.Point(177, 234);
            this.mskbxPopulacaoAfetada.Mask = "999999999";
            this.mskbxPopulacaoAfetada.Name = "mskbxPopulacaoAfetada";
            this.mskbxPopulacaoAfetada.Size = new System.Drawing.Size(132, 26);
            this.mskbxPopulacaoAfetada.TabIndex = 7;
            // 
            // txtIDEvento
            // 
            this.txtIDEvento.Enabled = false;
            this.txtIDEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEvento.Location = new System.Drawing.Point(63, 26);
            this.txtIDEvento.MaxLength = 50;
            this.txtIDEvento.Name = "txtIDEvento";
            this.txtIDEvento.Size = new System.Drawing.Size(186, 26);
            this.txtIDEvento.TabIndex = 2;
            // 
            // lblIDTipo
            // 
            this.lblIDTipo.AutoSize = true;
            this.lblIDTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTipo.Location = new System.Drawing.Point(27, 32);
            this.lblIDTipo.Name = "lblIDTipo";
            this.lblIDTipo.Size = new System.Drawing.Size(30, 20);
            this.lblIDTipo.TabIndex = 0;
            this.lblIDTipo.Text = "ID ";
            // 
            // tbEvento
            // 
            this.tbEvento.Controls.Add(this.tbDados);
            this.tbEvento.Controls.Add(this.tbDetalhes);
            this.tbEvento.Location = new System.Drawing.Point(12, 28);
            this.tbEvento.Name = "tbEvento";
            this.tbEvento.SelectedIndex = 0;
            this.tbEvento.Size = new System.Drawing.Size(491, 520);
            this.tbEvento.TabIndex = 6;
            // 
            // bnvEvento
            // 
            this.bnvEvento.AddNewItem = null;
            this.bnvEvento.CountItem = this.bindingNavigatorCountItem;
            this.bnvEvento.DeleteItem = null;
            this.bnvEvento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNovo,
            this.btnAlterar,
            this.btnSalvar,
            this.btnExcluir,
            this.btnCancelar,
            this.btnFechar});
            this.bnvEvento.Location = new System.Drawing.Point(0, 0);
            this.bnvEvento.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnvEvento.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnvEvento.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnvEvento.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnvEvento.Name = "bnvEvento";
            this.bnvEvento.PositionItem = this.bindingNavigatorPositionItem;
            this.bnvEvento.Size = new System.Drawing.Size(514, 25);
            this.bnvEvento.TabIndex = 5;
            this.bnvEvento.Text = "bnvTipo";
            // 
            // frmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 561);
            this.Controls.Add(this.tbEvento);
            this.Controls.Add(this.bnvEvento);
            this.Name = "frmEvento";
            this.Text = "frmEvento";
            this.Load += new System.EventHandler(this.frmEvento_Load);
            this.tbDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).EndInit();
            this.tbDetalhes.ResumeLayout(false);
            this.tbDetalhes.PerformLayout();
            this.tbEvento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnvEvento)).EndInit();
            this.bnvEvento.ResumeLayout(false);
            this.bnvEvento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.Label lblPopulacao;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnFechar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tbDados;
        private System.Windows.Forms.DataGridView dgvEvento;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TabPage tbDetalhes;
        private System.Windows.Forms.MaskedTextBox mskbxPopulacaoAfetada;
        private System.Windows.Forms.TextBox txtIDEvento;
        private System.Windows.Forms.Label lblIDTipo;
        private System.Windows.Forms.TabControl tbEvento;
        private System.Windows.Forms.BindingNavigator bnvEvento;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.MaskedTextBox mskbxAreaAfetada;
        private System.Windows.Forms.Label lblAreaAfetada;
        private System.Windows.Forms.ComboBox cbxSeveridade;
        private System.Windows.Forms.Label lblSeveridade;
        private System.Windows.Forms.DateTimePicker dtpDataOcorrencia;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
    }
}