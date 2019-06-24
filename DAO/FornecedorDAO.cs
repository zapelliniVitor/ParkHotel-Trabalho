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

            SqlCommand command = new SqlCommand(connection.ToString());
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

                    Fornecedor f = new Fornecedor(id, razaoSocial, cnpj, nomeContato, Telefone, Email);
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

            SqlCommand command = new SqlCommand(connection.ToString());

            command.CommandText = @"UPDATE FORNECEDORES SET RAZAOSOCIAL = @RAZAOSOCIAL, CNPJ = @CNPJ, NOMECONTATO = @NOMECONTATO ,TELEFONE = @TELEFONE1, EMAIL = @EMAIL WHERE  ID = " + f.ID;
            command.Parameters.AddWithValue("@NOME", f.RazaoSocial);
            command.Parameters.AddWithValue("@CPF", f.CNPJ);
            command.Parameters.AddWithValue("@NOMECONTATO", f.NomeContato);
            command.Parameters.AddWithValue("@TELEFONE1", f.Telefone);
            command.Parameters.AddWithValue("@EMAIL", f.Email);

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
                Mensagem = "Fornecedor" +
                " atualizado com sucesso",
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


    }
}
              


    




