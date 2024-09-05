namespace PTesteLoops
{
    partial class frm_ex1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.rchTxt = new System.Windows.Forms.RichTextBox();
            this.btnEspacos = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnLetrasIguais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl1.Location = new System.Drawing.Point(143, 130);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(259, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Digite um texto de no máximo 100 letras";
            // 
            // rchTxt
            // 
            this.rchTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rchTxt.ForeColor = System.Drawing.Color.Black;
            this.rchTxt.Location = new System.Drawing.Point(97, 181);
            this.rchTxt.Name = "rchTxt";
            this.rchTxt.Size = new System.Drawing.Size(342, 154);
            this.rchTxt.TabIndex = 1;
            this.rchTxt.Text = "";
            // 
            // btnEspacos
            // 
            this.btnEspacos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEspacos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEspacos.Location = new System.Drawing.Point(505, 130);
            this.btnEspacos.Name = "btnEspacos";
            this.btnEspacos.Size = new System.Drawing.Size(197, 42);
            this.btnEspacos.TabIndex = 2;
            this.btnEspacos.Text = "Descubra a quantidade de espaços em branco existem";
            this.btnEspacos.UseVisualStyleBackColor = true;
            this.btnEspacos.Click += new System.EventHandler(this.btnEspacos_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLetraR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLetraR.Location = new System.Drawing.Point(505, 218);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(197, 44);
            this.btnLetraR.TabIndex = 3;
            this.btnLetraR.Text = "Descubra quantas letras R existem";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetraR_Click);
            // 
            // btnLetrasIguais
            // 
            this.btnLetrasIguais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLetrasIguais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLetrasIguais.Location = new System.Drawing.Point(505, 309);
            this.btnLetrasIguais.Name = "btnLetrasIguais";
            this.btnLetrasIguais.Size = new System.Drawing.Size(197, 44);
            this.btnLetrasIguais.TabIndex = 4;
            this.btnLetrasIguais.Text = "Descubra quantas letras iguais consecutivas existem";
            this.btnLetrasIguais.UseVisualStyleBackColor = true;
            this.btnLetrasIguais.Click += new System.EventHandler(this.btnLetrasIguais_Click);
            // 
            // frm_ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLetrasIguais);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnEspacos);
            this.Controls.Add(this.rchTxt);
            this.Controls.Add(this.lbl1);
            this.Name = "frm_ex1";
            this.Text = "frm_ex1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RichTextBox rchTxt;
        private System.Windows.Forms.Button btnEspacos;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnLetrasIguais;
    }
}