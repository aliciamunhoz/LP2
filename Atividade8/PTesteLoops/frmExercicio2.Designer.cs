namespace PTesteLoops
{
    partial class frm_ex2
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
            this.lbl_inteiroPositivo = new System.Windows.Forms.Label();
            this.tbx_numero = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.tbx_resultado = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_inteiroPositivo
            // 
            this.lbl_inteiroPositivo.AutoSize = true;
            this.lbl_inteiroPositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_inteiroPositivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_inteiroPositivo.Location = new System.Drawing.Point(108, 113);
            this.lbl_inteiroPositivo.Name = "lbl_inteiroPositivo";
            this.lbl_inteiroPositivo.Size = new System.Drawing.Size(212, 17);
            this.lbl_inteiroPositivo.TabIndex = 1;
            this.lbl_inteiroPositivo.Text = "Insira um número inteiro positivo";
            // 
            // tbx_numero
            // 
            this.tbx_numero.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbx_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbx_numero.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbx_numero.Location = new System.Drawing.Point(73, 145);
            this.tbx_numero.Name = "tbx_numero";
            this.tbx_numero.Size = new System.Drawing.Size(280, 23);
            this.tbx_numero.TabIndex = 2;
            this.tbx_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_resultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_resultado.Location = new System.Drawing.Point(524, 166);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(72, 17);
            this.lbl_resultado.TabIndex = 3;
            this.lbl_resultado.Text = "Resultado";
            // 
            // tbx_resultado
            // 
            this.tbx_resultado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbx_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbx_resultado.Location = new System.Drawing.Point(430, 210);
            this.tbx_resultado.Name = "tbx_resultado";
            this.tbx_resultado.ReadOnly = true;
            this.tbx_resultado.Size = new System.Drawing.Size(280, 23);
            this.tbx_resultado.TabIndex = 4;
            this.tbx_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_calcular.Location = new System.Drawing.Point(168, 216);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(100, 40);
            this.btn_calcular.TabIndex = 5;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // frm_ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.tbx_resultado);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.tbx_numero);
            this.Controls.Add(this.lbl_inteiroPositivo);
            this.Name = "frm_ex2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_inteiroPositivo;
        private System.Windows.Forms.TextBox tbx_numero;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.TextBox tbx_resultado;
        private System.Windows.Forms.Button btn_calcular;
    }
}