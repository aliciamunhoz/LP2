namespace PTesteLoops
{
    partial class frm_ex3
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
            this.lbl_palindromo = new System.Windows.Forms.Label();
            this.tbx_palavra = new System.Windows.Forms.TextBox();
            this.tbx_palindromo = new System.Windows.Forms.TextBox();
            this.btn_teste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_palindromo
            // 
            this.lbl_palindromo.AutoSize = true;
            this.lbl_palindromo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_palindromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_palindromo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_palindromo.Location = new System.Drawing.Point(329, 95);
            this.lbl_palindromo.Name = "lbl_palindromo";
            this.lbl_palindromo.Size = new System.Drawing.Size(150, 17);
            this.lbl_palindromo.TabIndex = 2;
            this.lbl_palindromo.Text = "Isso é um palíndromo?";
            // 
            // tbx_palavra
            // 
            this.tbx_palavra.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbx_palavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbx_palavra.Location = new System.Drawing.Point(250, 132);
            this.tbx_palavra.Name = "tbx_palavra";
            this.tbx_palavra.Size = new System.Drawing.Size(284, 23);
            this.tbx_palavra.TabIndex = 3;
            // 
            // tbx_palindromo
            // 
            this.tbx_palindromo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbx_palindromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbx_palindromo.Location = new System.Drawing.Point(250, 285);
            this.tbx_palindromo.Name = "tbx_palindromo";
            this.tbx_palindromo.ReadOnly = true;
            this.tbx_palindromo.Size = new System.Drawing.Size(284, 23);
            this.tbx_palindromo.TabIndex = 4;
            this.tbx_palindromo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_teste
            // 
            this.btn_teste.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_teste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_teste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_teste.Location = new System.Drawing.Point(345, 184);
            this.btn_teste.Name = "btn_teste";
            this.btn_teste.Size = new System.Drawing.Size(112, 39);
            this.btn_teste.TabIndex = 5;
            this.btn_teste.Text = "Testar";
            this.btn_teste.UseVisualStyleBackColor = false;
            this.btn_teste.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // frm_ex3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_teste);
            this.Controls.Add(this.tbx_palindromo);
            this.Controls.Add(this.tbx_palavra);
            this.Controls.Add(this.lbl_palindromo);
            this.Name = "frm_ex3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_palindromo;
        private System.Windows.Forms.TextBox tbx_palavra;
        private System.Windows.Forms.TextBox tbx_palindromo;
        private System.Windows.Forms.Button btn_teste;
    }
}