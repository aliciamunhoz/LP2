using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteLoops
{
    public partial class frm_ex1 : Form
    {
        public frm_ex1()
        {
            InitializeComponent();
        }

        private void btnEspacos_Click(object sender, EventArgs e)
        {
            string texto = rchTxt.Text;
            int espacos = 0;
            int i = 0;
            while (i < texto.Length)
            {
                if (texto[i] == ' ')
                    espacos++;
                i++;
            }

            MessageBox.Show($"Há {espacos} espaços em branco na frase");
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            string texto = rchTxt.Text;
            int i = 0;
            foreach (char r in texto)
            {
                if (r == 'R' || r == 'r')
                    i++;
            }
            MessageBox.Show($"Existem {i} letras R no texto");
        }

        private void btnLetrasIguais_Click(object sender, EventArgs e)
        {
            string texto = rchTxt.Text;
            int repetida = 0;
            for (int i = 0; i < texto.Length - 1; i++)
            {
                if (texto[i] == texto[i + 1])
                    repetida++;
            }
            MessageBox.Show($"Há {repetida} letras repetidas consecutivas no texto");
        }
    }
}
