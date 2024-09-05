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
    public partial class frm_ex3 : Form
    {
        public frm_ex3()
        {
            InitializeComponent();
        }
        bool palindromo;

        private void btnTest_Click(object sender, EventArgs e)
        {
            string frase = tbx_palavra.Text;
            string semEspacos = frase.Trim();
            string maiuscula = semEspacos.ToUpper();

            int inicio = 0;
            int fim = maiuscula.Length - 1;


            while (inicio < fim)
            {
                if (maiuscula[inicio] != maiuscula[fim])
                    palindromo = false;
                else
                    palindromo = true;
                inicio++;
                fim--;
            }
            if (palindromo == true)
                tbx_palindromo.Text = "É um palindromo";
            else
                tbx_palindromo.Text = "Não é um palindromo";
        }
    }
}
