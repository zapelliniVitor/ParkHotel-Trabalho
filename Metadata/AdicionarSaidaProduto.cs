using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class AdicionarSaidaProduto
    {
        public int ID_SaidaProdutos { get; set; }
        public int ID_Produtos { get; set; }
        public double PrecoVenda { get; set; }
        public int QuantidadeSaida { get; set; }

        public AdicionarSaidaProduto(int idSaidaProduto, int idProduto, double precoVenda, int quantidade)
        {
            this.ID_SaidaProdutos = idSaidaProduto;
            this.ID_Produtos = idProduto;
            this.PrecoVenda = precoVenda;
            this.QuantidadeSaida = quantidade;
        }
    }
}
