using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoginDAO
    {
        public DbResponse<FuncionarioLogado> Autenticar(string email, string senha)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT * FROM FUNCIONARIOS WHERE EMAIL = @EMAIL AND SENHA = @SENHA";
            command.Parameters.AddWithValue("@EMAIL", email);
            command.Parameters.AddWithValue("@SENHA", senha);


            command.Connection = connection;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    int id = (int)reader["ID"];
                    string Nome = (string)reader["NOME"];
                    string Email = (string)reader["EMAIL"];
                    bool EhAdmin = (bool)reader["EHADMIN"];
                    bool EhAtivo = (bool)reader["EHADMIN"];

                    FuncionarioLogado funclog = new FuncionarioLogado();

                    funclog.id = id;
                    funclog.nome = Nome;
                    funclog.email = Email;
                    if (!EhAtivo)
                    {
                        funclog.level = -1;
                    }
                    else
                    {
                        if (!EhAdmin)
                        {
                            funclog.level = 0;
                        }
                        else
                        {
                            funclog.level = 1;
                        }
                    }
                    Parametros.Funcionario = funclog;
                    return new DbResponse<FuncionarioLogado>
                    {
                        Sucesso = true,
                        Mensagem = "Login efetuado com sucesso",
                    };
                }
                else
                {
                    return new DbResponse<FuncionarioLogado>
                    {
                        Sucesso = false,
                        Mensagem = "Usuário ou senha incorretos"
                    };
                }
            }
            catch (Exception ex)
            {
                return new DbResponse<FuncionarioLogado>
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
        }
    }
}
