using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario
{
    public partial class frm_salario : Form
    {
        public frm_salario()
        {
            InitializeComponent();
        }

        private bool ContainsNumbersOrSymbols(string input)
        {
            foreach (char c in input) 
            {
                if (char.IsDigit(c) || !char.IsLetterOrDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            string nome = tbx_nome.Text;
            bool containsNumbersOrSymbols = ContainsNumbersOrSymbols(nome);
            string aliqINSS = "";
            double descINSS = 0;
            string aliqIRPF = "";
            double descIRPF = 0;
            double liquido = 0;
            double descFinal = 0;

            if (string.IsNullOrEmpty(nome) || containsNumbersOrSymbols)
            {
                MessageBox.Show("Por favor, insira um nome válido.");
            }

            double bruto;
            if (!double.TryParse(msktbx_bruto.Text, out bruto))
            {
                MessageBox.Show("Por favor, insira um valor válido para o salário bruto.");
                return;
            }

            if (bruto <= 1412)
            {
                aliqINSS = "7,5%";
                descINSS = 0.075 * bruto;
            } 
            else if (bruto <= 2666.68)
            {
                aliqINSS = "9%";
                descINSS = 0.09 * bruto;
            }
            else if (bruto <= 4000.03)
            {
                aliqINSS = "12%";
                descINSS = 0.12 * bruto;
            }
            else
            {
                aliqINSS = "14%";
                descINSS = 0.14 * bruto;
            }

            tbx_descINSS.Text = descINSS.ToString();
            tbx_aliqINSS.Text = aliqINSS;
            liquido = bruto - descINSS;

            if (liquido <= 2259.20)
            {
                aliqIRPF = "0%";
                descIRPF = 0;
            }
            else if (liquido <= 2826.65)
            {
                aliqIRPF = "7.5%";
                descIRPF = 169.44;
            }
            else if (liquido <= 3751.05)
            {
                aliqIRPF = "15%";
                descIRPF = 381.44;
            }
            else if (liquido <= 4664.68)
            {
                aliqIRPF = "22.5%";
                descIRPF = 662.77;
            }
            else
            {
                aliqIRPF = "27.5%";
                descIRPF = 896;
            }

            double filhos = 189.59 * (double)nud_filhos.Value;

            if (descIRPF < filhos)
            {
                descFinal = 0;
            }
            else
            {
                descFinal = descIRPF - filhos;
            }

            tbx_descIRPF.Text = descIRPF.ToString();
            tbx_aliqIRPF.Text = aliqIRPF;
            tbx_familia.Text = filhos.ToString();
            tbx_liquido.Text = liquido.ToString();
            tbx_descFinal.Text = descFinal.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbx_nome.Clear();
            msktbx_bruto.Clear();
            nud_filhos.Value = 0;
            tbx_aliqINSS.Clear();
            tbx_descINSS.Clear();
            tbx_aliqIRPF.Clear();
            tbx_descIRPF.Clear();
            tbx_familia.Clear();
            tbx_descFinal.Clear();
            tbx_liquido.Clear();
        }
    }
}