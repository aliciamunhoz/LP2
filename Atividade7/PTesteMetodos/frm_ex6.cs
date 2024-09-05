using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PTesteMetodos
{
    public partial class frm_ex6 : Form
    {
        public frm_ex6()
        {
            InitializeComponent();
        }


        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string input1 = tbx_n1.Text;
            string input2 = tbx_n2.Text;

            if (IsNumeric(input1) && IsNumeric(input2))
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(2); 
                if (randomNumber == 0)
                {
                    MessageBox.Show($"{input1}");
                }
                else
                {
                    MessageBox.Show($"{input2}");
                }
            }
            else
            {
                MessageBox.Show("Preencha ambas as caixas de texto com números.");
            }
        }
    }
    }

