namespace PDisaster0030482321007
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.outrosCadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroCidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroTipoDeEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outrosCadastrosToolStripMenuItem,
            this.cadastroEventoToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(514, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // outrosCadastrosToolStripMenuItem
            // 
            this.outrosCadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroCidadesToolStripMenuItem,
            this.cadastroTipoDeEventosToolStripMenuItem});
            this.outrosCadastrosToolStripMenuItem.Name = "outrosCadastrosToolStripMenuItem";
            this.outrosCadastrosToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.outrosCadastrosToolStripMenuItem.Text = "Outros Cadastros";
            // 
            // cadastroCidadesToolStripMenuItem
            // 
            this.cadastroCidadesToolStripMenuItem.Name = "cadastroCidadesToolStripMenuItem";
            this.cadastroCidadesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cadastroCidadesToolStripMenuItem.Text = "Cadastro Cidades";
            this.cadastroCidadesToolStripMenuItem.Click += new System.EventHandler(this.cadastroCidadesToolStripMenuItem_Click);
            // 
            // cadastroTipoDeEventosToolStripMenuItem
            // 
            this.cadastroTipoDeEventosToolStripMenuItem.Name = "cadastroTipoDeEventosToolStripMenuItem";
            this.cadastroTipoDeEventosToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cadastroTipoDeEventosToolStripMenuItem.Text = "Cadastro Tipo de Eventos";
            this.cadastroTipoDeEventosToolStripMenuItem.Click += new System.EventHandler(this.cadastroTipoDeEventosToolStripMenuItem_Click);
            // 
            // cadastroEventoToolStripMenuItem
            // 
            this.cadastroEventoToolStripMenuItem.Name = "cadastroEventoToolStripMenuItem";
            this.cadastroEventoToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.cadastroEventoToolStripMenuItem.Text = "Cadastro Evento";
            this.cadastroEventoToolStripMenuItem.Click += new System.EventHandler(this.cadastroEventoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 561);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load_1);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem outrosCadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroCidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroTipoDeEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

