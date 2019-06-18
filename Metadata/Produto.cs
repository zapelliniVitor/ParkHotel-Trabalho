using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double PrecoVenda { get; set; }
        public int quantidadeEstoque { get; set; }

        //Com ID
        public Produto(int id, string nomeProduto, string descricaoProduto, double precoVenda, int quantidadeEstoque)
        {
            this.ID = id;
            this.Nome = nomeProduto;
            this.Descricao = descricaoProduto;
            this.PrecoVenda = precoVenda;
            this.quantidadeEstoque = quantidadeEstoque;

        }

        //Sem ID
        public Produto(string nomeProduto, string descricaoProduto, double precoVenda, int quantidadeEstoque)
        {
            this.Nome = nomeProduto;
            this.Descricao = descricaoProduto;
            this.PrecoVenda = precoVenda;
            this.quantidadeEstoque = quantidadeEstoque;
        }

        public Produto()
        {

        }

    }
}
