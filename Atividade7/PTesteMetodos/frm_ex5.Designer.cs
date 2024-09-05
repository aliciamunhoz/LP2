namespace PTesteMetodos
{
    partial class frm_ex5
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
            this.rtx_1 = new System.Windows.Forms.RichTextBox();
            this.btn_nN = new System.Windows.Forms.Button();
            this.btn_branco = new System.Windows.Forms.Button();
            this.btn_letras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtx_1
            // 
            this.rtx_1.Location = new System.Drawing.Point(247, 134);
            this.rtx_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtx_1.Name = "rtx_1";
            this.rtx_1.Size = new System.Drawing.Size(116, 79);
            this.rtx_1.TabIndex = 0;
            this.rtx_1.Text = "";
            // 
            // btn_nN
            // 
            this.btn_nN.Location = new System.Drawing.Point(70, 262);
            this.btn_nN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_nN.Name = "btn_nN";
            this.btn_nN.Size = new System.Drawing.Size(121, 37);
            this.btn_nN.TabIndex = 1;
            this.btn_nN.Text = "Numero de numeros";
            this.btn_nN.UseVisualStyleBackColor = true;
            this.btn_nN.Click += new System.EventHandler(this.btnNNum_Click);
            // 
            // btn_branco
            // 
            this.btn_branco.Location = new System.Drawing.Point(247, 262);
            this.btn_branco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_branco.Name = "btn_branco";
            this.btn_branco.Size = new System.Drawing.Size(120, 37);
            this.btn_branco.TabIndex = 2;
            this.btn_branco.Text = "Primeiro em branco";
            this.btn_branco.UseVisualStyleBackColor = true;
            this.btn_branco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btn_letras
            // 
            this.btn_letras.Location = new System.Drawing.Point(451, 262);
            this.btn_letras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_letras.Name = "btn_letras";
            this.btn_letras.Size = new System.Drawing.Size(109, 40);
            this.btn_letras.TabIndex = 3;
            this.btn_letras.Text = "Numero de letras";
            this.btn_letras.UseVisualStyleBackColor = true;
            this.btn_letras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // frm_ex5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_letras);
            this.Controls.Add(this.btn_branco);
            this.Controls.Add(this.btn_nN);
            this.Controls.Add(this.rtx_1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_ex5";
            this.Text = "frmEx5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtx_1;
        private System.Windows.Forms.Button btn_nN;
        private System.Windows.Forms.Button btn_branco;
        private System.Windows.Forms.Button btn_letras;
    }
}