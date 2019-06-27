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

        public string Cadastro(Reserva r)
        {
            List<string> erros = new List<string>();
            
            #region ID Cliente
            if (r.IdCliente < 0)
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

            #region Entrada

            #endregion

            #region Saida Prevista

            #endregion

            #region ID Funcionario

            #endregion

            return dao.Inserir(r).Mensagem;
        }


    }
}
