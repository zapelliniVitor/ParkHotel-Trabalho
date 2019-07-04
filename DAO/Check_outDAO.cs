using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Check_outDAO
    {
        #region Inserir
        public DbResponse<int> Inserir(Check_out chk)
        {
            int idInserida = -1;

            string connectionString = Parametros.GetConnectionString();

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.CommandText = @"INSERT INTO CHECK_OUTS (ID_CHECK_IN, ID_FUNC, VALOR_TOTAL, DATA_SAIDA) VALUES
                                  (@ID_CHECK_IN, @ID_FUNC, @VALOR_TOTAL, @DATA_SAIDA); select scope_identity()";

            command.Parameters.AddWithValue("@ID_CHECK_IN", chk.id_Check_In);
            command.Parameters.AddWithValue("@ID_FUNC", chk.id_Func);
            command.Parameters.AddWithValue("@VALOR_TOTAL", chk.valor_total);
            command.Parameters.AddWithValue("@DATA_SAIDA", chk.dataSaida);

            command.Connection = connection;

            try
            {
                connection.Open();
                idInserida = Convert.ToInt32(command.ExecuteNonQuery());

            }
            catch (Exception EX)
            {
                if (EX.Message.Contains("UNIQUE"))
                {
                    return new DbResponse<int>
                    {
                        Sucesso = false,
                        Mensagem = "Check-out já efetuado.",
                        Excessao = EX

                    };
                }
                return new DbResponse<int>
                {

                    Sucesso = false,
                    Mensagem = "Erro no Bando de Dados, favor contactar o suporte",
                    Excessao = EX
                };
            }
            finally
            {
                connection.Dispose();
            }
            return new DbResponse<int>
            {
                Sucesso = true,
                Mensagem = "Check-out efetuado com sucesso",
                Dados = idInserida
            };
        }
        #endregion



    }
}
