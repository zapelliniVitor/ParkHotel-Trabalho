using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class FornecedorDAO
    {
        #region Inserir
        public DbResponse<int> Inserir(Fornecedor f)
        {
            int idInserida = -1;

            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(connectionString);

            command.CommandText = @"INSERT INTO FORNECEDORES (RAZAOSOCIAL, CNPJ, NOMECONTATO, TELEFONE, EMAIL) VALUES
                                  (@RAZAOSOCIAL, @CNPJ, @NOMECONTATO, @TELEFONE, @EMAIL); select scope_identity()";
            command.Parameters.AddWithValue("@RAZAOSOCIAL", f.RazaoSocial);
            command.Parameters.AddWithValue("@CNPJ", f.CNPJ);
            command.Parameters.AddWithValue("@NOMECONTATO", f.NomeContato);
            command.Parameters.AddWithValue("@TELEFONE", f.Telefone);
            command.Parameters.AddWithValue("@EMAIL", f.Email);

            command.Connection = connection;

            try
            {
                connection.Open();
                idInserida = command.ExecuteNonQuery();

            }
            catch (Exception EX)
            {
                if (EX.Message.Contains("UNIQUE") || EX.Message.Contains("FK"))
                {
                    return new DbResponse<int>
                    {
                        Sucesso = false,
                        Mensagem = "Fornecedor já cadastrado",
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
                Mensagem = "Fornecedor cadastrado com sucesso",
                Dados = idInserida
            };
        }
        #endregion

        #region LerTodos
        public DbResponse<List<Fornecedor>> LerTodos()
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("",connection);
            command.CommandText = "SELECT * FROM FORNECEDORES";

            List<Fornecedor> listF = new List<Fornecedor>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string razaoSocial = (string)reader["RAZAOSOCIAL"];
                    string cnpj = (string)reader["CNPJ"];
                    string nomeContato = (string)reader["NOMECONTATO"];
                    string Telefone = (string)reader["TELEFONE"];
                    string Email = (string)reader["EMAIL"];

                    Fornecedor f = new Fornecedor(id,nomeContato, razaoSocial, cnpj,  Telefone, Email);
                    listF.Add(f);
                }

            }
            catch (Exception ex)
            {
                return new DbResponse<List<Fornecedor>>
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
            return new DbResponse<List<Fornecedor>>
            {
                Sucesso = true,
                Mensagem = "Fornecedores recebidos",
                Dados = listF
            };
        }
        #endregion

        #region LerPorID
        public List<Fornecedor> LerPorID(int ID)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT * FROM FORNECEDOR WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", ID);

            command.Connection = connection;

            List<Fornecedor> list = new List<Fornecedor>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string razaoSocial = (string)reader["RAZAOSOCIAL"];
                    string cnpj = (string)reader["CNPJ"];
                    string nomeContato = (string)reader["NOMECONTATO"];
                    string Telefone = (string)reader["TELEFONE"];
                    string Email = (string)reader["EMAIL"];

                    Fornecedor fornecedor = new Fornecedor(id, nomeContato, razaoSocial, cnpj, Telefone, Email);
                    list.Add(fornecedor);
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro no banco de dados, favor contate o suporte");
            }
            finally
            {
                connection.Dispose();
            }
            return list;
        }
        #endregion

        #region Atualizar
        public DbResponse<int> Atualizar(Fornecedor f)
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);

            command.CommandText = @"UPDATE FORNECEDORES SET RAZAOSOCIAL = @RAZAOSOCIAL, CNPJ = @CNPJ, NOMECONTATO = @NOMECONTATO ,TELEFONE = @TELEFONE, EMAIL = @EMAIL WHERE  ID = @ID";
            command.Parameters.AddWithValue("@RAZAOSOCIAL", f.RazaoSocial);
            command.Parameters.AddWithValue("@CNPJ", f.CNPJ);
            command.Parameters.AddWithValue("@NOMECONTATO", f.NomeContato);
            command.Parameters.AddWithValue("@TELEFONE", f.Telefone);
            command.Parameters.AddWithValue("@EMAIL", f.Email);
            command.Parameters.AddWithValue("@ID", f.ID);

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
                Dados = f.ID,
                Mensagem = "Fornecedor atualizado com sucesso",
                Sucesso = true,
            };
        }
        #endregion

        #region Delete
        public DbResponse<int> Delete(int id)
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand(connection.ToString());

            command.CommandText = @"UPDATE FORNECEDORES SET EHATIVO = @EHATIVO WHERE  ID = " + id;
            command.Parameters.AddWithValue("@EHATIVO", false);

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
                Mensagem = "Fornecedor desligado com sucesso",
                Sucesso = true,
            };
        }
        #endregion

        #region PesquisarID
        public DbResponse<List<Fornecedor>> PesquisarID(int idPesquisa)
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "SELECT * FROM FORNECEDORES WHERE ID LIKE @ID";
            command.Parameters.AddWithValue("@ID", idPesquisa.ToString() + "%");

            List<Fornecedor> listFor = new List<Fornecedor>();
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string razao = (string)reader["RAZAOSOCIAL"];
                    string cnpj = (string)reader["CNPJ"];
                    string nome = (string)reader["NOMECONTATO"];
                    string Telefone = (string)reader["TELEFONE"];
                    string Email = (string)reader["EMAIL"];

                    Fornecedor forn = new Fornecedor(id,nome,razao, cnpj, Telefone, Email);
                    listFor.Add(forn);
                }

            }
            catch (Exception ex)
            {
                return new DbResponse<List<Fornecedor>>
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
            return new DbResponse<List<Fornecedor>>
            {
                Sucesso = true,
                Dados = listFor,
                Mensagem = "Fornecedors encontrados"
            };
        }
        #endregion

        #region PesqsuiarNome
        public DbResponse<List<Fornecedor>> PesquisarNome(string nomeP)
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "SELECT * FROM FORNECEDORES WHERE NOMECONTATO LIKE @NOME";
            command.Parameters.AddWithValue("@NOME", "%" + nomeP + "%");

            List<Fornecedor> listFor = new List<Fornecedor>();
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string razao = (string)reader["RAZAOSOCIAL"];
                    string cnpj = (string)reader["CNPJ"];
                    string nome = (string)reader["NOMECONTATO"];
                    string Telefone = (string)reader["TELEFONE"];
                    string Email = (string)reader["EMAIL"];

                    Fornecedor forn = new Fornecedor(id, nome, razao, cnpj, Telefone, Email);
                    listFor.Add(forn);
                }

            }
            catch (Exception ex)
            {
                return new DbResponse<List<Fornecedor>>
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
            return new DbResponse<List<Fornecedor>>
            {
                Sucesso = true,
                Dados = listFor,
                Mensagem = "Fornecedors encontrados"
            };
        }
        #endregion

        #region PesqsuiarCNPJ
        public DbResponse<List<Fornecedor>> PesquisarCNPJ(string CNPJ1)
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "SELECT * FROM FORNECEDORES WHERE CNPJ LIKE @CNPJ";
            command.Parameters.AddWithValue("@CNPJ", CNPJ1 + "%");


            List<Fornecedor> listFor = new List<Fornecedor>();
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string razao = (string)reader["RAZAOSOCIAL"];
                    string cnpj = (string)reader["CNPJ"];
                    string nome = (string)reader["NOMECONTATO"];
                    string Telefone = (string)reader["TELEFONE"];
                    string Email = (string)reader["EMAIL"];

                    Fornecedor forn = new Fornecedor(id, nome, razao, cnpj, Telefone, Email);
                    listFor.Add(forn);
                }

            }
            catch (Exception ex)
            {
                return new DbResponse<List<Fornecedor>>
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
            return new DbResponse<List<Fornecedor>>
            {
                Sucesso = true,
                Dados = listFor,
                Mensagem = "Fornecedors encontrados"
            };
        }
        #endregion
    }
}
              


    




