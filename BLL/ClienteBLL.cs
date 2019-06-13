using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metadata;

namespace BLL
{
    public class ClienteBLL : IEntityCRUD<Cliente>
    {
        Cliente cli = new Cliente();
        public ClienteBLL(Cliente cli)
        {
            this.cli = cli;
        }

        public string Atualizar(Cliente item)
        {
            throw new NotImplementedException();
        }

        public string Inserir(Cliente item)
        {
            throw new NotImplementedException();
        }

        public string LerPorID(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> LerTodos()
        {
            throw new NotImplementedException();
        }

        public string Validar(Cliente cli)
        {
            return "";
        }
    }
}
