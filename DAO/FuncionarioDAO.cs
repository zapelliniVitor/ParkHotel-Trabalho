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

        public string inserir(Funcionario func)
        {
            string ConnectionString = Parametros.GetConnectionString();

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
                return "Erro no Bando de Dados, favor contactar o suporte ou admin";
	        }
            finally
            {
                connection.Dispose();
            }
            return "Cadastrado com sucesso";
        }

        public List<Funcionario> LerTodos()
        {
            string ConnectionString = Parametros.GetConnectionString();
            SqlConnection connection =  new SqlConnection();
            connection.ConnectionString = ConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM FUNCIONARIOS";

            command.Connection = connection;
            List<Funcionario> func = new List<Funcionario>();



        }
    }
}
