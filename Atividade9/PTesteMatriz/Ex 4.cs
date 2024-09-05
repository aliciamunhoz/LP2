using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMatriz
{
    public partial class Ex_4 : Form
    {
        public Ex_4()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int ra = 7;
            string[] nomes = new string[ra]; //Criar vetor 
            int[] tamanho = new int[ra];

            for (int i = 0; i < ra; i++)
            {
                nomes[i] = Interaction.InputBox($"Digite o nome da pessoa {i + 1}", "Entrada de dados");
                tamanho[i] = nomes[i].Replace(" ", "").Length;                
            }

            for (int i = 0; i < ra; i++)
            {
                lstbxNomes.Items.Add("Nome: " + nomes[i] + " tem " + tamanho[i] + " caracteres\n");
            }
        }
    }
}
