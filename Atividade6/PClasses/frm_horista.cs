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
    public partial class frm_horista : Form
    {
        public frm_horista()
        {
            InitializeComponent();
        }

        private void btn_horista_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            objHorista.NomeEmpregado = txt_nome.Text;
            objHorista.Matricula = Convert.ToInt32(txt_matricula.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txt_dataEntrada.Text);
            objHorista.SalarioHora = Convert.ToDouble(txt_salarioHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txt_hora.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txt_dataEntrada.Text);
            objHorista.DiasFalta = Convert.ToInt32(txt_falta.Text);

            MessageBox.Show($"Nome: {objHorista.NomeEmpregado} \nMatrícula: {objHorista.Matricula} " +
                $"\nTempo de Trabalho: {objHorista.TempoTrabalho()} \nSalário Final: " +
                $"{objHorista.SalarioBruto().ToString("N2")}");
        }
    }
}
