namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnReceber = new Button();
            btnLimpar = new Button();
            lstBxDados = new ListBox();
            SuspendLayout();
            // 
            // btnReceber
            // 
            btnReceber.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnReceber.Location = new Point(129, 136);
            btnReceber.Name = "btnReceber";
            btnReceber.Size = new Size(75, 50);
            btnReceber.TabIndex = 0;
            btnReceber.Text = "Receber Dados";
            btnReceber.UseVisualStyleBackColor = true;
            btnReceber.Click += btnReceber_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnLimpar.Location = new Point(129, 243);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 50);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lstBxDados
            // 
            lstBxDados.FormattingEnabled = true;
            lstBxDados.ItemHeight = 15;
            lstBxDados.Location = new Point(322, 51);
            lstBxDados.Name = "lstBxDados";
            lstBxDados.Size = new Size(412, 334);
            lstBxDados.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstBxDados);
            Controls.Add(btnLimpar);
            Controls.Add(btnReceber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReceber;
        private Button btnLimpar;
        private ListBox lstBxDados;
    }
}
