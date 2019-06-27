using DAO;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace BLL
{
    public class QuartoBLL
    {
        QuartoDAO dao = new QuartoDAO();

        #region Cadastrar
        public string CadastrarQuarto(Quarto q)
        {
            List<string> erros = new List<string>();
            #region Tipo Quarto
            if(q.TipoQuarto > 5 || q.TipoQuarto < 1)
            {
                erros.Add("Escolha um tipo de quarto válido");
            }
            #endregion

            #region Preco
            if(q.PrecoQuarto < 0)
            {
                erros.Add("Preço de quarto inválido");
            }
            #endregion

            #region Status Quarto
            if (q.StatusQuarto < 1 || q.StatusQuarto > 4)
            {
                erros.Add("Status do quarto inválido");
            }
            #endregion

            #region Descrição
            if (string.IsNullOrWhiteSpace(q.DescriçãoQuarto))
            {
                erros.Add("Descição inválida");
            }
            else if (q.DescriçãoQuarto.Length > 100 || q.DescriçãoQuarto.Length < 10)
            {
                erros.Add("Descrição deve ter entre 10 e 100 caracteres");
            }
            #endregion

            StringBuilder sb = new StringBuilder();
            if (erros.Count != 0)
            {
                for (int i = 0; i < erros.Count; i++)
                {
                    sb.AppendLine(erros[i]);
                }
                return sb.ToString();
            }
            return dao.Inserir(q).Mensagem;
        }
        #endregion

        #region Atualizar
        public string AtualizarQuarto(Quarto q)
        {
            List<string> erros = new List<string>();
            #region Tipo Quarto
            if (q.TipoQuarto > 5 || q.TipoQuarto < 1)
            {
                erros.Add("Escolha um tipo de quarto válido");
            }
            #endregion

            #region Preco
            if (q.PrecoQuarto < 0)
            {
                erros.Add("Preço de quarto inválido");
            }
            #endregion

            #region Status Quarto
            if (q.StatusQuarto < 1 || q.StatusQuarto > 4)
            {
                erros.Add("Status do quarto inválido");
            }
            #endregion

            #region Descrição
            if (string.IsNullOrWhiteSpace(q.DescriçãoQuarto))
            {
                erros.Add("Descição inválida");
            }
            else if (q.DescriçãoQuarto.Length > 100 || q.DescriçãoQuarto.Length < 10)
            {
                erros.Add("Descrição deve ter entre 10 e 100 caracteres");
            }
            #endregion

            StringBuilder sb = new StringBuilder();
            if (erros.Count != 0)
            {
                for (int i = 0; i < erros.Count; i++)
                {
                    sb.AppendLine(erros[i]);
                }
                return sb.ToString();
            }
            return dao.Atualizar(q).Mensagem;
        }

        #endregion

        #region Ler Todos
        public List<Quarto> LerTodos()
        {
            return dao.LerTodos().Dados;
        }


        #endregion

        #region Ler por ID
        public List<Quarto> lerPorID(int id)
        {
            return dao.LerPorID(id);
        }
        #endregion

    }
}
