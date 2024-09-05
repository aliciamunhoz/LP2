using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class frm_volume : Form
    {
        double raio, altura, volume;

        public frm_volume()
        {
            InitializeComponent();
        }

        private void txt_raio_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txt_raio.Text, out raio))
            {
                MessageBox.Show("Raio inválido!");
            } 
            else
            {
                if (raio <= 0)
                {
                    MessageBox.Show("Raio deve ser maior que zero!");
                }
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_altura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txt_altura.Text, out altura))
            {
                MessageBox.Show("Altura inválido!");
            }
            else if (altura <= 0)
            {
                MessageBox.Show("Altura deve ser maior que zero!");
            }

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txt_raio.Text,out raio) || !double.TryParse(txt_altura.Text, out altura))
            {
                MessageBox.Show("Valores inválidos!");
                txt_raio.Focus();
            }
            else if (raio <= 0 || altura < 0)
            {
                MessageBox.Show("Valores devem ser maiores que zero!");
                txt_raio.Focus();
            } 
            else
            {
                volume = Math.PI * Math.Pow(raio, 2) * altura;
                txt_volume.Text = volume.ToString("N2");
            }
        }
    }
}
