using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    class Fornecedor : IEntityCRUD<Fornecedor>
    {
        public string NomeContato { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }



        public string Atualizar(Fornecedor item)
        {
            throw new NotImplementedException();
        }

        public string Inserir(Fornecedor item)
        {
            throw new NotImplementedException();
        }

        public Fornecedor LerPorID(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> LerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
