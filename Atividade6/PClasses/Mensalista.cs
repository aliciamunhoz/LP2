using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    internal class Mensalista : Empregado
    {
        public double SalarioMensal { get; set; }

        public override double SalarioBruto()
        {
            return SalarioMensal;
        }
        public Mensalista()
        {
            System.Windows.Forms.MessageBox.Show("Mensalista");
        }
        public Mensalista(int matm, string nomem, DateTime detaxm, double salm)
        {
            this.NomeEmpregado = nomem;
            this.Matricula = matm;
            this.NomeEmpregado = nomem;
            this.DataEntradaEmpresa = (DateTime)detaxm;
            this.SalarioMensal = salm;
        }
        public static String Empresa = "toyota";
        public const String Filial = "Filial Sorocaba";
    }
}
