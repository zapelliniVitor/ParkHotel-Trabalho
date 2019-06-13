﻿using System;
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

            command.CommandText = @"UPDATE FROM CLIENTES SET NOME = @NOME, CPF = @CPF, RG = @RG, TELEFONE1 = @TELEFONE1, TELEFONE2 = @TELEFONE2, EMAIL = @EMAIL WHERE  ID = " + cli.ID;
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
            command.CommandText = @"INSERT INTO CLIENTES (NOME, CPF, RG, TELEFONE1, TELEFONE2, EMAIL) VALUES
                                  (@NOME, @CPF, @RG,  @TELEFONE1, @TELEFONE2, @EMAIL); select scope_identity()" ;
            command.Parameters.AddWithValue("@NOME", cli.Nome);
            command.Parameters.AddWithValue("@CPF", cli.CPF);
            command.Parameters.AddWithValue("@RG", cli.RG);
            command.Parameters.AddWithValue("@TELEFONE1", cli.Telefone1);
            command.Parameters.AddWithValue("@TELEFONE2", cli.Telefone2);
            command.Parameters.AddWithValue("@EMAIL", cli.email);

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
                        Mensagem = "Funcionário já cadastrado",
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
        public DbResponse<Cliente> LerPorID(int ID)
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
                    return new DbResponse<Cliente>
                    {
                        Sucesso = true,
                        Mensagem = "Cliente encontrado",
                        Dados = cli
                    };
                }
            }
            catch (Exception ex)
            {
                return new DbResponse<Cliente>
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
            return new DbResponse<Cliente>
            {
                Sucesso = false,
                Mensagem = "Cliente não encontrado",
            };
        }
        #endregion

        #region LerTodos
        public DbResponse<List<Cliente>> LerTodos()
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
    }
}
