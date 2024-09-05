namespace PVolume
{
    partial class frm_volume
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
            this.lbl_raio = new System.Windows.Forms.Label();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.txt_raio = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_volume = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_raio
            // 
            this.lbl_raio.AutoSize = true;
            this.lbl_raio.Location = new System.Drawing.Point(70, 60);
            this.lbl_raio.Name = "lbl_raio";
            this.lbl_raio.Size = new System.Drawing.Size(29, 13);
            this.lbl_raio.TabIndex = 0;
            this.lbl_raio.Text = "Raio";
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(70, 100);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(34, 13);
            this.lbl_altura.TabIndex = 1;
            this.lbl_altura.Text = "Altura";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Location = new System.Drawing.Point(70, 140);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(42, 13);
            this.lbl_volume.TabIndex = 2;
            this.lbl_volume.Text = "Volume";
            // 
            // txt_raio
            // 
            this.txt_raio.Location = new System.Drawing.Point(150, 60);
            this.txt_raio.Name = "txt_raio";
            this.txt_raio.Size = new System.Drawing.Size(100, 20);
            this.txt_raio.TabIndex = 3;
            this.txt_raio.Validated += new System.EventHandler(this.txt_raio_Validated);
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(150, 100);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(100, 20);
            this.txt_altura.TabIndex = 4;
            this.txt_altura.Validated += new System.EventHandler(this.txt_altura_Validated);
            // 
            // txt_volume
            // 
            this.txt_volume.Enabled = false;
            this.txt_volume.Location = new System.Drawing.Point(150, 140);
            this.txt_volume.Name = "txt_volume";
            this.txt_volume.Size = new System.Drawing.Size(100, 20);
            this.txt_volume.TabIndex = 5;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(60, 200);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 6;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(200, 200);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 7;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // frm_volume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 271);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_volume);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_raio);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.lbl_raio);
            this.Name = "frm_volume";
            this.Text = "Cálculo do Volume do Cilindro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_raio;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.TextBox txt_raio;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_volume;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_fechar;
    }
}

