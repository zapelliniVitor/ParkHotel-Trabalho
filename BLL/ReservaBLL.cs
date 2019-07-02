using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Metadata;

namespace BLL
{
    public class ReservaBLL
    {
        ReservaDAO dao = new ReservaDAO();

        #region Create
        public string Cadastro(Reserva r)
        {
            List<string> erros = new List<string>();
            
            #region ID Cliente
            if (r.IdCliente <= 0)
            {
                erros.Add("ID do Cliente inválido.");
            }
            else
            {
                if (!new ClienteDAO().LerPorID(r.IdCliente).Sucesso)
                {
                    erros.Add("Cliente inexistente");
                }
            }
            #endregion

            #region Data Entrada
            if (r.dataEntrada < DateTime.Today)
            {
                erros.Add("Data de entrada inválida.");
            }
            else if (r.dataEntrada > r.dataSaidaPrevista)
            {
                erros.Add("Data de entrada não pode ser maior que a data prevista de saida.");

            }
            #endregion

            #region Saida Prevista
           if (r.dataSaidaPrevista <= r.dataEntrada)
            {
                erros.Add("Data prevista de saida não pode ser menor do que a data de entrada.");
            }
            #endregion

            #region ID Funcionario
            if (r.IdFuncionario <= 0)
            {
                erros.Add("ID do Funcionário inválido.");
            }
            else
            {
                if (!new FuncionarioDAO().LerPorID(r.IdFuncionario).Sucesso)
                {
                    erros.Add("Funcionário inexistente.");
                }
            }
            #endregion

            #region ID Quarto
            if (r.IdQuarto <= 0)
            {
                erros.Add("ID Quarto inválido");
            }
            else
            {
                if (!new QuartoDAO().LerPorID(r.IdQuarto).Sucesso)
                {
                    erros.Add("ID Quarto Inválido.");
                }
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

            return dao.Inserir(r).Mensagem;
        }
        #endregion

        #region Update
        public string Atualizar(Reserva r)
        {
            List<string> erros = new List<string>();
            
            #region ID Cliente
            if (r.IdCliente< 0)
            {
                erros.Add("ID do Cliente inválido.");
            }
            else
            {
                if (!new ClienteDAO().LerPorID(r.IdCliente).Sucesso)
                {
                    erros.Add("Cliente inexistente");
                }
            }
            #endregion

            #region Data Entrada
            if (r.dataEntrada<DateTime.Today)
            {
                erros.Add("Data de entrada inválida.");
            }
            else if (r.dataEntrada > r.dataSaidaPrevista)
            {
                erros.Add("Data de entrada não pode ser maior que a data prevista de saida.");

            }
            #endregion

            #region Saida Prevista
           if (r.dataSaidaPrevista <= r.dataEntrada)
            {
                erros.Add("Data prevista de saida não pode ser menor do que a data de entrada.");
            }
            #endregion

            #region ID Funcionario
            if (r.IdFuncionario< 0)
            {
                erros.Add("ID do Funcionário inválido.");
            }
            else
            {
                if (!new FuncionarioDAO().LerPorID(r.IdFuncionario).Sucesso)
                {
                    erros.Add("Funcionário inexistente.");
                }
            }
            #endregion

            #region ID Quarto
            if (r.IdQuarto< 0)
            {
                erros.Add("ID Quarto inválido");
            }
            else
            {
                if (!new QuartoDAO().LerPorID(r.IdQuarto).Sucesso)
                {
                    erros.Add("ID Quarto Inválido.");
                }
            }
            #endregion

            StringBuilder sb = new StringBuilder();
            if (erros.Count != 0)
            {
                for (int i = 0; i<erros.Count; i++)
                {
                    sb.AppendLine(erros[i]);
                }
                return sb.ToString();
            }

            return dao.Atualizar
(r).Mensagem;
        }
        #endregion

        #region Delete
        public string delete(int id)
        {
            return dao.Delete(id).Mensagem;
        }
        #endregion

        #region Ler Todos
        public List<Reserva> LerTodos()
        {
            return new ReservaDAO().LerTodos();
        }
        #endregion

    }
}
