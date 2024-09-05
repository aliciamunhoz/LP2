namespace PTesteMetodos
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
            this.tbx_ex2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbx_ex2
            // 
            this.tbx_ex2.Location = new System.Drawing.Point(368, 190);
            this.tbx_ex2.Name = "tbx_ex2";
            this.tbx_ex2.Size = new System.Drawing.Size(100, 20);
            this.tbx_ex2.TabIndex = 0;
            // 
            // frm_ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_ex2);
            this.Name = "frm_ex2";
            this.Text = "frmEx2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_ex2;
    }
}