using DAO;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
     public class ProdutoBLL
    {
        #region Atualizar
        public string Atualizar(Produto prod)
        {
            if (!new ProdutoDAO().LerPorID(prod.ID).Sucesso)
            {
                return "Produto inexistente";
            }
            List<string> erros = new List<string>();

            #region Nome
            if (string.IsNullOrWhiteSpace(prod.Nome))
            {
                erros.Add("Nome do produto deve ser informado.");
            }
            else
            {
                prod.Nome = prod.Nome.Trim();
                if (prod.Nome.Length < 3 || prod.Nome.Length > 60)
                {
                    erros.Add("Nome do produto deve conter entre 3 e 60 caracteres.");
                }
            }
            #endregion

            #region Descricao
            if (string.IsNullOrWhiteSpace(prod.Descricao))
            {
                erros.Add("Descrição do produto deve ser informada.");
            }
            else
            {
                prod.Descricao = prod.Descricao.Trim();
                if (prod.Descricao.Length < 3 || prod.Descricao.Length > 100)
                {
                    erros.Add("Descrição do produto deve conter entre 3 e 100 caracteres.");
                }
            }
            #endregion

            #region Estoque
            if(prod.quantidadeEstoque < 0)
            {
                erros.Add("Quantidade inválida");
            }
            #endregion

            #region Preco
            if(prod.PrecoVenda < 0)
            {
                erros.Add("Preço inválido");
            }
            #endregion

            StringBuilder builder = new StringBuilder();
            if (erros.Count != 0)
            {
                for (int i = 0; i < erros.Count; i++)
                {
                    builder.AppendLine(erros[i]);
                }
                return builder.ToString();
            }

            return new ProdutoDAO().Atualizar(prod).Mensagem;
        }
        #endregion

        #region Inserir
        public string Inserir(Produto prod)
        {
            List<string> erros = new List<string>();

            #region Nome
            if (string.IsNullOrWhiteSpace(prod.Nome))
            {
                erros.Add("Nome do produto deve ser informado.");
            }
            else
            {
                prod.Nome = prod.Nome.Trim();
                if (prod.Nome.Length < 3 || prod.Nome.Length > 60)
                {
                    erros.Add("Nome do produto deve conter entre 3 e 60 caracteres.");
                }
            }
            #endregion

            #region Descricao
            if (string.IsNullOrWhiteSpace(prod.Descricao))
            {
                erros.Add("Descrição do produto deve ser informada.");
            }
            else
            {
                prod.Descricao = prod.Descricao.Trim();
                if (prod.Descricao.Length < 3 || prod.Descricao.Length > 100)
                {
                    erros.Add("Descrição do produto deve conter entre 3 e 100 caracteres.");
                }
            }
            #endregion

            #region Estoque
            if (prod.quantidadeEstoque < 0)
            {
                erros.Add("Quantidade inválida");
            }
            #endregion

            #region Preco
            if (prod.PrecoVenda < 0)
            {
                erros.Add("Preço inválido");
            }
            #endregion


            StringBuilder builder = new StringBuilder();
            if (erros.Count != 0)
            {
                for (int i = 0; i < erros.Count; i++)
                {
                    builder.AppendLine(erros[i]);
                }
                return builder.ToString();
            }

            return new ProdutoDAO().Inserir(prod).Mensagem;
        }
        #endregion

        #region LerPorID
        public string LerPorID(int ID)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region LerTodos
        public List<Produto> LerTodos()
        {
            return new ProdutoDAO().LerTodos().Dados;
        }
        #endregion
    }
}
