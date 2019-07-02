using Metadata;
using Metadata.ViewModel;
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
            command.CommandText = @"INSERT INTO RESERVAS (ID_CLIENTE, DATA_ENTRADA, DATA_SAIDA_PREVISTA, ID_FUNCIONARIO, ID_QUARTO) VALUES
                                  (@ID_CLIENTE, @DATA_ENTRADA, @DATA_SAIDA_PREVISTA, @ID_FUNCIONARIO, @ID_QUARTO); select scope_identity()";
            command.Parameters.AddWithValue("ID_CLIENTE", reserva.IdCliente);
            command.Parameters.AddWithValue("DATA_ENTRADA", reserva.dataEntrada);
            command.Parameters.AddWithValue("DATA_SAIDA_PREVISTA", reserva.dataSaidaPrevista);
            command.Parameters.AddWithValue("ID_FUNCIONARIO", reserva.IdFuncionario);
            command.Parameters.AddWithValue("ID_QUARTO", reserva.IdQuarto);


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

        #region LerTodos
        public List<Reserva> LerTodosReservas()
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "SELECT * FROM RESERVAS";

            List<Reserva> listCli = new List<Reserva>();
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    int cliente = (int)reader["ID_CLIENTES"];
                    DateTime dataEntrada = (DateTime)reader["DATA_ENTRADA"];
                    DateTime dataSaida = (DateTime)reader["DATA_SAIDA_PREVISTA"];
                    int funcionario = (int)reader["ID_FUNCIONARIO"];

                    Reserva cli = new Reserva(id, cliente, dataEntrada, dataSaida, funcionario, 0);
                    listCli.Add(cli);
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Dispose();
            }
            return listCli;
        }
        #endregion

        #region reservaViewModel
        public List<ReservaViewModel> LerViewModels()
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
                               R.DATA_SAIDA_PREVISTA 'DataSaidaPrevista'
                        FROM RESERVAS R INNER JOIN CLIENTES C ON 
                                            R.ID_CLIENTES = C.ID
                                        INNER JOIN FUNCIONARIOS F ON
                                            F.ID = R.ID_FUNCIONARIO";
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
        }
        #endregion

        #region MagiaNegra
        public List<ReservaViewModel> LerTudo()
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
                               R.DATA_SAIDA_PREVISTA 'DataSaidaPrevista'
                        FROM RESERVAS R INNER JOIN CLIENTES C ON 
                                            R.ID_CLIENTES = C.ID
                                        INNER JOIN FUNCIONARIOS F ON
                                            F.ID = R.ID_FUNCIONARIO";
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
        }
        #endregion
    }
}
