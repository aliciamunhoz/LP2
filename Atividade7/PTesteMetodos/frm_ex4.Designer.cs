namespace PTesteMetodos
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
            this.tbx_1 = new System.Windows.Forms.TextBox();
            this.tbx_2 = new System.Windows.Forms.TextBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_inverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_1
            // 
            this.tbx_1.Location = new System.Drawing.Point(237, 181);
            this.tbx_1.Name = "tbx_1";
            this.tbx_1.Size = new System.Drawing.Size(120, 20);
            this.tbx_1.TabIndex = 13;
            // 
            // tbx_2
            // 
            this.tbx_2.Location = new System.Drawing.Point(428, 181);
            this.tbx_2.Name = "tbx_2";
            this.tbx_2.Size = new System.Drawing.Size(120, 20);
            this.tbx_2.TabIndex = 12;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(290, 148);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(13, 13);
            this.lbl_1.TabIndex = 11;
            this.lbl_1.Text = "1";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(484, 148);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(13, 13);
            this.lbl_2.TabIndex = 10;
            this.lbl_2.Text = "2";
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(251, 236);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(95, 49);
            this.btn_remover.TabIndex = 9;
            this.btn_remover.Text = "Remover 1 do 2";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btn_inverter
            // 
            this.btn_inverter.Location = new System.Drawing.Point(444, 236);
            this.btn_inverter.Name = "btn_inverter";
            this.btn_inverter.Size = new System.Drawing.Size(95, 49);
            this.btn_inverter.TabIndex = 7;
            this.btn_inverter.Text = "Inverter 1";
            this.btn_inverter.UseVisualStyleBackColor = true;
            this.btn_inverter.Click += new System.EventHandler(this.btnI_Click);
            // 
            // frm_ex4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_1);
            this.Controls.Add(this.tbx_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_inverter);
            this.Name = "frm_ex4";
            this.Text = "frmEx4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_1;
        private System.Windows.Forms.TextBox tbx_2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_inverter;
    }
}