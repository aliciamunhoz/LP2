using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; //Para usar o InputBox > Projeto > Add Referencia > Selecionar Microsoft.VisualBasic 

namespace PTesteMatriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20]; //Criar vetor 
            string auxiliar;
            for (int i = 0; i < vetor.Length; i++) 
            {
                auxiliar = Interaction.InputBox($"Digite um número {i+1}", "Entrada de dados");
                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Número inválido !");
                    i--;
                }

            }
            Array.Reverse(vetor); //Inverter Vetor
            auxiliar = "";
            foreach (int i in vetor) 
            {
                auxiliar += i + "\n";            
            }

            MessageBox.Show(auxiliar);
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            ArrayList listaAlunos = new ArrayList()
            {
            "Ana", "André", "Débora", "Fátima", "João",
            "Janete", "Otávio", "Marcelo", "Pedro", "Thais"
            };

            listaAlunos.Remove("Otávio");
            string auxiliar = "";

            foreach (string aluno in listaAlunos)
            {
                auxiliar += aluno + "\n";
            }
           
            MessageBox.Show(auxiliar);
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            double[,] matriz = new double[20, 3];
            string auxiliar;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    auxiliar = Interaction.InputBox($"Digite a nota {j + 1} do aluno {i + 1}:");

                    if (!double.TryParse(auxiliar, out matriz[i, j]) || (matriz[i, j] < 0) || (matriz[i, j] > 10))
                    {
                        MessageBox.Show("Número inválido !");
                        i--;
                    }

                }
            }

            string mensagem = "";
            for (int i = 0; i < 20; i++)
            {
                double soma = 0;
                for (int j = 0; j < 3; j++)
                {

                    soma += matriz[i, j];
                }
                double media = soma / 3;
                mensagem += $"Aluno {i + 1}: média: {media.ToString("0.0")}\n";
            }

            MessageBox.Show(mensagem, "Média dos Alunos"); 
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            Ex_4 tela = new Ex_4();
            tela.Show();
        }

        private void btnEx5_Click(object sender, EventArgs e)
        {
            Ex_5 tela = new Ex_5();
            tela.Show();
        }
    }
}

