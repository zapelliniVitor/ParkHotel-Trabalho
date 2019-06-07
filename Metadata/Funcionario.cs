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
