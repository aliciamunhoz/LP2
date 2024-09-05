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
    public partial class frm_ex4 : Form
    {
        public frm_ex4()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double bruto;
            int producao, B, C, D;
            double salario;
            double gratificacao;

            producao = Convert.ToInt32(numUpDown_producao.Value);
            salario = Convert.ToDouble(mskdbx_salario.Text);
            gratificacao = Convert.ToDouble(mskdbx_grattificacao.Text);

            if (string.IsNullOrWhiteSpace(tbx_nome.Text))
                MessageBox.Show("Nome inválido");
            if (!int.TryParse(tbx_matricula.Text, out _))
                MessageBox.Show("Apenas números são aceitos na matricula");

            B = producao >= 100 ? 1 : 0;
            C = producao >= 120 ? 1 : 0;
            D = producao >= 150 ? 1 : 0;

            bruto = salario + salario * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacao;

            if (bruto > 7000 && !(producao >= 150 && gratificacao > 0))
                bruto = salario;
            else
                bruto += 0;

            tbx_bruto.Text = bruto.ToString("F2");
        }
    }
}
