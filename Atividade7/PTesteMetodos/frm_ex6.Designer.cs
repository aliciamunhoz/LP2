namespace PTesteMetodos
{
    partial class frm_ex6
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
            this.tbx_n1 = new System.Windows.Forms.TextBox();
            this.tbx_n2 = new System.Windows.Forms.TextBox();
            this.btn_sort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_n1
            // 
            this.tbx_n1.Location = new System.Drawing.Point(398, 149);
            this.tbx_n1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_n1.Name = "tbx_n1";
            this.tbx_n1.Size = new System.Drawing.Size(76, 20);
            this.tbx_n1.TabIndex = 0;
            // 
            // tbx_n2
            // 
            this.tbx_n2.Location = new System.Drawing.Point(143, 149);
            this.tbx_n2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_n2.Name = "tbx_n2";
            this.tbx_n2.Size = new System.Drawing.Size(76, 20);
            this.tbx_n2.TabIndex = 1;
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(277, 249);
            this.btn_sort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(56, 19);
            this.btn_sort.TabIndex = 2;
            this.btn_sort.Text = "Sortear";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // frm_ex6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.tbx_n2);
            this.Controls.Add(this.tbx_n1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_ex6";
            this.Text = "frmE6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_n1;
        private System.Windows.Forms.TextBox tbx_n2;
        private System.Windows.Forms.Button btn_sort;
    }
}