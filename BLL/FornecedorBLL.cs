using DAO;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class FornecedorBLL
    {
        FornecedorDAO dao = new FornecedorDAO();
        
        public static bool validaCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace("\\","");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        //Cadastrar novo fornecedor
        public string cadastrarFornecedor(Fornecedor f)
        {
            List<string> erros = new List<string>();

            #region Razao Social
            if (string.IsNullOrWhiteSpace(f.RazaoSocial))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                f.RazaoSocial = f.RazaoSocial.Trim();
                if (f.RazaoSocial.Length < 5 || f.RazaoSocial.Length > 50)
                {
                    erros.Add("Razão social deve conter entre 5 e 50 caracteres.");
                }
                else
                {
                    for (int i = 0; i < f.RazaoSocial.Length; i++)
                    {
                        if (!char.IsLetter(f.RazaoSocial[i]) && f.RazaoSocial[i] != ' ')
                        {
                            char c = f.RazaoSocial[i];
                            erros.Add("Razão social inválido.");
                            break;
                        }
                    }
                }
            }
            #endregion

            #region CNPJ
            if (string.IsNullOrWhiteSpace(f.CNPJ))
            {
                erros.Add("CNPJ deve ser informado.");
            }
            else
            {
                f.CNPJ = f.CNPJ.Trim().Replace(".", "").Replace("-", "").Replace(",", "").Replace("/","");
                if (!validaCNPJ(f.CNPJ))
                {
                    erros.Add("CNPJ inválido." +
                        "");
                }
            }
            #endregion

            #region Nome Contato
            if (string.IsNullOrWhiteSpace(f.NomeContato))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                f.NomeContato = f.NomeContato.Trim();
                if (f.NomeContato.Length < 3 || f.NomeContato.Length > 60)
                {
                    erros.Add("Nome do contato deve conter entre 3 e 60 caracteres.");
                }
                else
                {
                    for (int i = 0; i < f.NomeContato.Length; i++)
                    {
                        if (!char.IsLetter(f.NomeContato[i]) && f.NomeContato[i] != ' ')
                        {
                            erros.Add("Nome inválido");
                            break;
                        }
                    }
                }
            }
            #endregion

            #region telefone
            if (string.IsNullOrWhiteSpace(f.Telefone))
            {
                erros.Add("Telefone deve ser informado.");
            }
            else
            {
                f.Telefone =
                    f.Telefone.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (f.Telefone.Length < 8 || f.Telefone.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion

            #region email
            bool isEmail = Regex.IsMatch(f.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                erros.Add("Email deve ser informado.");
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

            return dao.Inserir(f).Mensagem;
        }

        //Atualizar Fornecedor
        public string atualizarFornecedor(Fornecedor f)
        {
            List<string> erros = new List<string>();

            #region Razao Social
            if (string.IsNullOrWhiteSpace(f.RazaoSocial))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                f.RazaoSocial = f.RazaoSocial.Trim();
                if (f.RazaoSocial.Length < 3 || f.RazaoSocial.Length > 60)
                {
                    erros.Add("Razão social deve conter entre 5 e 50 caracteres.");
                }
                else
                {
                    for (int i = 0; i < f.RazaoSocial.Length; i++)
                    {
                        if (!char.IsLetter(f.RazaoSocial[i]) && f.RazaoSocial[i] != ' ')
                        {
                            erros.Add("Razão social inválido.");
                            break;
                        }
                    }
                }
            }
            #endregion

            #region CNPJ
            if (string.IsNullOrWhiteSpace(f.CNPJ))
            {
                erros.Add("CNPJ deve ser informado.");
            }
            else
            {
                f.CNPJ = f.CNPJ.Trim().Replace(".", "").Replace("-", "").Replace(",", "");
                if (!validaCNPJ(f.CNPJ))
                {
                    erros.Add("CNPJ inválido." +
                        "");
                }
            }
            #endregion

            #region Nome Contato
            if (string.IsNullOrWhiteSpace(f.NomeContato))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                f.NomeContato = f.NomeContato.Trim();
                if (f.NomeContato.Length < 3 || f.NomeContato.Length > 60)
                {
                    erros.Add("Nome do contato deve conter entre 3 e 60 caracteres.");
                }
                else
                {
                    for (int i = 0; i < f.NomeContato.Length; i++)
                    {
                        if (!char.IsLetter(f.NomeContato[i]) && f.NomeContato[i] != ' ')
                        {
                            erros.Add("Nome inválido");
                            break;
                        }
                    }
                }
            }
            #endregion

            #region telefone
            if (string.IsNullOrWhiteSpace(f.Telefone))
            {
                erros.Add("Telefone deve ser informado.");
            }
            else
            {
                f.Telefone =
                    f.Telefone.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (f.Telefone.Length < 8 || f.Telefone.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion

            #region email
            bool isEmail = Regex.IsMatch(f.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                erros.Add("Email deve ser informado.");
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

            return dao.Atualizar(f).ToString();
;
        }

        //Ler Todos
        public List<Fornecedor> lerTodos()
        {
            return dao.LerTodos().Dados;
        }

        //Ler por ID
        public List<Fornecedor> lerPorId(int id)
        {
            return dao.LerPorID(id);
        }
    }
}
