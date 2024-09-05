namespace PClasses
{
    partial class frm_horista
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
            this.btn_horista = new System.Windows.Forms.Button();
            this.txt_dataEntrada = new System.Windows.Forms.TextBox();
            this.txt_salarioHora = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.lbl_dataEntrada = new System.Windows.Forms.Label();
            this.lbl_salarioHora = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.lbl_horas = new System.Windows.Forms.Label();
            this.lbl_faltas = new System.Windows.Forms.Label();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.txt_falta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_horista
            // 
            this.btn_horista.Location = new System.Drawing.Point(236, 395);
            this.btn_horista.Name = "btn_horista";
            this.btn_horista.Size = new System.Drawing.Size(182, 23);
            this.btn_horista.TabIndex = 18;
            this.btn_horista.Text = "Instanciar Horista";
            this.btn_horista.UseVisualStyleBackColor = true;
            this.btn_horista.Click += new System.EventHandler(this.btn_horista_Click);
            // 
            // txt_dataEntrada
            // 
            this.txt_dataEntrada.Location = new System.Drawing.Point(403, 249);
            this.txt_dataEntrada.Name = "txt_dataEntrada";
            this.txt_dataEntrada.Size = new System.Drawing.Size(137, 22);
            this.txt_dataEntrada.TabIndex = 17;
            // 
            // txt_salarioHora
            // 
            this.txt_salarioHora.Location = new System.Drawing.Point(403, 192);
            this.txt_salarioHora.Name = "txt_salarioHora";
            this.txt_salarioHora.Size = new System.Drawing.Size(100, 22);
            this.txt_salarioHora.TabIndex = 16;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(403, 132);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 22);
            this.txt_nome.TabIndex = 15;
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(403, 75);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(100, 22);
            this.txt_matricula.TabIndex = 14;
            // 
            // lbl_dataEntrada
            // 
            this.lbl_dataEntrada.AutoSize = true;
            this.lbl_dataEntrada.Location = new System.Drawing.Point(167, 255);
            this.lbl_dataEntrada.Name = "lbl_dataEntrada";
            this.lbl_dataEntrada.Size = new System.Drawing.Size(181, 16);
            this.lbl_dataEntrada.TabIndex = 13;
            this.lbl_dataEntrada.Text = "Data da Entrada na Empresa";
            // 
            // lbl_salarioHora
            // 
            this.lbl_salarioHora.AutoSize = true;
            this.lbl_salarioHora.Location = new System.Drawing.Point(167, 198);
            this.lbl_salarioHora.Name = "lbl_salarioHora";
            this.lbl_salarioHora.Size = new System.Drawing.Size(106, 16);
            this.lbl_salarioHora.TabIndex = 12;
            this.lbl_salarioHora.Text = "Salário por Hora";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(167, 138);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(44, 16);
            this.lbl_nome.TabIndex = 11;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Location = new System.Drawing.Point(167, 78);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(61, 16);
            this.lbl_matricula.TabIndex = 10;
            this.lbl_matricula.Text = "Matrícula";
            // 
            // lbl_horas
            // 
            this.lbl_horas.AutoSize = true;
            this.lbl_horas.Location = new System.Drawing.Point(167, 305);
            this.lbl_horas.Name = "lbl_horas";
            this.lbl_horas.Size = new System.Drawing.Size(136, 16);
            this.lbl_horas.TabIndex = 20;
            this.lbl_horas.Text = "Quantidade de Horas";
            // 
            // lbl_faltas
            // 
            this.lbl_faltas.AutoSize = true;
            this.lbl_faltas.Location = new System.Drawing.Point(167, 353);
            this.lbl_faltas.Name = "lbl_faltas";
            this.lbl_faltas.Size = new System.Drawing.Size(87, 16);
            this.lbl_faltas.TabIndex = 21;
            this.lbl_faltas.Text = "Dais de Falta";
            // 
            // txt_hora
            // 
            this.txt_hora.Location = new System.Drawing.Point(403, 299);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(100, 22);
            this.txt_hora.TabIndex = 22;
            // 
            // txt_falta
            // 
            this.txt_falta.Location = new System.Drawing.Point(403, 347);
            this.txt_falta.Name = "txt_falta";
            this.txt_falta.Size = new System.Drawing.Size(100, 22);
            this.txt_falta.TabIndex = 23;
            // 
            // frm_horista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_falta);
            this.Controls.Add(this.txt_hora);
            this.Controls.Add(this.lbl_faltas);
            this.Controls.Add(this.lbl_horas);
            this.Controls.Add(this.btn_horista);
            this.Controls.Add(this.txt_dataEntrada);
            this.Controls.Add(this.txt_salarioHora);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.lbl_dataEntrada);
            this.Controls.Add(this.lbl_salarioHora);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_matricula);
            this.Name = "frm_horista";
            this.Text = "frm_horista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_horista;
        private System.Windows.Forms.TextBox txt_dataEntrada;
        private System.Windows.Forms.TextBox txt_salarioHora;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.Label lbl_dataEntrada;
        private System.Windows.Forms.Label lbl_salarioHora;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_horas;
        private System.Windows.Forms.Label lbl_faltas;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.TextBox txt_falta;
    }
}