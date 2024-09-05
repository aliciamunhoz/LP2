using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class frm_ex5 : Form
    {
        public frm_ex5()
        {
            InitializeComponent();
        }

        private void btnNNum_Click(object sender, EventArgs e)
        {
            string text = rtx_1.Text;
            int cont=0;
            for (int i = 0; i < text.Length; i++)
            { 
                if (Char.IsNumber(text[i]))
                {
                    cont++;
                }
               
            }
            MessageBox.Show($"Há {cont} números");
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int ront = 0;
            string text = rtx_1.Text;
            for (int j = 0; j < text.Length; j++)
            {
                if (Char.IsWhiteSpace(text[j]))
                {
                    MessageBox.Show($"O primeiro espaço em branco está no índice: {j}");
                    ront++;
                    break; // Se encontrou o primeiro espaço em branco, não precisa continuar o loop
                }
            }
                if (ront==0) { 
               
                    MessageBox.Show("Não há espaço em branco");
                }
            
        }

        private void btnLetras_Click(object sender, EventArgs e)
        {
            string text = rtx_1.Text;
            int xont =0;
            for (int i= 0;i< text.Length;i++)
            {
              if (Char.IsLetter(text[i]))
                {
                    xont++;
                }
            }
            MessageBox.Show($"Há {xont} letras");
        }
    }
    
}
