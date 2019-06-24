using Metadata;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuartoDAO
    {
        #region Create
        public DbResponse<int> Inserir(Quarto q)
        {
            int idInserida = -1;

            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(connectionString);

            command.CommandText = @"INSERT INTO QUARTOS (TIPO_QUARTO, PRECO, STATUSQUARTO, DESCRICAO_QUARTO, N_QUARTO) VALUES
                                  (@TIPO_QUARTO, @PRECO, @STATUSQUARTO, @DESCRICAO_QUARTO, @N_QUARTO); select scope_identity()";
            command.Parameters.AddWithValue("@TIPO_QUARTO", q.TipoQuarto);
            command.Parameters.AddWithValue("@PRECO", q.PrecoQuarto);
            command.Parameters.AddWithValue("@STATUSQUARTO", q.StatusQuarto);
            command.Parameters.AddWithValue("@DESCRICAO_QUARTO", q.DescriçãoQuarto);
            command.Parameters.AddWithValue("@N_QUARTO", q.n_Quarto);


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
                        Mensagem = "Quarto já cadastrado",
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
                Mensagem = "Quarto cadastrado com sucesso",
                Dados = idInserida
            };
        }
        #endregion

        #region Read All
        public DbResponse<List<Quarto>> LerTodos()
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand(connection.ToString());
            command.CommandText = "SELECT * FROM QUARTOS";

            List<Quarto> listQua = new List<Quarto>();
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    int tipoQuarto = (int)reader["TIPO_QUARTO"];
                    double preco = (double)reader["PRECO"];
                    int statusQuarto = (int)reader["STATUSQUARTO"];
                    string descricaoQuarto = (string)reader["DESCRICAO_QUARTO"];
                    int nQuarto = (int)reader["N_QUARTO"];

                    Quarto qua = new Quarto(id, tipoQuarto, preco, statusQuarto, descricaoQuarto, nQuarto);
                    listQua.Add(qua);
                }

            }
            catch (Exception ex)
            {
                return new DbResponse<List<Quarto>>
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
            return new DbResponse<List<Quarto>>
            {
                Sucesso = true,
                Mensagem = "Quartos recebidos",
                Dados = listQua
            };
        }
        #endregion

        #region Delete
        public DbResponse<int> excluir(int id)
        {
            string connectionString = Parametros.GetConnectionString();

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.CommandText = @"DELETE FROM QUARTOS WHERE ID = @ID";
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
                    Sucesso = false,
                    Mensagem = "Banco de dados indisponível, favor contatar o admin",
                    Excessao = ex
                };
            }
            finally
            {
                connection.Dispose();
            }
            return new DbResponse<int>
            {
                Sucesso = true,
                Mensagem = "Quarto excluido com sucesso",
            };
        }

        #endregion

        #region Update
        public DbResponse<int> Atualizar(Quarto q)
        {
            SqlConnection connection = new SqlConnection(Parametros.GetConnectionString());

            SqlCommand command = new SqlCommand(connection.ToString());

            command.CommandText = @"UPDATE QUARTOS SET TIPO_QUARTO = @TIPO_QUARTO, PRECO = @PRECO, STATUSQUARTO = @STATUSQUARTO, 
                                   DESCRICAO_QUARTO = @DESCRICAO_QUARTO, N_QUARTO = @N_QUARTO WHERE ID = @ID";
            command.Parameters.AddWithValue("@TIPO_QUARTO", q.TipoQuarto);
            command.Parameters.AddWithValue("@PRECO", q.PrecoQuarto);
            command.Parameters.AddWithValue("@STATUSQUARTO", q.StatusQuarto);
            command.Parameters.AddWithValue("@DESCRICAO_QUARTO", q.DescriçãoQuarto);
            command.Parameters.AddWithValue("@N_QUARTO", q.n_Quarto);
            command.Parameters.AddWithValue("@ID", q.ID);


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
                Dados = q.ID,
                Mensagem = "Quarto atualizado com sucesso",
                Sucesso = true,
            };
        }
        #endregion

        #region Read ID
        public List<Quarto> LerPorID(int ID)
        {
            string connectionString = Parametros.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT * FROM QUARTOS WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", ID);

            command.Connection = connection;

            List<Quarto> list = new List<Quarto>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    int tipoQuarto = (int)reader["TIPO_QUARTO"];
                    double preco = (double)reader["PRECO"];
                    int statusQuarto = (int)reader["STATUSQUARTO"];
                    string descricaoQuarto = (string)reader["DESCRICAO_QUARTO"];
                    int nQuarto = (int)reader["N_QUARTO"];

                    Quarto quarto = new Quarto(id, tipoQuarto, preco, statusQuarto, descricaoQuarto, nQuarto);
                    list.Add(quarto);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Dispose();
            }

            return list;
        }
        #endregion

    }
}
