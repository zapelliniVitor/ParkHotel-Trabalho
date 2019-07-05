using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ProdutoDAO
    {
        #region Atualizar
        public DbResponse<int> Atualizar(Produto prod)
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);

            command.CommandText = @"UPDATE PRODUTOS SET NOME = @NOME, DESCRICAO = @DESCRICAO, PRECOVENDA = @PRECO, ESTOQUE_QUANTIDADES = @ESTOQUE WHERE  ID = " + prod.ID;
            command.Parameters.AddWithValue("@NOME", prod.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", prod.Descricao);
            command.Parameters.AddWithValue("@PRECO", prod.PrecoVenda);
            command.Parameters.AddWithValue("@ESTOQUE", prod.quantidadeEstoque);



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
                Dados = prod.ID,
                Mensagem = "Produto atualizado com sucesso",
                Sucesso = true,
            };
        }
        #endregion

        #region Inserir
        public DbResponse<int> Inserir(Produto prod)
        {
            int IdInserida = -1;

            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = @"INSERT INTO PRODUTOS (NOME, DESCRICAO, PRECOVENDA, ESTOQUE_QUANTIDADES) VALUES
                                  (@NOME, @DESCRICAO, @PRECOVENDA, @ESTOQUE_QUANTIDADES); select scope_identity()";
            command.Parameters.AddWithValue("@NOME", prod.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", prod.Descricao);
            command.Parameters.AddWithValue("@PRECOVENDA", prod.PrecoVenda);
            command.Parameters.AddWithValue("@ESTOQUE_QUANTIDADES", prod.quantidadeEstoque);

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
                        Mensagem = "Produto já cadastrado",
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
                Mensagem = "Produto cadastrado com sucesso",
                Dados = IdInserida
            };
        }
        #endregion

        #region LerPorID
        public List<Produto> LerPorID(int ID)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT * FROM PRODUTOS WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", ID);

            command.Connection = connection;

            List<Produto> list = new List<Produto>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string Nome = (string)reader["NOME"];
                    string descricao = (string)reader["DESCRICAO"];
                    double precoVenda = (double)reader["PRECOVENDA"];
                    int qEstoque = (int)reader["ESTOQUE_QUANTIDADE"];

                    Produto produto = new Produto(id, Nome, descricao, precoVenda, qEstoque);
                    list.Add(produto);
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro no banco de dados, favor contatar suporte.");
            }
            finally
            {
                connection.Dispose();
            }
            return list;
        }
        #endregion

        #region LerTodos
        public DbResponse<List<Produto>> LerTodos()
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "SELECT * FROM PRODUTOS";

            List<Produto> ListProd = new List<Produto>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string nome = (string)reader["NOME"];
                    string Descricao = (string)reader["DESCRICAO"];
                    double Preco = (double)reader["PRECOVENDA"];
                    int Estoque = (int)reader["ESTOQUE_QUANTIDADES"];

                    Produto prod = new Produto(id, nome, Descricao, Preco, Estoque);
                    ListProd.Add(prod);
                }

            }
            catch (Exception ex)
            {
                return new DbResponse<List<Produto>>
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
            return new DbResponse<List<Produto>>
            {
                Sucesso = true,
                Mensagem = "Produtos recebidos",
                Dados = ListProd
            };
        }
        #endregion

        #region Delete
        public DbResponse<int> Delete(int id)
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());
            SqlCommand command = new SqlCommand(connection.ToString());

            command.CommandText = @"DELETE FROM PRODUTOS WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", id);

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
                Mensagem = "Produto excluido com sucesso",
                Sucesso = true,
            };
        }
        #endregion

        #region PesquisarID
        public DbResponse<List<Produto>> PesquisarID(int idPesquisa)
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "SELECT * FROM PRODUTOS WHERE ID LIKE @ID";
            command.Parameters.AddWithValue("@ID", idPesquisa.ToString());
            List<Produto> listPro = new List<Produto>();
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string nome = (string)reader["NOME"];
                    string descricao = (string)reader["DESCRICAO"];
                    double preco = (double)reader["PRECOVENDA"];
                    int estoque = (int)reader["ESTOQUE_QUANTIDADES"];

                    Produto pro = new Produto(id, nome,descricao, preco, estoque);
                    listPro.Add(pro);
                }

            }
            catch (Exception ex)
            {
                return new DbResponse<List<Produto>>
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
            return new DbResponse<List<Produto>>
            {
                Sucesso = true,
                Dados = listPro,
                Mensagem = "Produtos encontrados"
            };
        }
        #endregion

        #region PesqsuiarNome
        public DbResponse<List<Produto>> PesquisarNome(string nomeP)
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "SELECT * FROM PRODUTOS WHERE NOME LIKE @NOME";
            command.Parameters.AddWithValue("@NOME", "%" + nomeP + "%");

            List<Produto> listPro = new List<Produto>();
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string nome = (string)reader["NOME"];
                    string descricao = (string)reader["DESCRICAO"];
                    double preco = (double)reader["PRECOVENDA"];
                    int estoque = (int)reader["ESTOQUE_QUANTIDADES"];

                    Produto pro = new Produto(id, nome, descricao, preco, estoque);
                    listPro.Add(pro);
                }

            }
            catch (Exception ex)
            {
                return new DbResponse<List<Produto>>
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
            return new DbResponse<List<Produto>>
            {
                Sucesso = true,
                Dados = listPro,
                Mensagem = "Produtos encontrados"
            };
        }
        #endregion
    }
}
