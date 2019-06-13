using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;

namespace DAO
{
    class ClienteDAO : IEntityCRUD<Cliente>
    {
        public string Atualizar(Cliente item)
        {
            throw new NotImplementedException();
        }

        #region Inserir
        public string Inserir(Cliente cli)
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = @"INSERT INTO CLIENTES (NOME, CPF, RG, TELEFONE1, TELEFONE2, EMAIL) VALUES
                                  (@NOME, @CPF, @RG,  @TELEFONE1, @TELEFONE2, @EMAIL)";
            command.Parameters.AddWithValue("@NOME", cli.Nome);
            command.Parameters.AddWithValue("@CPF", cli.CPF);
            command.Parameters.AddWithValue("@RG", cli.RG);
            command.Parameters.AddWithValue("@TELEFONE1", cli.Telefone1);
            command.Parameters.AddWithValue("@TELEFONE2", cli.Telefone2);
            command.Parameters.AddWithValue("@EMAIL", cli.email);

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
            return "Cliente cadastrado com sucesso";
        }
        #endregion

        #region LerPorID
        public Cliente LerPorID(int ID)
        {

            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "SELECT * FROM CLIENTES WHERE ID = @ID";

            command.Parameters.AddWithValue("@ID", ID);

            Cliente cli = new Cliente();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    cli.ID = (int)reader["ID"];
                    cli.Nome = (string)reader["NOME"];
                    cli.CPF = (string)reader["CPF"];
                    cli.RG = (string)reader["RG"];
                    cli.Telefone1 = (string)reader["TELEFONE1"];
                    cli.Telefone2 = (string)reader["TELEFONE2"];
                    cli.email = (string)reader["EMAIL"];
                    return cli;
                }
            }
            catch
            {
                throw new Exception("Banco de dados indisponível");
            }
            finally
            {
                connection.Dispose();
            }
            throw new Exception("ID não encontrado");
        }
        #endregion

        #region LerTodos
        public List<Cliente> LerTodos()
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "SELECT * FROM CLIENTES";

            List<Cliente> listCli = new List<Cliente>();
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
                    
                    Cliente cli = new Cliente(id, nome, CPF, RG, Telefone1, Telefone2, Email);
                    listCli.Add(cli);
                }

            }
            catch 
            {
                throw new Exception("Banco de dados indisponível");
            }
            finally
            {
                connection.Dispose();
            }
            return listCli;
        }
        #endregion
    }
}
