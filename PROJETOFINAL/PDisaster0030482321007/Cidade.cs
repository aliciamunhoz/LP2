using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDisaster0030482321007
{
    internal class Cidade
    {
        public int IDCidade { get; set; }

        public string Nome { get; set; }

        public string UF { get; set;}

        public int Populacao { get; set;}

        public DataTable Listar()
        {
            SqlDataAdapter daCidade; 
            DataTable dtCidade = new DataTable();

            try
            {
                daCidade = new SqlDataAdapter("SELECT * FROM CIDADE ORDER BY NOME", frmPrincipal.conexao);
                daCidade.Fill(dtCidade);
                daCidade.FillSchema(dtCidade, SchemaType.Source);

            }

            catch(Exception)
            {
                throw;
            }

            return dtCidade;

        }
        
        public int Incluir() 
        {
            int retorno = 0;
            try 
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("INSERT INTO CIDADE VALUES (@NOME, @UF, @POPULACAO)", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@NOME", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@UF", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@POPULACAO", SqlDbType.Int));
                mycommand.Parameters["@NOME"].Value = Nome;
                mycommand.Parameters["@UF"].Value = UF;
                mycommand.Parameters["@POPULACAO"].Value = Populacao;

                retorno = mycommand.ExecuteNonQuery();

            }

            catch (Exception) 
            {
                throw;
            }

            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("UPDATE Cidade SET NOME = @NOME, UF = @UF, POPULACAO = @POPULACAO WHERE IDCidade = @IDCidade", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@IDCidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@NOME", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@UF", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@POPULACAO", SqlDbType.Int));

                mycommand.Parameters["@IDCidade"].Value = IDCidade;
                mycommand.Parameters["@NOME"].Value = Nome;
                mycommand.Parameters["@UF"].Value = UF;
                mycommand.Parameters["@POPULACAO"].Value = Populacao;

                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }

        public int Excluir()
        {
            int nReg = 0;

            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("DELETE FROM Cidade WHERE IDCidade = @IDCidade", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@IDCidade", SqlDbType.Int));
                mycommand.Parameters["@IDCidade"].Value = IDCidade;

                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            return nReg;
        }
    }
}
