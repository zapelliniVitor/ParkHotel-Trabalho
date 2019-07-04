using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class AdicionarEntradaProduto
    {
        public int ID_Entrada_Produtos { get; set; }
        public int ID_Produtos { get; set; }
        public double Preco_Compra { get; set; }
        public int QuantidadeEntrada { get; set; }
        public int ID_Fornecedor { get; set; }

        public AdicionarEntradaProduto(int idEntradaProdutos, int idProduto, double precoCompra, int quantidade, int idFornecedor)
        {
            this.ID_Entrada_Produtos = idEntradaProdutos;
            this.ID_Produtos = idProduto;
            this.Preco_Compra = precoCompra;
            this.QuantidadeEntrada = quantidade;
            this.ID_Fornecedor = idFornecedor;
        }
    }
}
