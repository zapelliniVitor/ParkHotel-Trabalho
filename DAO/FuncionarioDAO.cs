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
        //Pronto 
        public string Atualizar(Funcionario func)
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
            catch (Exception)
            {
                return "Erro no banco de dados, contate o admin";
            }
            finally
            {
                connection.Dispose();
            }
            return "Funcionário atualizado";

        }

        //Pronto
        public string Inserir(Funcionario func)
        {
            string connectionString = Parametros.GetConnectionString();

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.CommandText = @"INSERT INTO FUNCIONARIOS (NOME, CPF, RG, ENDERECO, TELEFONE, EMAIL, SENHA, EHADMIN, EHATIVO) VALUES
                                  (@NOME, @CPF, @RG, @ENDERECO, @TELEFONE, @EMAIL, @SENHA, @EHADMIN, @EHATIVO)";
            

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
	        catch (Exception EX)
	        {
                if (EX.Message.Contains("UNIQUE") || EX.Message.Contains("FK"))
                {
                    return "Funcionário já cadastrado";
                }
                return "Erro no Bando de Dados, favor contactar o suporte";
	        }
            finally
            {
                connection.Dispose();
            }
            return "Funcionário cadastrado com sucesso";
        }

        public string Delete(Funcionario func)
        {
            string connectionString = Parametros.GetConnectionString();

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.CommandText = @"DELETE FROM FUNCIONARIOS WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", func.ID);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return "Erro no banco de dados, contate o suporte";
                
            }
            finally
            {
                connection.Dispose();
            }
            return "Funcionario apagado do sistema com sucesso";
        }

        //Pronto VERIFICAR
        public Funcionario LerPorID(int ID)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT FROM FUNCIONARIOS WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", ID);

            command.Connection = connection;

            int id = 0;
            string nome = "";
            string CPF = "";
            string RG = "";
            string Endereco = "";
            string Telefone = "";
            string Email = "";
            bool EhAdmin = false;
            bool EhAtivo = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = (int)reader["ID"];
                    nome = (string)reader["NOME"];
                    CPF = (string)reader["CPF"];
                    RG = (string)reader["RG"];
                    Endereco = (string)reader["ENDERECO"];
                    Telefone = (string)reader["TELEFONE"];
                    Email = (string)reader["EMAIL"];
                    EhAdmin = (bool)reader["EHADMIN"];
                    EhAtivo = (bool)reader["EHADMIN"];

                    //Utilizado construtor SEM senha do Funcionario
                    
                }
            }
            catch (Exception)
            {
                
            }
            finally
            {
                connection.Dispose();
            }
            Funcionario funcionar = new Funcionario(id, nome, CPF, RG, Endereco, Telefone, Email, EhAdmin, EhAtivo);

            return funcionar;
        }
        
        //Pronto
        public List<Funcionario> LerTodos()
        {
            string ConnectionString = Parametros.GetConnectionString();
            SqlConnection connection =  new SqlConnection();
            connection.ConnectionString = ConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM FUNCIONARIOS";

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
        		
	        }
            finally
            {
                connection.Dispose();
            }
            return listFunc;

        }

        
    }
}
