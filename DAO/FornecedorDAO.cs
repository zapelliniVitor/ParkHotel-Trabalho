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

            command.CommandText = @"INSERT INTO FUNCIONARIOS (RAZAOSOCIAL, CNPJ, NOMECONTATO, TELEFONE, EMAIL) VALUES
                                  (@RAZAOSOCIAL, @CNPJ, @NOMECONTATO, @TELEFONE, @EMAIL); select scope_identity()";
            command.Parameters.AddWithValue("@RAZAOSOCIAL", f.RazaoSocial);
            command.Parameters.AddWithValue("@CNPJ", f.CNPJ);
            command.Parameters.AddWithValue("@NOMECONTATO", f.NomeContato);
            command.Parameters.AddWithValue("@TELEFONE", f.Telefone);
            command.Parameters.AddWithValue("@EMAIL", f.Email);

            try
            {
                connection.Open();
                idInserida = Convert.ToInt32(command.ExecuteNonQuery());

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
        public DbResponse<Fornecedor> LerPorID(int ID)
        {

            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand(connection.ToString());
            command.CommandText = "SELECT * FROM FORNECEDORES WHERE ID = @ID";

            command.Parameters.AddWithValue("@ID", ID);

            Fornecedor f = new Fornecedor();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    f.ID = (int)reader["ID"];
                    f.RazaoSocial = (string)reader["RAZAOSOCIAL"];
                    f.CNPJ = (string)reader["CNPJ"];
                    f.NomeContato = (string)reader["NOMECONTATO"];
                    f.Telefone = (string)reader["TELEFONE"];
                    f.Email = (string)reader["EMAIL"];
                    return new DbResponse<Fornecedor>
                    {
                        Sucesso = true,
                        Mensagem = "Fornecedor encontrado",
                        Dados = f
                    };
                }
            }
            catch (Exception ex)
            {
                return new DbResponse<Fornecedor>
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
            return new DbResponse<Fornecedor>
            {
                Sucesso = false,
                Mensagem = "fornecedor não encontrado.",
            };
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

    }
}
              


    




