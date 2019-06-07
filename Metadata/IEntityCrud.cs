using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public interface IEntityCRUD<T>
    {
        string Inserir(T item);
        string Atualizar(T item);
        T LerPorID(int ID);
        List<T> LerTodos();
    }
}
