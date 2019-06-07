using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Funcionario : IEntityCRUD<Funcionario>
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool EhAdmin { get; set; }
        public bool EhAtivo { get; set; }
        
        public Funcionario(string nome, string cpf, string rg, string endereco, string telefone, string email, string senha, bool ehAdmin, bool ehAtivo)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.RG = rg;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.Senha = senha;
            this.EhAdmin = ehAdmin;
            this.EhAtivo = ehAtivo;
        }

        public string LerDadosFuncionario()
        {
            string s = "\r\n";
            return Nome + s + CPF + s + RG + s + Endereco + s + Telefone + s + Email + s + Senha + s + EhAdmin + s + EhAtivo; 
        }

        public string Atualizar(Funcionario item)
        {
            throw new NotImplementedException();
        }

        public string Inserir(Funcionario item)
        {
            throw new NotImplementedException();
        }

        public Funcionario LerPorID(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> LerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
