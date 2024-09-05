namespace PClasses
{
    partial class frm_mensalista
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
            this.lbl_salarioMensal = new System.Windows.Forms.Label();
            this.lbl_dataEntrada = new System.Windows.Forms.Label();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_salarioMensal = new System.Windows.Forms.TextBox();
            this.txt_dataEntrada = new System.Windows.Forms.TextBox();
            this.btn_mensalistaDireto = new System.Windows.Forms.Button();
            this.btn_mensalistaParametros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Location = new System.Drawing.Point(116, 88);
            this.lbl_matricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(100, 25);
            this.lbl_matricula.TabIndex = 0;
            this.lbl_matricula.Text = "Matrícula";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(116, 181);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(68, 25);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_salarioMensal
            // 
            this.lbl_salarioMensal.AutoSize = true;
            this.lbl_salarioMensal.Location = new System.Drawing.Point(116, 275);
            this.lbl_salarioMensal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_salarioMensal.Name = "lbl_salarioMensal";
            this.lbl_salarioMensal.Size = new System.Drawing.Size(155, 25);
            this.lbl_salarioMensal.TabIndex = 2;
            this.lbl_salarioMensal.Text = "Salário Mensal";
            // 
            // lbl_dataEntrada
            // 
            this.lbl_dataEntrada.AutoSize = true;
            this.lbl_dataEntrada.Location = new System.Drawing.Point(116, 364);
            this.lbl_dataEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dataEntrada.Name = "lbl_dataEntrada";
            this.lbl_dataEntrada.Size = new System.Drawing.Size(289, 25);
            this.lbl_dataEntrada.TabIndex = 3;
            this.lbl_dataEntrada.Text = "Data da Entrada na Empresa";
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(470, 83);
            this.txt_matricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(148, 31);
            this.txt_matricula.TabIndex = 4;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(470, 172);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(148, 31);
            this.txt_nome.TabIndex = 5;
            // 
            // txt_salarioMensal
            // 
            this.txt_salarioMensal.Location = new System.Drawing.Point(470, 266);
            this.txt_salarioMensal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_salarioMensal.Name = "txt_salarioMensal";
            this.txt_salarioMensal.Size = new System.Drawing.Size(148, 31);
            this.txt_salarioMensal.TabIndex = 6;
            // 
            // txt_dataEntrada
            // 
            this.txt_dataEntrada.Location = new System.Drawing.Point(470, 355);
            this.txt_dataEntrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_dataEntrada.Name = "txt_dataEntrada";
            this.txt_dataEntrada.Size = new System.Drawing.Size(204, 31);
            this.txt_dataEntrada.TabIndex = 7;
            // 
            // btn_mensalistaDireto
            // 
            this.btn_mensalistaDireto.Location = new System.Drawing.Point(303, 517);
            this.btn_mensalistaDireto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_mensalistaDireto.Name = "btn_mensalistaDireto";
            this.btn_mensalistaDireto.Size = new System.Drawing.Size(273, 36);
            this.btn_mensalistaDireto.TabIndex = 8;
            this.btn_mensalistaDireto.Text = "Sem parametros";
            this.btn_mensalistaDireto.UseVisualStyleBackColor = true;
            this.btn_mensalistaDireto.Click += new System.EventHandler(this.btn_mensalistaDireto_Click);
            // 
            // btn_mensalistaParametros
            // 
            this.btn_mensalistaParametros.Location = new System.Drawing.Point(702, 517);
            this.btn_mensalistaParametros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_mensalistaParametros.Name = "btn_mensalistaParametros";
            this.btn_mensalistaParametros.Size = new System.Drawing.Size(244, 36);
            this.btn_mensalistaParametros.TabIndex = 9;
            this.btn_mensalistaParametros.Text = "Com parametros";
            this.btn_mensalistaParametros.UseVisualStyleBackColor = true;
            // 
            // frm_mensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btn_mensalistaParametros);
            this.Controls.Add(this.btn_mensalistaDireto);
            this.Controls.Add(this.txt_dataEntrada);
            this.Controls.Add(this.txt_salarioMensal);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.lbl_dataEntrada);
            this.Controls.Add(this.lbl_salarioMensal);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_matricula);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_mensalista";
            this.Text = "frm_mensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_salarioMensal;
        private System.Windows.Forms.Label lbl_dataEntrada;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_salarioMensal;
        private System.Windows.Forms.TextBox txt_dataEntrada;
        private System.Windows.Forms.Button btn_mensalistaDireto;
        private System.Windows.Forms.Button btn_mensalistaParametros;
    }
}