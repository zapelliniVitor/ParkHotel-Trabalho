using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Check_inDAO
    {
        #region Inserir
        public DbResponse<int> Inserir(Check_in chk)
        {
            int idInserida = -1;

            string connectionString = Parametros.GetConnectionString();

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.CommandText = @"INSERT INTO CHECK_INS (ID_RESERVA, DATA_ENTRADA, DATA_SAIDA_PREVISTA, ID_CLIENTE, ID_FUNC) VALUES
                                  (@ID_RESERVA, @DATA_ENTRADA, @DATA_SAIDA_PREVISTA, @ID_CLIENTE, @ID_FUNC); select scope_identity()";

            command.Parameters.AddWithValue("@ID_RESERVA", chk.id_reserva);
            command.Parameters.AddWithValue("@DATA_ENTRADA", chk.dataEntrada);
            command.Parameters.AddWithValue("@DATA_SAIDA_PREVISTA", chk.dataSaidaPrevista);
            command.Parameters.AddWithValue("@ID_CLIENTE", chk.id_cliente);
            command.Parameters.AddWithValue("@ID_FUNC", chk.id_func);


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
                        Mensagem = "Check - in já efetuado.",
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
                Mensagem = "Check - in efetuado com sucesso",
                Dados = idInserida
            };
        }
        #endregion

        #region lerTodos
        public List<Check_in> LerTodos()
        {
            string ConnectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM CHECK_INS";

            command.Connection = connection;
            List<Check_in> list = new List<Check_in>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    int idR = 0;
                    if ((idR = (int)reader["ID_RESERVA"]) != 0)
                    {
                        idR = (int)reader["ID_RESERVA"];
                    }
                    DateTime entrada = (DateTime)reader["DATA_ENTRADA"];
                    DateTime saida = (DateTime)reader["DATA_SAIDA_PREVISTA"];
                    int idC = (int)reader["ID_CLIENTE"];
                    int idF = (int)reader["ID_FUNC"];
                    int idQ = 0;
                    if ((idQ = (int)reader["ID_QUARTO"]) != 0)
                    {
                        idQ = (int)reader["ID_QUARTO"];
                    }

                    Check_in check = new Check_in(id, idR, entrada, saida, idC, idF, idQ);
                    list.Add(check);
                }

            }
            catch (Exception ex)
            {
                    
            }
            finally
            {
                connection.Dispose();
            }
            return list;
        }
        #endregion
    }
}
