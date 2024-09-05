using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMatriz
{
    public partial class Ex_5 : Form
    {
        public Ex_5()
        {
            InitializeComponent();
        }

        private static readonly char[] gabarito = { 'A', 'B', 'C', 'D', 'E', 'A', 'B', 'C', 'D', 'E' };

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int ra = 1+1;
            char[,] respostasAlunos = new char[ra, 10];

            for (int i = 0; i < ra; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    string resposta = Microsoft.VisualBasic.Interaction.InputBox($"Digite a resposta do aluno {i + 1} para a questão {j + 1}:", "Resposta do Aluno", "").ToUpper();
                    if (resposta.Length == 1 && "ABCDE".Contains(resposta))
                    {
                        respostasAlunos[i, j] = resposta[0];
                    }
                    else
                    {
                        MessageBox.Show("Por favor, digite uma resposta válida (A, B, C, D ou E)!");
                        j--; 
                    }
                }
            }

            for (int i = 0; i < ra; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    lstbxNomes.Items.Add($"Aluno {i + 1} - Resposta escolhida {respostasAlunos[i, j]} - Resposta esperada {gabarito[j]}");
                }
            }
        }
    }
}
