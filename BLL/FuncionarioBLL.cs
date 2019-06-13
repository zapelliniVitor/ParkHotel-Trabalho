using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FuncionarioBLL
    {
        private bool validarCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);

        }

        public string cadastrarFuncionario(Funcionario func)
        {
            List<string> erros = new List<string>();

            #region Nome
            if (string.IsNullOrWhiteSpace(cli.Nome))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                cli.Nome = cli.Nome.Trim();
                if (cli.Nome.Length < 3 || cli.Nome.Length > 60)
                {
                    erros.Add("Nome deve conter entre 3 e 60 caracteres.");
                }
                else
                {
                    for (int i = 0; i < cli.Nome.Length; i++)
                    {
                        if (!char.IsLetter(cli.Nome[i]) && cli.Nome[i] != ' ')
                        {
                            erros.Add("Nome inválido");
                            break;
                        }
                    }
                }
            }
            #endregion

            #region CPF
            if (string.IsNullOrWhiteSpace(func.CPF))
            {
                erros.Add("CPF deve ser informado.");
            }
            else
            {
                
                cli.CPF = cli.CPF.Trim();
                cli.CPF = cli.CPF.Replace(".", "").Replace("-", "");
                if (!this.ValidarCPF(cli.CPF))
                {
                    erros.Add("CPF inválido");
                }
            }
            #endregion


        }


    }
}
