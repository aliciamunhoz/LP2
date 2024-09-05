using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PDisaster0030482321007
{
    internal class Tipo
    {
        public int IDTipo { get; set; }
        public string Descricao { get; set; }

        public DataTable Listar()
        {
            SqlDataAdapter daTipo;
            DataTable dtTipo = new DataTable();

            try
            {
                daTipo = new SqlDataAdapter("SELECT * FROM Tipo ORDER BY DESCRICAO", frmPrincipal.conexao);
                daTipo.Fill(dtTipo);
                daTipo.FillSchema(dtTipo, SchemaType.Source);
            }
            catch (Exception ex) 
            {
                throw;
            }

            return dtTipo;
        }

        public int Incluir()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("INSERT INTO Tipo VALUES (@DESCRICAO)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@DESCRICAO", SqlDbType.VarChar));
                
                mycommand.Parameters["@DESCRICAO"].Value = Descricao;

                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
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

                mycommand = new SqlCommand("UPDATE Tipo SET DESCRICAO = @DESCRICAO WHERE IDTipo = @IDTipo", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@IDTipo", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@DESCRICAO", SqlDbType.VarChar));

                mycommand.Parameters["@IDTipo"].Value = IDTipo;
                mycommand.Parameters["@DESCRICAO"].Value = Descricao;

                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
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

                mycommand = new SqlCommand("DELETE FROM Tipo WHERE IDTipo = @IdTipo", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@IDTipo", SqlDbType.Int));
                mycommand.Parameters["@IDTipo"].Value = IDTipo;

                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }

            return nReg;
        }
    }
}
