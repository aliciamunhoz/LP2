using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PDisaster0030482321007
{
    internal class Evento
    {
        public int IDEvento { get; set; }
        public int Tipo_IDTipo { get; set; }
        public int Cidade_IDCidade { get; set; }
        public char NivelSeveridade { get; set; }
        public int AreaAfetada { get; set; }
        public int PessoasAfetadas { get; set; }
        public string Observacao { get; set; }
        public DateTime DataOcorrencia { get; set; }

        public DataTable Listar()
        {
            SqlDataAdapter daEvento;
            DataTable dtEvento = new DataTable();

            try
            {
                daEvento = new SqlDataAdapter("SELECT * FROM Evento ORDER BY IDEVENTO", frmPrincipal.conexao);
                daEvento.Fill(dtEvento);
                daEvento.FillSchema(dtEvento, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw;
            }

            return dtEvento;
        }

        public int Incluir()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("INSERT INTO Evento VALUES (@IDTIPO, @IDCIDADE, @NIVELSEVERIDADE, @AREAAFETADA, @PESSOASAFETADAS, @OBSERVACAO, @DATAOCORRENCIA)", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@IDTIPO", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@IDCIDADE", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@NIVELSEVERIDADE", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@AREAAFETADA", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@PESSOASAFETADAS", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@OBSERVACAO", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@DATAOCORRENCIA", SqlDbType.DateTime));

                mycommand.Parameters["@IDTIPO"].Value = Tipo_IDTipo;
                mycommand.Parameters["@IDCIDADE"].Value = Cidade_IDCidade;
                mycommand.Parameters["@NIVELSEVERIDADE"].Value = NivelSeveridade;
                mycommand.Parameters["@AREAAFETADA"].Value = AreaAfetada;
                mycommand.Parameters["@PESSOASAFETADAS"].Value = PessoasAfetadas;
                mycommand.Parameters["@OBSERVACAO"].Value = Observacao;
                mycommand.Parameters["@DATAOCORRENCIA"].Value = DataOcorrencia;

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

                mycommand = new SqlCommand("UPDATE Evento SET TIPO_IDTIPO = @IDTIPO, CIDADE_IDCIDADE = @IDCIDADE, NIVELSEVERIDADE = @NIVELSEVERIDADE, AREAAFETADA = @AREAAFETADA, "
                    + "PESSOASAFETADAS = @PESSOASAFETADAS, OBSERVACAO = @OBSERVACAO, DATAOCORRENCIA = @DATAOCORRENCIA WHERE IDEVENTO = @IDEVENTO", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@IDEVENTO", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@IDTIPO", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@IDCIDADE", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@NIVELSEVERIDADE", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@AREAAFETADA", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@PESSOASAFETADAS", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@OBSERVACAO", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@DATAOCORRENCIA", SqlDbType.DateTime));

                mycommand.Parameters["@IDEVENTO"].Value = IDEvento;
                mycommand.Parameters["@IDTIPO"].Value = Tipo_IDTipo;
                mycommand.Parameters["@IDCIDADE"].Value = Cidade_IDCidade;
                mycommand.Parameters["@NIVELSEVERIDADE"].Value = NivelSeveridade;
                mycommand.Parameters["@AREAAFETADA"].Value = AreaAfetada;
                mycommand.Parameters["@PESSOASAFETADAS"].Value = PessoasAfetadas;
                mycommand.Parameters["@OBSERVACAO"].Value = Observacao;
                mycommand.Parameters["@DATAOCORRENCIA"].Value = DataOcorrencia;
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

                mycommand = new SqlCommand("DELETE FROM Tipo WHERE IDEVENTO = @IDEVENTO", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@IDEVENTO", SqlDbType.Int));
                mycommand.Parameters["@IDEVENTO"].Value = IDEvento;

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
