using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Produtos
    {
        public int ID { get; set; }
        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public double PrecoVenda { get; set; }
        public int quantidadeEstoque { get; set; }

        //Com ID
        public Produtos(int id, string nomeProduto, string descricaoProduto, double precoVenda, int quantidadeEstoque)
        {
            this.ID = id;
            this.NomeProduto = nomeProduto;
            this.DescricaoProduto = descricaoProduto;
            this.PrecoVenda = precoVenda;
            this.quantidadeEstoque = quantidadeEstoque;

        }

        //Sem ID
        public Produtos(string nomeProduto, string descricaoProduto, double precoVenda, int quantidadeEstoque)
        {
            this.NomeProduto = nomeProduto;
            this.DescricaoProduto = descricaoProduto;
            this.PrecoVenda = precoVenda;
            this.quantidadeEstoque = quantidadeEstoque;
        }

    }
}
