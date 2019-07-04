using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        public bool EhAtivo { get; set; }

        public Cliente(string nome, string cpf, string rg, string telefone1, string telefone2, string email, bool ativo)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.RG = rg;
            this.Telefone1 = telefone1;
            this.Telefone2 = telefone2;
            this.Email = email;
            this.EhAtivo = ativo;
        }

        public Cliente(int id,string nome, string cpf, string rg, string telefone1, string telefone2, string email, bool ativo)
        {
            this.ID = id;
            this.Nome = nome;
            this.CPF = cpf;
            this.RG = rg;
            this.Telefone1 = telefone1;
            this.Telefone2 = telefone2;
            this.Email = email;
            this.EhAtivo = ativo;
        }

        public Cliente()
        {
            
        }

        public Cliente(int id)
        {
            this.ID = id;
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
