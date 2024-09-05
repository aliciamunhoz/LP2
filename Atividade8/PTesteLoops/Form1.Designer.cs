namespace PTesteLoops
{
    partial class frm_inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ex1_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex2_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex3_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex4_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sair_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ex1_toolStripMenuItem,
            this.ex2_toolStripMenuItem,
            this.ex3_toolStripMenuItem,
            this.ex4_toolStripMenuItem,
            this.sair_toolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ex1_toolStripMenuItem
            // 
            this.ex1_toolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ex1_toolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ex1_toolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ex1_toolStripMenuItem.Name = "ex1_toolStripMenuItem";
            this.ex1_toolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.ex1_toolStripMenuItem.Text = "Exercicio 1";
            this.ex1_toolStripMenuItem.Click += new System.EventHandler(this.exercicio1ToolStripMenuItem_Click);
            // 
            // ex2_toolStripMenuItem
            // 
            this.ex2_toolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ex2_toolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ex2_toolStripMenuItem.Name = "ex2_toolStripMenuItem";
            this.ex2_toolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.ex2_toolStripMenuItem.Text = "Exercicio 2";
            this.ex2_toolStripMenuItem.Click += new System.EventHandler(this.exercicio2ToolStripMenuItem_Click);
            // 
            // ex3_toolStripMenuItem
            // 
            this.ex3_toolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ex3_toolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ex3_toolStripMenuItem.Name = "ex3_toolStripMenuItem";
            this.ex3_toolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.ex3_toolStripMenuItem.Text = "Exercicio 3";
            this.ex3_toolStripMenuItem.Click += new System.EventHandler(this.exercicio3ToolStripMenuItem_Click);
            // 
            // ex4_toolStripMenuItem
            // 
            this.ex4_toolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ex4_toolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ex4_toolStripMenuItem.Name = "ex4_toolStripMenuItem";
            this.ex4_toolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.ex4_toolStripMenuItem.Text = "Exercicio 4";
            this.ex4_toolStripMenuItem.Click += new System.EventHandler(this.exercicio4ToolStripMenuItem_Click);
            // 
            // sair_toolStripMenuItem
            // 
            this.sair_toolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sair_toolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sair_toolStripMenuItem.Name = "sair_toolStripMenuItem";
            this.sair_toolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.sair_toolStripMenuItem.Text = "Sair";
            this.sair_toolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frm_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_inicial";
            this.Text = "frm_inicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ex1_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex2_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex3_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex4_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sair_toolStripMenuItem;
    }
}

