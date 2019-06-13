using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Cliente : IEntityCRUD<Cliente>
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string email { get; set; }

        public Cliente(string nome, string cpf, string rg, string telefone1, string telefone2, string email)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.RG = rg;
            this.Telefone1 = telefone1;
            this.Telefone2 = telefone2;
            this.email = email;
        }

        public Cliente()
        {

        }

        public string Atualizar(Cliente cli)
        {
            return "";
        }

        public string Inserir(Cliente cli)
        {
            throw new NotImplementedException();
        }

        public Cliente LerPorID(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> LerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
