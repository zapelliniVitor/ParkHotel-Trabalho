using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Funcionario 
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool EhAdmin { get; set; }
        public bool EhAtivo { get; set; }
        

        //Construtor COM senha
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

        //Construtor COM senha e COM ID
        public Funcionario(int id, string nome, string cpf, string rg, string endereco, string telefone, string email, string senha, bool ehAdmin, bool ehAtivo)
        {
            this.ID = id;
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
        
        //Construtor SEM senha e COM ID
        public Funcionario(int id, string nome, string cpf, string rg, string endereco, string telefone, string email, bool ehAdmin, bool ehAtivo)
        {
            this.ID = id;
            this.Nome = nome;
            this.CPF = cpf;
            this.RG = rg;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.EhAdmin = ehAdmin;
            this.EhAtivo = ehAtivo;
        }

        public Funcionario()
        {

        }


        

    }
}
