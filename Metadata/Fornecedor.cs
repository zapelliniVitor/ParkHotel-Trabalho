using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Fornecedor 
    {
        public int ID { get; set; }
        public string NomeContato { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        //Com ID
        public Fornecedor(int id, string nomeContato, string razaoSocial, string cnpj, string telefone, string email)
        {
            this.ID = id;
            this.NomeContato = nomeContato;
            this.RazaoSocial = razaoSocial;
            this.CNPJ = cnpj;
            this.Telefone = telefone;
            this.Email = email;
        }

        //Sem ID
        public Fornecedor(string nomeContato, string razaoSocial, string cnpj, string telefone, string email)
        {
            this.NomeContato = nomeContato;
            this.RazaoSocial = razaoSocial;
            this.CNPJ = cnpj;
            this.Telefone = telefone;
            this.Email = email;
        }

        public Fornecedor()
        {

        }

    }
}
