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
        ProdutoDAO dao = new ProdutoDAO();

        #region Atualizar
        public string Atualizar(Produto prod)
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

            return dao.Atualizar(prod).Mensagem;
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

            return dao.Inserir(prod).Mensagem;
        }
        #endregion

        public string delete(int id)
        {
            return dao.Delete(id).Mensagem;
        }

        #region LerPorID
        public List<Produto> LerPorID(int ID)
        {
            return dao.LerPorID(ID);
        }
        #endregion

        #region LerTodos
        public List<Produto> LerTodos()
        {
            return dao.LerTodos().Dados;
        }
        #endregion

        public List<Produto> PesquisarID(int id)
        {
            return dao.PesquisarID(id).Dados;
        }

        public List<Produto> PesquisarNome(string nome)
        {
            return dao.PesquisarNome(nome).Dados;
        }
    }
}
