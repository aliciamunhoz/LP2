using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    abstract internal class Empregado
    {
        private int matricula;
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;

        public int Matricula //propriedade
        {
            get { return matricula; }
            set { matricula = value; } 
        }

        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        // metodos sao acoes/comportamentos
        // virtual pode ser sobreescrito

        public virtual int TempoTrabalho()
        {
            // representa um intervalo de tempo
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days);
        }

        // deve ser implementado
        // derived classes must implement this
        public abstract double SalarioBruto();

        public Empregado()
        {
            System.Windows.Forms.MessageBox.Show("Empregado");
        }
        public Empregado(int mat, string nome, DateTime detax)
        {
            matricula =  mat;
            nomeEmpregado = nome;
            dataEntradaEmpresa = (DateTime)detax;
        }
    }
}
