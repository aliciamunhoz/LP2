namespace PSalario
{
    partial class frm_salario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_bruto = new System.Windows.Forms.Label();
            this.lbl_filhos = new System.Windows.Forms.Label();
            this.lbl_aliqINSS = new System.Windows.Forms.Label();
            this.lbl_aliqIRPF = new System.Windows.Forms.Label();
            this.lbl_familia = new System.Windows.Forms.Label();
            this.lbl_liquido = new System.Windows.Forms.Label();
            this.nud_filhos = new System.Windows.Forms.NumericUpDown();
            this.lbl_descINSS = new System.Windows.Forms.Label();
            this.lbl_descIRPF = new System.Windows.Forms.Label();
            this.tbx_aliqIRPF = new System.Windows.Forms.TextBox();
            this.tbx_familia = new System.Windows.Forms.TextBox();
            this.tbx_liquido = new System.Windows.Forms.TextBox();
            this.tbx_descINSS = new System.Windows.Forms.TextBox();
            this.tbx_descIRPF = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.tbx_aliqINSS = new System.Windows.Forms.TextBox();
            this.msktbx_bruto = new System.Windows.Forms.MaskedTextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tbx_descFinal = new System.Windows.Forms.TextBox();
            this.lbl_descFinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_filhos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(251, 50);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(389, 22);
            this.tbx_nome.TabIndex = 0;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(101, 50);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(136, 16);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome do Funcionário";
            // 
            // lbl_bruto
            // 
            this.lbl_bruto.AutoSize = true;
            this.lbl_bruto.Location = new System.Drawing.Point(100, 100);
            this.lbl_bruto.Name = "lbl_bruto";
            this.lbl_bruto.Size = new System.Drawing.Size(84, 16);
            this.lbl_bruto.TabIndex = 2;
            this.lbl_bruto.Text = "Salário Bruto";
            // 
            // lbl_filhos
            // 
            this.lbl_filhos.AutoSize = true;
            this.lbl_filhos.Location = new System.Drawing.Point(400, 100);
            this.lbl_filhos.Name = "lbl_filhos";
            this.lbl_filhos.Size = new System.Drawing.Size(113, 16);
            this.lbl_filhos.TabIndex = 3;
            this.lbl_filhos.Text = "Número de Filhos";
            // 
            // lbl_aliqINSS
            // 
            this.lbl_aliqINSS.AutoSize = true;
            this.lbl_aliqINSS.Enabled = false;
            this.lbl_aliqINSS.Location = new System.Drawing.Point(100, 200);
            this.lbl_aliqINSS.Name = "lbl_aliqINSS";
            this.lbl_aliqINSS.Size = new System.Drawing.Size(90, 16);
            this.lbl_aliqINSS.TabIndex = 4;
            this.lbl_aliqINSS.Text = "Alíquota INSS";
            // 
            // lbl_aliqIRPF
            // 
            this.lbl_aliqIRPF.AutoSize = true;
            this.lbl_aliqIRPF.Enabled = false;
            this.lbl_aliqIRPF.Location = new System.Drawing.Point(100, 250);
            this.lbl_aliqIRPF.Name = "lbl_aliqIRPF";
            this.lbl_aliqIRPF.Size = new System.Drawing.Size(89, 16);
            this.lbl_aliqIRPF.TabIndex = 5;
            this.lbl_aliqIRPF.Text = "Alíquota IRPF";
            // 
            // lbl_familia
            // 
            this.lbl_familia.AutoSize = true;
            this.lbl_familia.Enabled = false;
            this.lbl_familia.Location = new System.Drawing.Point(100, 300);
            this.lbl_familia.Name = "lbl_familia";
            this.lbl_familia.Size = new System.Drawing.Size(97, 16);
            this.lbl_familia.TabIndex = 6;
            this.lbl_familia.Text = "Salário Família";
            // 
            // lbl_liquido
            // 
            this.lbl_liquido.AutoSize = true;
            this.lbl_liquido.Enabled = false;
            this.lbl_liquido.Location = new System.Drawing.Point(270, 350);
            this.lbl_liquido.Name = "lbl_liquido";
            this.lbl_liquido.Size = new System.Drawing.Size(97, 16);
            this.lbl_liquido.TabIndex = 7;
            this.lbl_liquido.Text = "Salário Líquido";
            // 
            // nud_filhos
            // 
            this.nud_filhos.Location = new System.Drawing.Point(520, 100);
            this.nud_filhos.Name = "nud_filhos";
            this.nud_filhos.Size = new System.Drawing.Size(120, 22);
            this.nud_filhos.TabIndex = 8;
            // 
            // lbl_descINSS
            // 
            this.lbl_descINSS.AutoSize = true;
            this.lbl_descINSS.Enabled = false;
            this.lbl_descINSS.Location = new System.Drawing.Point(400, 200);
            this.lbl_descINSS.Name = "lbl_descINSS";
            this.lbl_descINSS.Size = new System.Drawing.Size(99, 16);
            this.lbl_descINSS.TabIndex = 9;
            this.lbl_descINSS.Text = "Desconto INSS";
            // 
            // lbl_descIRPF
            // 
            this.lbl_descIRPF.AutoSize = true;
            this.lbl_descIRPF.Enabled = false;
            this.lbl_descIRPF.Location = new System.Drawing.Point(400, 250);
            this.lbl_descIRPF.Name = "lbl_descIRPF";
            this.lbl_descIRPF.Size = new System.Drawing.Size(98, 16);
            this.lbl_descIRPF.TabIndex = 10;
            this.lbl_descIRPF.Text = "Desconto IRPF";
            // 
            // tbx_aliqIRPF
            // 
            this.tbx_aliqIRPF.Enabled = false;
            this.tbx_aliqIRPF.Location = new System.Drawing.Point(220, 250);
            this.tbx_aliqIRPF.Name = "tbx_aliqIRPF";
            this.tbx_aliqIRPF.Size = new System.Drawing.Size(100, 22);
            this.tbx_aliqIRPF.TabIndex = 13;
            // 
            // tbx_familia
            // 
            this.tbx_familia.Enabled = false;
            this.tbx_familia.Location = new System.Drawing.Point(220, 300);
            this.tbx_familia.Name = "tbx_familia";
            this.tbx_familia.Size = new System.Drawing.Size(100, 22);
            this.tbx_familia.TabIndex = 14;
            // 
            // tbx_liquido
            // 
            this.tbx_liquido.Enabled = false;
            this.tbx_liquido.Location = new System.Drawing.Point(380, 350);
            this.tbx_liquido.Name = "tbx_liquido";
            this.tbx_liquido.Size = new System.Drawing.Size(100, 22);
            this.tbx_liquido.TabIndex = 15;
            // 
            // tbx_descINSS
            // 
            this.tbx_descINSS.Enabled = false;
            this.tbx_descINSS.Location = new System.Drawing.Point(540, 200);
            this.tbx_descINSS.Name = "tbx_descINSS";
            this.tbx_descINSS.Size = new System.Drawing.Size(100, 22);
            this.tbx_descINSS.TabIndex = 16;
            // 
            // tbx_descIRPF
            // 
            this.tbx_descIRPF.Enabled = false;
            this.tbx_descIRPF.Location = new System.Drawing.Point(540, 250);
            this.tbx_descIRPF.Name = "tbx_descIRPF";
            this.tbx_descIRPF.Size = new System.Drawing.Size(100, 22);
            this.tbx_descIRPF.TabIndex = 17;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(200, 150);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(176, 23);
            this.btn_check.TabIndex = 18;
            this.btn_check.Text = "Verificar Desconto";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // tbx_aliqINSS
            // 
            this.tbx_aliqINSS.Enabled = false;
            this.tbx_aliqINSS.Location = new System.Drawing.Point(220, 200);
            this.tbx_aliqINSS.Name = "tbx_aliqINSS";
            this.tbx_aliqINSS.Size = new System.Drawing.Size(100, 22);
            this.tbx_aliqINSS.TabIndex = 12;
            // 
            // msktbx_bruto
            // 
            this.msktbx_bruto.Location = new System.Drawing.Point(200, 100);
            this.msktbx_bruto.Mask = "99000.00";
            this.msktbx_bruto.Name = "msktbx_bruto";
            this.msktbx_bruto.Size = new System.Drawing.Size(120, 22);
            this.msktbx_bruto.TabIndex = 19;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(450, 150);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 20;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tbx_descFinal
            // 
            this.tbx_descFinal.Enabled = false;
            this.tbx_descFinal.Location = new System.Drawing.Point(540, 300);
            this.tbx_descFinal.Name = "tbx_descFinal";
            this.tbx_descFinal.Size = new System.Drawing.Size(100, 22);
            this.tbx_descFinal.TabIndex = 21;
            // 
            // lbl_descFinal
            // 
            this.lbl_descFinal.AutoSize = true;
            this.lbl_descFinal.Location = new System.Drawing.Point(400, 300);
            this.lbl_descFinal.Name = "lbl_descFinal";
            this.lbl_descFinal.Size = new System.Drawing.Size(130, 16);
            this.lbl_descFinal.TabIndex = 22;
            this.lbl_descFinal.Text = "Desconto IRPF Final";
            // 
            // frm_salario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.lbl_descFinal);
            this.Controls.Add(this.tbx_descFinal);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.msktbx_bruto);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.tbx_descIRPF);
            this.Controls.Add(this.tbx_descINSS);
            this.Controls.Add(this.tbx_liquido);
            this.Controls.Add(this.tbx_familia);
            this.Controls.Add(this.tbx_aliqIRPF);
            this.Controls.Add(this.tbx_aliqINSS);
            this.Controls.Add(this.lbl_descIRPF);
            this.Controls.Add(this.lbl_descINSS);
            this.Controls.Add(this.nud_filhos);
            this.Controls.Add(this.lbl_liquido);
            this.Controls.Add(this.lbl_familia);
            this.Controls.Add(this.lbl_aliqIRPF);
            this.Controls.Add(this.lbl_aliqINSS);
            this.Controls.Add(this.lbl_filhos);
            this.Controls.Add(this.lbl_bruto);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.tbx_nome);
            this.Name = "frm_salario";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_filhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_bruto;
        private System.Windows.Forms.Label lbl_filhos;
        private System.Windows.Forms.Label lbl_aliqINSS;
        private System.Windows.Forms.Label lbl_aliqIRPF;
        private System.Windows.Forms.Label lbl_familia;
        private System.Windows.Forms.Label lbl_liquido;
        private System.Windows.Forms.NumericUpDown nud_filhos;
        private System.Windows.Forms.Label lbl_descINSS;
        private System.Windows.Forms.Label lbl_descIRPF;
        private System.Windows.Forms.TextBox tbx_aliqIRPF;
        private System.Windows.Forms.TextBox tbx_familia;
        private System.Windows.Forms.TextBox tbx_liquido;
        private System.Windows.Forms.TextBox tbx_descINSS;
        private System.Windows.Forms.TextBox tbx_descIRPF;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox tbx_aliqINSS;
        private System.Windows.Forms.MaskedTextBox msktbx_bruto;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox tbx_descFinal;
        private System.Windows.Forms.Label lbl_descFinal;
    }
}

