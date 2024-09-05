using System.Windows.Forms;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnReceber_Click(object sender, EventArgs e)
    {
        int ra = 7;
        int[,] alunos = new int[ra, 5];
        int auxiliar = 0;
        int soma = 0;
        int[] anos = new int[5];
        int total = 0;
        int geral = 0;

        for (int i = 0; i < ra; i++)
        {
            soma = 0;
            for (int j = 0; j < 5; j++)
            {
                string resposta = Microsoft.VisualBasic.Interaction.InputBox($"Digite o total de alunos do curso {i + 1} para o ano {j + 1}:", "Total de alunos do curso", "");
                if (int.TryParse(resposta, out auxiliar))
                {
                    alunos[i, j] = auxiliar;
                    soma += auxiliar;
                    total += soma;

                }
                else
                {
                    MessageBox.Show("Por favor, digite um número válido!");
                    j--;
                }
            }
            anos[i] = soma;
            geral += anos[i];
        }

        for (int i = 0; i < ra; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                lstBxDados.Items.Add($"Total do curso {i + 1} do Ano {j + 1}: {alunos[i, j]}");
            }
            lstBxDados.Items.Add("_____________________________________________");
            lstBxDados.Items.Add($"Total curso {i + 1}: {anos[i]}");
        }
        lstBxDados.Items.Add("_____________________________________________");
        lstBxDados.Items.Add($"Total geral: {geral}");
    }

    private void btnLimpar_Click(object sender, EventArgs e)
    {
        lstBxDados.Items.Clear();
    }
}

