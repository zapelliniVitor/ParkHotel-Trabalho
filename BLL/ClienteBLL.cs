﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAO;
using Metadata;

namespace BLL
{
    public class ClienteBLL : IEntityCRUD<Cliente>
    {
        #region Atualizar
        public string Atualizar(Cliente cli)
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
            if (string.IsNullOrWhiteSpace(cli.CPF))
            {
                erros.Add("CPF deve ser informado.");
            }
            else
            {

                cli.CPF = cli.CPF.Trim();
                cli.CPF = cli.CPF.Replace(".", "").Replace("-", "");
                if (!this.validarCPF(cli.CPF))
                {
                    erros.Add("CPF inválido");
                }
            }
            #endregion

            #region RG
            if (string.IsNullOrWhiteSpace(cli.RG))
            {
                erros.Add("RG deve ser informado.");
            }
            else
            {
                cli.RG = cli.RG.Trim();
                cli.RG = cli.RG.Replace(".", "").Replace("/", "").Replace("-", "");
                if (cli.RG.Length < 5 || cli.RG.Length > 9)
                {
                    erros.Add("RG deve conter entre 5 e 9 caracteres.");
                }
            }
            #endregion

            #region telefone1
            if (string.IsNullOrWhiteSpace(cli.Telefone1))
            {
                erros.Add("Telefone deve ser informado.");
            }
            else
            {
                cli.Telefone1 =
                    cli.Telefone1.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (cli.Telefone1.Length < 8 || cli.Telefone1.Length > 15)
                {
                    erros.Add("Telefone 1 deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion

            #region telefone2
            if (!string.IsNullOrWhiteSpace(cli.Telefone2))
            {
                cli.Telefone2 =
                    cli.Telefone2.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (cli.Telefone2.Length < 8 || cli.Telefone2.Length > 15)
                {
                    erros.Add("Telefone 2 deve conter entre 8 e 15 caracteres.");
                }
            }

            #endregion

            #region email
            bool isEmail = Regex.IsMatch(cli.email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                erros.Add("Email válido deve ser informado.");
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

            return new ClienteDAO().Atualizar(cli).Mensagem;
        }
        #endregion

        #region Inserir
        public string Inserir(Cliente cli)
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
            if (string.IsNullOrWhiteSpace(cli.CPF))
            {
                erros.Add("CPF deve ser informado.");
            }
            else
            {

                cli.CPF = cli.CPF.Trim();
                cli.CPF = cli.CPF.Replace(".", "").Replace("-", "").Replace(",","");
                if (!this.validarCPF(cli.CPF))
                {
                    erros.Add("CPF inválido");
                }
            }
            #endregion

            #region RG
            if (string.IsNullOrWhiteSpace(cli.RG))
            {
                erros.Add("RG deve ser informado.");
            }
            else
            {
                cli.RG = cli.RG.Trim();
                cli.RG = cli.RG.Replace(".", "").Replace("/", "").Replace("-", "");
                if (cli.RG.Length < 5 || cli.RG.Length > 9)
                {
                    erros.Add("RG deve conter entre 5 e 9 caracteres.");
                }
            }
            #endregion

            #region telefone1
            if (string.IsNullOrWhiteSpace(cli.Telefone1))
            {
                erros.Add("Telefone deve ser informado.");
            }
            else
            {
                cli.Telefone1 =
                    cli.Telefone1.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (cli.Telefone1.Length < 8 || cli.Telefone1.Length > 15)
                {
                    erros.Add("Telefone 1 deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion

            #region telefone2
            if (!string.IsNullOrWhiteSpace(cli.Telefone2))
            {
                cli.Telefone2 =
                    cli.Telefone2.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (cli.Telefone2.Length < 8 || cli.Telefone2.Length > 15)
                {
                    erros.Add("Telefone 2 deve conter entre 8 e 15 caracteres.");
                }
            }
            
            #endregion

            #region email
            bool isEmail = Regex.IsMatch(cli.email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                erros.Add("Email válido deve ser informado.");
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

            return new ClienteDAO().Inserir(cli).Mensagem;
        }
        #endregion

        #region LerPorID
        public string LerPorID(int ID)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region LerTodos
        public List<Cliente> LerTodos()
        {
            return new ClienteDAO().LerTodos().Dados;
        }
        #endregion

        #region ValidarCPF
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
        #endregion
    }
}