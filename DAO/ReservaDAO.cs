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
            command.CommandText = @"INSERT INTO RESERVAS (ID_CLIENTES, DATA_ENTRADA, DATA_SAIDA_PREVISTA, ID_FUNCIONARIO) VALUES
                                  (@ID_CLIENTE, @DATA_ENTRADA, @DATA_SAIDA_PREVISTA, @ID_FUNCIONARIO); select scope_identity();";
                                    
            command.Parameters.AddWithValue("@ID_CLIENTE", reserva.IdCliente);
            command.Parameters.AddWithValue("@DATA_ENTRADA", reserva.dataEntrada);
            command.Parameters.AddWithValue("@DATA_SAIDA_PREVISTA", reserva.dataSaidaPrevista);
            command.Parameters.AddWithValue("@ID_FUNCIONARIO", reserva.IdFuncionario);
            command.Parameters.AddWithValue("@ID_QUARTO", reserva.IdQuarto);


            command.Connection = connection;

            try
            {
                connection.Open();
                IdInserida = Convert.ToInt32(command.ExecuteNonQuery());
                command.CommandText = @"INSERT INTO RESERVAS_QUARTOS (ID_RESERVAS, ID_QUARTO) VALUES
                                        (@ID_RESERVAS, @ID_QUARTO)";
                command.Parameters.AddWithValue("@ID_QUARTO", reserva.IdQuarto);
                command.ExecuteNonQuery();

            }
            catch (Exception EX)
            {
                if (EX.Message.Contains("UNIQUE"))
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

        #region UPDATE 
        public DbResponse<int> Atualizar(Reserva r)
        {
            string ConnectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"UPDATE RESERVAS SET ID_CLIENTES = @ID_CLIENTES, DATA_ENTRADA = @DATA_ENTRADA, DATA_SAIDA_PREVISTA = @DATA_SAIDA_PREVISTA,
                                    ID_FUNCIONARIO = @ID_FUNCIONARIO, ID_QUARTO = @ID_QUARTO WHERE  ID = @ID";
            command.Parameters.AddWithValue("@ID_CLIENTES", r.IdCliente);
            command.Parameters.AddWithValue("@DATA_ENTRADA", r.dataEntrada);
            command.Parameters.AddWithValue("@DATA_SAIDA_PREVISTA", r.dataSaidaPrevista);
            command.Parameters.AddWithValue("@ID_FUNCIONARIO", r.IdFuncionario);
            command.Parameters.AddWithValue("@ID_QUARTO", r.IdQuarto);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return new DbResponse<int>
                {
                    Excessao = ex,
                    Mensagem = "Banco de dados indisponivel.",
                    Sucesso = false
                };
            }
            finally
            {
                connection.Dispose();
            }
            return new DbResponse<int>
            {
                Sucesso = true,
                Mensagem = "Reserva atualizada com sucesso.",
                Dados = r.ID
            };

        }
        #endregion

        #region DELETE
        public DbResponse<int> Delete(int id)
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);

            command.CommandText = @"DELETE FROM RESERVAS WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", id);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return new DbResponse<int>
                {
                    Excessao = ex,
                    Mensagem = "Banco de dados indisponível",
                    Sucesso = false,
                };
            }
            finally
            {
                connection.Dispose();
            }
            return new DbResponse<int>
            {
                Dados = id,
                Mensagem = "Reserva cancelada com sucesso",
                Sucesso = true,
            };
        }
        #endregion

        #region ReadAll
        public List<Reserva> LerTodos()
        {
            string ConnectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM RESERVAS";

            command.Connection = connection;
            List<Reserva> list = new List<Reserva>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    int idCliente = (int)reader["ID_CLIENTES"];
                    DateTime entrada = (DateTime)reader["DATA_ENTRADA"];
                    DateTime saidaP = (DateTime)reader["DATA_SAIDA_PREVISTA"];
                    int idF = (int)reader["ID_FUNCIONARIO"];
                    int idQ = (int)reader["ID_QUARTO"];

                    Reserva rsv = new Reserva(id, idCliente, entrada, saidaP, idF, idQ);
                    list.Add(rsv);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Banco de dados indisponivel.");
            }
            finally
            {
                connection.Dispose();
            }
            return list;
        }
        #endregion

        /*public List<ReservaViewModel> LerViewModels()
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = @"
                        SELECT R.ID 'Reserva',
                               C.ID 'IDCliente',
                               C.Nome 'NomeCliente',
                               F.ID 'Funcionario',
                               F.Nome 'NomeFuncionario',
                               R.Data_ENTRADA 'DataEntrada',
                               R.DATA_SAIDA_PREVISTA 'DataSaidaPrevista',
                               Q.ID 'IDQuarto',
                               Q.N_QUARTO 'Quarto'
                        FROM RESERVAS R INNER JOIN CLIENTES C ON 
                                            R.ID_CLIENTES = C.ID
                                        INNER JOIN FUNCIONARIOS F ON
                                            F.ID = R.ID_FUNCIONARIO
                                        INNER JOIN QUARTOS Q ON
                                            Q.ID = R.ID_QUARTO";
            List<ReservaViewModel> listReserva = new List<ReservaViewModel>();
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ReservaViewModel viewModel = new ReservaViewModel();
                    Cliente c = new Cliente()
                    {
                        ID = (int)reader["IDCliente"],
                        Nome = (string)reader["NomeCliente"]
                    };

                    Funcionario f = new Funcionario((int)reader["Funcionario"]);
                    f.Nome = (string)reader["NomeFuncionario"];
                    viewModel.ID = (int)reader["Reserva"];
                    viewModel.DataPrevistaEntrada = (DateTime)reader["DataEntrada"];
                    viewModel.DataPrevistaSaida = (DateTime)reader["DataSaidaPrevista"];
                    viewModel.Cliente = c;
                    viewModel.Funcionario = f;
                    listReserva.Add(viewModel);
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Dispose();
            }
            return listReserva;
        }*/
    }
}
