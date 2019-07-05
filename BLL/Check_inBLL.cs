using DAO;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Check_inBLL
    {
        Check_inDAO dao = new Check_inDAO();

        #region Cadastrar COM reserva
        public string cadastrar(Check_in chk)
        {
            List<string> erros = new List<string>();

            #region ID_RESERVA
            if (chk.id_reserva <= 0)
            {
                erros.Add("Reserva inexistente.");
            }
            else
            {
                erros.Clear();
            }

            #endregion

            #region DATA_ENTRADA
            if (chk.dataEntrada > chk.dataSaidaPrevista)
            {
                erros.Add("Data de entrada só pode ser efetuado na chegada do cliente.");
            }
            #endregion

            #region SAIDA_PREVISTA
            if (chk.dataSaidaPrevista <= chk.dataEntrada)
            {
                erros.Add("Data prevista de saida não pode ser menor do que a data de entrada.");
            }
            #endregion

            #region ID_CLIENTE
            if (chk.id_cliente <= 0)
            {
                erros.Add("ID do Cliente inválido.");
            }
            else
            {
                if (!new ClienteDAO().LerPorID(chk.id_cliente).Sucesso)
                {
                    erros.Add("Cliente inexistente");
                }
            }
            #endregion

            #region ID_FUNCIONARIO
            if (chk.id_func <= 0)
            {
                erros.Add("ID do Funcionário inválido.");
            }
            else
            {
                if (!new FuncionarioDAO().LerPorID(chk.id_func).Sucesso)
                {
                    erros.Add("Funcionário inexistente.");
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
            return dao.Inserir(chk).Mensagem;
        }
        #endregion

        #region Cadastrar SEM reserva
        public string inserir(Check_in chk)
        {
            List<string> erros = new List<string>();

            #region ID_QUARTO
            if (chk.id_quarto <= 0)
            {
                erros.Add("ID Quarto inválido");
            }
            else
            {
                if (!new QuartoDAO().LerPorID(chk.id_quarto).Sucesso)
                {
                    erros.Add("ID Quarto Inválido.");
                }
            }
            #endregion

            #region DATA_ENTRADA
            //if (chk.dataEntrada != DateTime.Now)
            //{
            //    erros.Add("Data de entrada só pode ser efetuado na chegada do cliente.");
            //}
            #endregion

            #region SAIDA_PREVISTA
            if (chk.dataSaidaPrevista <= chk.dataEntrada)
            {
                erros.Add("Data prevista de saida não pode ser menor do que a data de entrada.");
            }
            #endregion

            #region ID_CLIENTE
            if (chk.id_cliente <= 0)
            {
                erros.Add("ID do Cliente inválido.");
            }
            else
            {
                if (!new ClienteDAO().LerPorID(chk.id_cliente).Sucesso)
                {
                    erros.Add("Cliente inexistente");
                }
            }
            #endregion

            #region ID_FUNCIONARIO
            if (chk.id_func <= 0)
            {
                erros.Add("ID do Funcionário inválido.");
            }
            else
            {
                if (!new FuncionarioDAO().LerPorID(chk.id_func).Sucesso)
                {
                    erros.Add("Funcionário inexistente.");
                }
            }
            #endregion

            #region ATIVO
            if (!chk.EhAtivo)
                erros.Add("Check-in deve ser ativo.");
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
            return dao.Inserir(chk).Mensagem;
        }
        #endregion

        #region Ler Todos
        public List<Check_in> lerTodos()
        {
            return dao.LerTodos();
        }
        #endregion

    }
}
