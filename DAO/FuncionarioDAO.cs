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
        }
    }
}
