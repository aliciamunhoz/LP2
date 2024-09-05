using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frm_mensalista : Form
    {
        public frm_mensalista()
        {
            InitializeComponent();
        }

        private void btn_mensalistaDireto_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();

            objMensalista.NomeEmpregado = txt_nome.Text;
            objMensalista.Matricula = Convert.ToInt32(txt_matricula.Text);
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txt_dataEntrada.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txt_salarioMensal.Text);

            MessageBox.Show($"Nome: {objMensalista.NomeEmpregado} \nMatrícula: {objMensalista.Matricula} " +
                $"\nTempo de Trabalho: {objMensalista.TempoTrabalho()} \nSalário Final: " +
                $"{objMensalista.SalarioBruto().ToString("N2")}");
            MessageBox.Show(Mensalista.Empresa);
            MessageBox.Show(Mensalista.Filial);
        }
    }
}
