using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class FuncionarioDAO 
    {
        #region Atualizar 
        public DbResponse<int> Atualizar(Funcionario func)
        {
            string ConnectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"UPDATE FUNCIONARIOS SET NOME = @NOME, CPF = @CPF, RG = @RG, ENDERECO = @ENDERECO, TELEFONE = @TELEFONE, EMAIL = @EMAIL, SENHA = @SENHA,
                                    EHADMIN = @EHADMIN, EHATIVO = @EHATIVO WHERE  ID = @ID";
            command.Parameters.AddWithValue("@ID", func.ID);
            command.Parameters.AddWithValue("@NOME", func.Nome);
            command.Parameters.AddWithValue("@CPF", func.CPF);
            command.Parameters.AddWithValue("@RG", func.RG);
            command.Parameters.AddWithValue("@ENDERECO", func.Endereco);
            command.Parameters.AddWithValue("@TELEFONE", func.Telefone);
            command.Parameters.AddWithValue("@EMAIL", func.Email);
            command.Parameters.AddWithValue("@SENHA", func.Senha);
            command.Parameters.AddWithValue("@EHADMIN", func.EhAdmin);
            command.Parameters.AddWithValue("@EHATIVO", func.EhAtivo);

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
                Mensagem = "Atualizado com sucesso.",
                Dados = func.ID
            };

        }
        #endregion

        #region Inserir
        public DbResponse<int> Inserir(Funcionario func)
        {
            int idInserida = -1;

            string connectionString = Parametros.GetConnectionString();

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.CommandText = @"INSERT INTO FUNCIONARIOS (NOME, CPF, RG, ENDERECO, TELEFONE, EMAIL, SENHA, EHADMIN, EHATIVO) VALUES
                                  (@NOME, @CPF, @RG, @ENDERECO, @TELEFONE, @EMAIL, @SENHA, @EHADMIN, @EHATIVO); select scope_identity()";
            

            command.Parameters.AddWithValue("@NOME", func.Nome);
            command.Parameters.AddWithValue("@CPF", func.CPF);
            command.Parameters.AddWithValue("@RG", func.RG);
            command.Parameters.AddWithValue("@ENDERECO", func.Endereco);
            command.Parameters.AddWithValue("@TELEFONE", func.Telefone);
            command.Parameters.AddWithValue("@EMAIL", func.Email);
            command.Parameters.AddWithValue("@SENHA", func.Senha);
            command.Parameters.AddWithValue("@EHADMIN", func.EhAdmin);
            command.Parameters.AddWithValue("@EHATIVO", func.EhAtivo);
        
            command.Connection = connection;

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
                        Mensagem = "Funcionario já cadastrado.",
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
                Mensagem = "Funcionário cadastrado com sucesso",
                Dados = idInserida
            };
        }
        #endregion

        #region Delete
        public DbResponse<int> Delete(int id)
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);

            command.CommandText = @"UPDATE FUNCIONARIOS SET EHATIVO = @EHATIVO WHERE  ID = " + id;
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
                Mensagem = "Funcionário desligado com sucesso",
                Sucesso = true,
            };
        }
        #endregion

        #region lerPorID
        public DbResponse<List<Funcionario>> LerPorID(int ID)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT * FROM FUNCIONARIOS WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", ID);

            command.Connection = connection;

            List<Funcionario> listF = new List<Funcionario>();
            
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
                    string Telefone = (string)reader["TELEFONE"];
                    string Email = (string)reader["EMAIL"];
                    bool EhAdmin = (bool)reader["EHADMIN"];
                    bool EhAtivo = (bool)reader["EHADMIN"];

                    Funcionario funcionar = new Funcionario(id, Nome, CPF, RG, Endereco, Telefone, Email, EhAdmin, EhAtivo);
                    listF.Add(funcionar);
                }
            }
            catch (Exception ex)
            {
                return new DbResponse<List<Funcionario>>
                {
                    Sucesso = false,
                    Mensagem = "Erro no banco de dados, favor contatar o suporte.",
                    Excessao = ex
                };
            }
            finally
            {
                connection.Dispose();
            }
            return new DbResponse<List<Funcionario>>
            {
                Sucesso = true,
                Mensagem = "Funcionario encontrado.",
                Dados = listF
            };
        }
        #endregion

        #region lerTodos
        public List<Funcionario> LerTodos()
        {
            string ConnectionString = Parametros.GetConnectionString();
            SqlConnection connection =  new SqlConnection();
            connection.ConnectionString = ConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM FUNCIONARIOS WHERE EHATIVO = 1";

            command.Connection = connection;
            List<Funcionario> listFunc = new List<Funcionario>();
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
                    string Endereco = (string)reader["ENDERECO"];
                    string Telefone = (string)reader["TELEFONE"];
                    string Email = (string)reader["EMAIL"];
                    bool EhAdmin = (bool)reader["EHADMIN"];
                    bool EhAtivo = (bool)reader["EHADMIN"];

                    //Utilizado construtor SEM senha do Funcionario
                    Funcionario funcionar = new Funcionario(id ,nome, CPF, RG, Endereco, Telefone, Email, EhAdmin, EhAtivo);
                    listFunc.Add(funcionar);
	            }

        	}
	        catch (Exception)
	        {
                throw new Exception("Banco de dados indisponivel.");
	        }
            finally
            {
                connection.Dispose();
            }
            return listFunc;
        }
        #endregion

        #region lerPorNome
        public DbResponse<List<Funcionario>> LerPorNome(string nome)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT * FROM FUNCIONARIOS WHERE NOME LIKE '%@NOME%'";
            command.Parameters.AddWithValue("@NOME", nome);

            command.Connection = connection;

            List<Funcionario> listF = new List<Funcionario>();

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
                    string Telefone = (string)reader["TELEFONE"];
                    string Email = (string)reader["EMAIL"];
                    bool EhAdmin = (bool)reader["EHADMIN"];
                    bool EhAtivo = (bool)reader["EHATIVO"];

                    Funcionario funcionar = new Funcionario(id, Nome, CPF, RG, Endereco, Telefone, Email, EhAdmin, EhAtivo);
                    listF.Add(funcionar);
                }
            }
            catch (Exception ex)
            {
                return new DbResponse<List<Funcionario>>
                {
                    Sucesso = false,
                    Mensagem = "Erro no banco de dados, favor contatar o suporte.",
                    Excessao = ex
                };
            }
            finally
            {
                connection.Dispose();
            }
            return new DbResponse<List<Funcionario>>
            {
                Sucesso = true,
                Mensagem = "Funcionario encontrado.",
                Dados = listF
            };
        }
        #endregion

        #region lerPorCpf
        public DbResponse<List<Funcionario>> LerPorCPF(string cpf)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT * FROM FUNCIONARIOS WHERE CPF = @CPF";
            command.Parameters.AddWithValue("@CPF", cpf);

            command.Connection = connection;

            List<Funcionario> listF = new List<Funcionario>();

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
                    string Telefone = (string)reader["TELEFONE"];
                    string Email = (string)reader["EMAIL"];
                    bool EhAdmin = (bool)reader["EHADMIN"];
                    bool EhAtivo = (bool)reader["EHATIVO"];

                    Funcionario funcionar = new Funcionario(id, Nome, CPF, RG, Endereco, Telefone, Email, EhAdmin, EhAtivo);
                    listF.Add(funcionar);
                }
            }
            catch (Exception ex)
            {
                return new DbResponse<List<Funcionario>>
                {
                    Sucesso = false,
                    Mensagem = "Erro no banco de dados, favor contatar o suporte.",
                    Excessao = ex
                };
            }
            finally
            {
                connection.Dispose();
            }
            return new DbResponse<List<Funcionario>>
            {
                Sucesso = true,
                Mensagem = "Funcionario encontrado.",
                Dados = listF
            };
        }
        #endregion

    }
}
