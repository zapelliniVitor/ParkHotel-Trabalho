using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class EntradaProduto
    {
        public int ID { get; set; }
        public DateTime DataRecebimento { get; set; }
        public string Fornecedor { get; set; }
        public double ValorTotal { get; set; }


        public EntradaProduto(int id, DateTime dataRecebimento, string fornecedor, double total)
        {
            this.ID = id;
            this.DataRecebimento = dataRecebimento;
            this.Fornecedor = fornecedor;
            this.ValorTotal = total;
        }

        public EntradaProduto(DateTime dataRecebimento, string fornecedor, double total)
        {
            this.DataRecebimento = dataRecebimento;
            this.Fornecedor = fornecedor;
            this.ValorTotal = total;
        }
    }
}
