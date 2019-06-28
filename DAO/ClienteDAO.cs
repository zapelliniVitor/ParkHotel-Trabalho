using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;

namespace DAO
{
    public class ClienteDAO
    {
        #region Atualizar
        public DbResponse<int> Atualizar(Cliente cli)
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);

            command.CommandText = @"UPDATE CLIENTES SET NOME = @NOME, CPF = @CPF, RG = @RG, TELEFONE1 = @TELEFONE1, TELEFONE2 = @TELEFONE2, EMAIL = @EMAIL, EHATIVO = @EHATIVO WHERE  ID = " + cli.ID;
            command.Parameters.AddWithValue("@NOME", cli.Nome);
            command.Parameters.AddWithValue("@CPF", cli.CPF);
            command.Parameters.AddWithValue("@RG", cli.RG);
            command.Parameters.AddWithValue("@TELEFONE1", cli.Telefone1);
            command.Parameters.AddWithValue("@TELEFONE2", cli.Telefone2);
            command.Parameters.AddWithValue("@EMAIL", cli.Email);
            command.Parameters.AddWithValue("@EHATIVO", cli.EhAtivo);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return new DbResponse<int> {
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
                Dados = cli.ID,
                Mensagem = "Cliente atualizado com sucesso",
                Sucesso = true,
            };
        }
        #endregion

        #region Inserir
        public DbResponse<int> Inserir(Cliente cli)
        {
            int IdInserida = -1;

            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = @"INSERT INTO CLIENTES (NOME, CPF, RG, TELEFONE1, TELEFONE2, EMAIL, EHATIVO) VALUES
                                  (@NOME, @CPF, @RG,  @TELEFONE1, @TELEFONE2, @EMAIL, @EHATIVO); select scope_identity()";
            command.Parameters.AddWithValue("@NOME", cli.Nome);
            command.Parameters.AddWithValue("@CPF", cli.CPF);
            command.Parameters.AddWithValue("@RG", cli.RG);
            command.Parameters.AddWithValue("@TELEFONE1", cli.Telefone1);
            command.Parameters.AddWithValue("@TELEFONE2", cli.Telefone2);
            command.Parameters.AddWithValue("@EMAIL", cli.Email);
            command.Parameters.AddWithValue("@EHATIVO", cli.EhAtivo);

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
                        Mensagem = "Cliente já cadastrado",
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
                Mensagem = "Cliente cadastrado com sucesso",
                Dados = IdInserida
            };
        }
        #endregion

        #region LerPorID
        public DbResponse<List<Cliente>> LerPorID(int ID)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT * FROM CLIENTES WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", ID);

            command.Connection = connection;

            List<Cliente> listCli = new List<Cliente>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string Nome = (string)reader["NOME"];
                    string CPF = (string)reader["CPF"];
                    string RG = (string)reader["RG"];
                    string Endereco = (string)reader["ENDERECO"];
                    string Telefone1 = (string)reader["TELEFONE1"];
                    string Telefone2 = (string)reader["TELEFONE2"];
                    string Email = (string)reader["EMAIL"];
                    bool EhAtivo = (bool)reader["EHADMIN"];

                    Cliente cliente = new Cliente(id, Nome, CPF, RG, Telefone1, Telefone2, Email, EhAtivo);
                    listCli.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                return new DbResponse<List<Cliente>>
                {
                    Sucesso = false,
                    Excessao = ex,
                    Mensagem = "Cliente não encontrado"
                };
            }
            finally
            {
                connection.Dispose();
            }
            return new DbResponse<List<Cliente>>
            {
                Sucesso = true,
                Mensagem = "Cliente encontrado",
                Dados = listCli
            };
        }
        #endregion

        #region LerTodosInativos
        public DbResponse<List<Cliente>> LerTodosInativos()
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "SELECT * FROM CLIENTES WHERE EHATIVO = 0";

            List<Cliente> listCli = new List<Cliente>();
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string nome = (string)reader["NOME"];
                    string CPF = (string)reader["CPF"];
                    string RG = (string)reader["RG"];
                    string Telefone1 = (string)reader["TELEFONE1"];
                    string Telefone2 = (string)reader["TELEFONE2"];
                    string Email = (string)reader["EMAIL"];
                    bool EhAtivo = (bool)reader["EHATIVO"];

                    Cliente cli = new Cliente(id, nome, CPF, RG, Telefone1, Telefone2, Email, EhAtivo);
                    listCli.Add(cli);
                }

            }
            catch (Exception ex)
            {
                return new DbResponse<List<Cliente>>
                {
                    Sucesso = false,
                    Mensagem = "Banco de dados indisponível",
                    Excessao = ex
                };
            }
            finally
            {
                connection.Dispose();
            }
            return new DbResponse<List<Cliente>>
            {
                Sucesso = true,
                Mensagem = "Clientes recebidos",
                Dados = listCli
            };
        }
        #endregion

        #region LerTodos
        public List<Cliente> LerTodos()
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "SELECT * FROM CLIENTES WHERE EHATIVO = 1";

            List<Cliente> listCli = new List<Cliente>();
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string nome = (string)reader["NOME"];
                    string CPF = (string)reader["CPF"];
                    string RG = (string)reader["RG"];
                    string Telefone1 = (string)reader["TELEFONE1"];
                    string Telefone2 = (string)reader["TELEFONE2"];
                    string Email = (string)reader["EMAIL"];
                    bool EhAtivo = (bool)reader["EHATIVO"];

                    Cliente cli = new Cliente(id, nome, CPF, RG, Telefone1, Telefone2, Email, EhAtivo);
                    listCli.Add(cli);
                }

            }
            catch (Exception )
            {
              
            }
            finally
            {
                connection.Dispose();
            }
            return listCli;
        }
        #endregion

        #region Excluir
        public DbResponse<int> Excluir(int id)
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand(connection.ToString());

            command.CommandText = @"UPDATE CLIENTES SET EHATIVO = @EHATIVO WHERE  ID = " + id;
            command.Parameters.AddWithValue("@EHATIVO", 0);

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
                Mensagem = "Cliente desligado com sucesso",
                Sucesso = true,
            };
        }
        #endregion

        #region PesqsuiarID
        public DbResponse<List<Cliente>> PesqusiarID(int idPesquisa)
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "SELECT * FROM CLIENTES WHERE ID LIKE '%" + idPesquisa.ToString() + "%'";

            List<Cliente> listCli = new List<Cliente>();
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string nome = (string)reader["NOME"];
                    string CPF = (string)reader["CPF"];
                    string RG = (string)reader["RG"];
                    string Telefone1 = (string)reader["TELEFONE1"];
                    string Telefone2 = (string)reader["TELEFONE2"];
                    string Email = (string)reader["EMAIL"];
                    bool EhAtivo = (bool)reader["EHATIVO"];

                    Cliente cli = new Cliente(id, nome, CPF, RG, Telefone1, Telefone2, Email, EhAtivo);
                    listCli.Add(cli);
                }

            }
            catch (Exception ex)
            {
                return new DbResponse<List<Cliente>>
                {
                    Sucesso = false,
                    Excessao = ex,
                    Mensagem = "Banco de dados indisponível"
                };
            }
            finally
            {
                connection.Dispose();
            }
            return new DbResponse<List<Cliente>>
            {
                Sucesso = true,
                Dados = listCli,
                Mensagem = "Clientes encontrados"
            };
        }
        #endregion

        #region PesqsuiarNome
        public DbResponse<List<Cliente>> PesqusiarNome(string nomeP)
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "SELECT * FROM CLIENTES WHERE NOME LIKE '%" + nomeP + "%'";

            List<Cliente> listCli = new List<Cliente>();
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string nome = (string)reader["NOME"];
                    string CPF = (string)reader["CPF"];
                    string RG = (string)reader["RG"];
                    string Telefone1 = (string)reader["TELEFONE1"];
                    string Telefone2 = (string)reader["TELEFONE2"];
                    string Email = (string)reader["EMAIL"];
                    bool EhAtivo = (bool)reader["EHATIVO"];

                    Cliente cli = new Cliente(id, nome, CPF, RG, Telefone1, Telefone2, Email, EhAtivo);
                    listCli.Add(cli);
                }

            }
            catch (Exception ex)
            {
                return new DbResponse<List<Cliente>>
                {
                    Sucesso = false,
                    Excessao = ex,
                    Mensagem = "Banco de dados indisponível"
                };
            }
            finally
            {
                connection.Dispose();
            }
            return new DbResponse<List<Cliente>>
            {
                Sucesso = true,
                Dados = listCli,
                Mensagem = "Clientes encontrados"
            };
        }
        #endregion


    }
}
