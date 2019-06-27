using DAO;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBLL
    {
        #region Autenticar
        public LoginResponse Autenticar(string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                return new LoginResponse
                {
                    Sucesso = false,
                    Mensagem = "Preencha todos os campos para efetuar login"
                };
            }
            DbResponse<FuncionarioLogado> resposta = new LoginDAO().Autenticar(email, senha);
            if (!resposta.Sucesso)
            {
                return new LoginResponse
                {
                    Sucesso = false,
                    Mensagem = resposta.Mensagem
                };
            }
            return new LoginResponse
            {
                Sucesso = true,
                Mensagem = resposta.Mensagem
            };

        }
        #endregion
    }
}
