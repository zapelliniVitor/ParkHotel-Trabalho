using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ReservaDAO
    {
        #region CREATE
        public DbResponse<int> Inserir(Reserva reserva)
        {
            int IdInserida = -1;

            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());
            SqlCommand command = new SqlCommand(connection.ToString());
            command.CommandText = @"INSERT INTO RESERVAS (ID_CLIENTE, DATA_ENTRADA, DATA_SAIDA_PREVISTA, ID_FUNCIONARIO) VALUES
                                  (@ID_CLIENTE, @DATA_ENTRADA, @DATA_SAIDA_PREVISTA, @ID_FUNCIONARIO); select scope_identity()";
            command.Parameters.AddWithValue("ID_CLIENTE", reserva.IdCliente);
            command.Parameters.AddWithValue("DATA_ENTRADA", reserva.dataEntrada);
            command.Parameters.AddWithValue("DATA_SAIDA_PREVISTA", reserva.dataSaidaPrevista);
            command.Parameters.AddWithValue("ID_FUNCIONARIO", reserva.IdFuncionario);

            command.Connection = connection;

            try
            {
                connection.Open();
                IdInserida = Convert.ToInt32(command.ExecuteNonQuery());

            }
            catch (Exception EX)
            {
                if (EX.Message.Contains("UNIQUE") || EX.Message.Contains("FK"))
                {
                    return new DbResponse<int>
                    {
                        Sucesso = false,
                        Mensagem = "Reserva já cadastrada",
                        Excessao = EX
                    };
                }
                return new DbResponse<int>
                {
                    Sucesso = false,
                    Mensagem = "Erro no Bando de Dados, favor contactar o suporte ou admin",
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
                Mensagem = "Reserva cadastrada com sucesso",
                Dados = IdInserida
            };
        }
        #endregion


    }
}
