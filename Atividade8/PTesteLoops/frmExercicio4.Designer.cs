namespace PTesteLoops
{
    partial class frm_ex4
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
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.lbl_gratificacao = new System.Windows.Forms.Label();
            this.tbx_matricula = new System.Windows.Forms.TextBox();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.numUpDown_producao = new System.Windows.Forms.NumericUpDown();
            this.mskdbx_salario = new System.Windows.Forms.MaskedTextBox();
            this.mskdbx_grattificacao = new System.Windows.Forms.MaskedTextBox();
            this.tbx_bruto = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_bruto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_producao)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_matricula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_matricula.Location = new System.Drawing.Point(108, 122);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(69, 17);
            this.lbl_matricula.TabIndex = 2;
            this.lbl_matricula.Text = "Matricula:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_nome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nome.Location = new System.Drawing.Point(108, 176);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(49, 17);
            this.lbl_nome.TabIndex = 3;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_produto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_produto.Location = new System.Drawing.Point(108, 228);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(73, 17);
            this.lbl_produto.TabIndex = 4;
            this.lbl_produto.Text = "Produção:";
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_salario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_salario.Location = new System.Drawing.Point(386, 122);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(56, 17);
            this.lbl_salario.TabIndex = 5;
            this.lbl_salario.Text = "Salário:";
            // 
            // lbl_gratificacao
            // 
            this.lbl_gratificacao.AutoSize = true;
            this.lbl_gratificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_gratificacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_gratificacao.Location = new System.Drawing.Point(386, 173);
            this.lbl_gratificacao.Name = "lbl_gratificacao";
            this.lbl_gratificacao.Size = new System.Drawing.Size(88, 17);
            this.lbl_gratificacao.TabIndex = 6;
            this.lbl_gratificacao.Text = "Gratificação:";
            // 
            // tbx_matricula
            // 
            this.tbx_matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbx_matricula.Location = new System.Drawing.Point(179, 120);
            this.tbx_matricula.Name = "tbx_matricula";
            this.tbx_matricula.Size = new System.Drawing.Size(184, 23);
            this.tbx_matricula.TabIndex = 8;
            // 
            // tbx_nome
            // 
            this.tbx_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbx_nome.Location = new System.Drawing.Point(179, 176);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(184, 23);
            this.tbx_nome.TabIndex = 9;
            // 
            // numUpDown_producao
            // 
            this.numUpDown_producao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numUpDown_producao.Location = new System.Drawing.Point(179, 226);
            this.numUpDown_producao.Name = "numUpDown_producao";
            this.numUpDown_producao.Size = new System.Drawing.Size(184, 23);
            this.numUpDown_producao.TabIndex = 13;
            // 
            // mskdbx_salario
            // 
            this.mskdbx_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskdbx_salario.Location = new System.Drawing.Point(480, 121);
            this.mskdbx_salario.Mask = "0000.00";
            this.mskdbx_salario.Name = "mskdbx_salario";
            this.mskdbx_salario.Size = new System.Drawing.Size(184, 23);
            this.mskdbx_salario.TabIndex = 14;
            // 
            // mskdbx_grattificacao
            // 
            this.mskdbx_grattificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskdbx_grattificacao.Location = new System.Drawing.Point(480, 172);
            this.mskdbx_grattificacao.Mask = "0000.00";
            this.mskdbx_grattificacao.Name = "mskdbx_grattificacao";
            this.mskdbx_grattificacao.Size = new System.Drawing.Size(184, 23);
            this.mskdbx_grattificacao.TabIndex = 15;
            // 
            // tbx_bruto
            // 
            this.tbx_bruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbx_bruto.Location = new System.Drawing.Point(480, 226);
            this.tbx_bruto.Name = "tbx_bruto";
            this.tbx_bruto.Size = new System.Drawing.Size(184, 23);
            this.tbx_bruto.TabIndex = 16;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_calcular.Location = new System.Drawing.Point(345, 295);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(82, 32);
            this.btn_calcular.TabIndex = 17;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lbl_bruto
            // 
            this.lbl_bruto.AutoSize = true;
            this.lbl_bruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_bruto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_bruto.Location = new System.Drawing.Point(386, 234);
            this.lbl_bruto.Name = "lbl_bruto";
            this.lbl_bruto.Size = new System.Drawing.Size(94, 17);
            this.lbl_bruto.TabIndex = 18;
            this.lbl_bruto.Text = "Salário Bruto:";
            // 
            // frm_ex4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_bruto);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.tbx_bruto);
            this.Controls.Add(this.mskdbx_grattificacao);
            this.Controls.Add(this.mskdbx_salario);
            this.Controls.Add(this.numUpDown_producao);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.tbx_matricula);
            this.Controls.Add(this.lbl_gratificacao);
            this.Controls.Add(this.lbl_salario);
            this.Controls.Add(this.lbl_produto);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_matricula);
            this.Name = "frm_ex4";
            this.Text = "frmExercicio4";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_producao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.Label lbl_gratificacao;
        private System.Windows.Forms.TextBox tbx_matricula;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.NumericUpDown numUpDown_producao;
        private System.Windows.Forms.MaskedTextBox mskdbx_salario;
        private System.Windows.Forms.MaskedTextBox mskdbx_grattificacao;
        private System.Windows.Forms.TextBox tbx_bruto;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_bruto;
    }
}