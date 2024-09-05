namespace PTesteMetodos
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_comp = new System.Windows.Forms.Button();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.tbx_2 = new System.Windows.Forms.TextBox();
            this.tbx_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(356, 131);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(95, 49);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(556, 131);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(95, 49);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn_comp
            // 
            this.btn_comp.Location = new System.Drawing.Point(178, 131);
            this.btn_comp.Name = "btn_comp";
            this.btn_comp.Size = new System.Drawing.Size(95, 49);
            this.btn_comp.TabIndex = 2;
            this.btn_comp.Text = "comp";
            this.btn_comp.UseVisualStyleBackColor = true;
            this.btn_comp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(504, 56);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(13, 13);
            this.lbl_2.TabIndex = 3;
            this.lbl_2.Text = "2";
            this.lbl_2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(306, 56);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(13, 13);
            this.lbl_1.TabIndex = 4;
            this.lbl_1.Text = "1";
            this.lbl_1.Click += new System.EventHandler(this.lblP1_Click);
            // 
            // tbx_2
            // 
            this.tbx_2.Location = new System.Drawing.Point(448, 89);
            this.tbx_2.Name = "tbx_2";
            this.tbx_2.Size = new System.Drawing.Size(120, 20);
            this.tbx_2.TabIndex = 5;
            // 
            // tbx_1
            // 
            this.tbx_1.Location = new System.Drawing.Point(257, 89);
            this.tbx_1.Name = "tbx_1";
            this.tbx_1.Size = new System.Drawing.Size(120, 20);
            this.tbx_1.TabIndex = 6;
            // 
            // frm_ex3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_1);
            this.Controls.Add(this.tbx_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.btn_comp);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Name = "frm_ex3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_comp;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox tbx_2;
        private System.Windows.Forms.TextBox tbx_1;
    }
}