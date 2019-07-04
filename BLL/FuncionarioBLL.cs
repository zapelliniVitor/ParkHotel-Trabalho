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
    public class FuncionarioBLL
    {
        FuncionarioDAO dao = new FuncionarioDAO();

        #region Validar CPF
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

        #region Cadastrar
        public string cadastrarFuncionario(Funcionario func)
        {
            List<string> erros = new List<string>();

            #region Nome
            if (string.IsNullOrWhiteSpace(func.Nome))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                func.Nome = func.Nome.Trim();
                if (func.Nome.Length < 3 || func.Nome.Length > 60)
                {
                    erros.Add("Nome deve conter entre 3 e 60 caracteres.");
                }
                else
                {
                    for (int i = 0; i < func.Nome.Length; i++)
                    {
                        if (!char.IsLetter(func.Nome[i]) && func.Nome[i] != ' ')
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
                
                func.CPF = func.CPF.Trim();
                func.CPF = func.CPF.Replace(".", "").Replace("-", "");
                if (!this.validarCPF(func.CPF))
                {
                    erros.Add("CPF inválido");
                }
            }
            #endregion

            #region RG
            if (string.IsNullOrWhiteSpace(func.RG))
            {
                erros.Add("RG deve ser informado.");
            }
            else
            {
                func.RG = func.RG.Trim();
                func.RG = func.RG.Replace(".", "").Replace("/", "").Replace("-", "");
                if (func.RG.Length < 5 || func.RG.Length > 9)
                {
                    erros.Add("RG deve conter entre 5 e 9 caracteres.");
                }
            }
            #endregion

            #region endereco
            if (string.IsNullOrWhiteSpace(func.Endereco))
            {
                erros.Add("Endereco deve ser informado");
            }
            else
            {
                if (func.Endereco.Length < 5 || func.Endereco.Length > 60)
                {
                    erros.Add("Endereco deve ter entre 10 e  60 caracteres");
                }
            }
            #endregion

            #region telefone
            if (string.IsNullOrWhiteSpace(func.Telefone))
            {
                erros.Add("Telefone deve ser informado.");
            }
            else
            {
                func.Telefone =
                    func.Telefone.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (func.Telefone.Length < 8 || func.Telefone.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion

             #region email
            bool isEmail = Regex.IsMatch(func.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                erros.Add("Email deve ser informado.");
            }
            #endregion

            #region senha
            if (string.IsNullOrWhiteSpace(func.Senha))
            {
                erros.Add("campo senha deve ser preenchido");
            }
            else
            {
                if (func.Senha.Length < 5 || func.Senha.Length > 30)
                {
                    erros.Add("Senha deve conter entre 5 e 30 caracteres");
                }
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
            return dao.Inserir(func).Mensagem;

        }
        #endregion

        #region Atualizar
        public string atualizarFuncionario(Funcionario func)
        {
            List<string> erros = new List<string>();

            #region Nome
            if (string.IsNullOrWhiteSpace(func.Nome))
            {
                erros.Add("Nome deve ser informado.");
            }
            else
            {
                func.Nome = func.Nome.Trim();
                if (func.Nome.Length < 3 || func.Nome.Length > 60)
                {
                    erros.Add("Nome deve conter entre 3 e 60 caracteres.");
                }
                else
                {
                    for (int i = 0; i < func.Nome.Length; i++)
                    {
                        if (!char.IsLetter(func.Nome[i]) && func.Nome[i] != ' ')
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

                func.CPF = func.CPF.Trim();
                func.CPF = func.CPF.Replace(".", "").Replace("-", "");
                if (!this.validarCPF(func.CPF))
                {
                    erros.Add("CPF inválido");
                }
            }
            #endregion

            #region RG
            if (string.IsNullOrWhiteSpace(func.RG))
            {
                erros.Add("RG deve ser informado.");
            }
            else
            {
                func.RG = func.RG.Trim();
                func.RG = func.RG.Replace(".", "").Replace("/", "").Replace("-", "");
                if (func.RG.Length < 5 || func.RG.Length > 9)
                {
                    erros.Add("RG deve conter entre 5 e 9 caracteres.");
                }
            }
            #endregion

            #region endereco
            if (string.IsNullOrWhiteSpace(func.Endereco))
            {
                erros.Add("Endereco deve ser informado");
            }
            else
            {
                if (func.Endereco.Length < 5 || func.Endereco.Length > 60)
                {
                    erros.Add("Endereco deve ter entre 10 e  60 caracteres");
                }
            }
            #endregion

            #region telefone
            if (string.IsNullOrWhiteSpace(func.Telefone))
            {
                erros.Add("Telefone deve ser informado.");
            }
            else
            {
                func.Telefone =
                    func.Telefone.Replace(" ", "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace("-", "");

                if (func.Telefone.Length < 8 || func.Telefone.Length > 15)
                {
                    erros.Add("Telefone deve conter entre 8 e 15 caracteres.");
                }
            }
            #endregion

            #region email
            bool isEmail = Regex.IsMatch(func.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                erros.Add("Email deve ser informado.");
            }
            #endregion

            #region senha
            if (func.Senha.Length == 0)
            {

            }
            else
            {
                if (string.IsNullOrWhiteSpace(func.Senha))
                {
                    erros.Add("campo senha deve ser preenchido");
                }
                else
                {
                    if (func.Senha.Length < 5 || func.Senha.Length > 30)
                    {
                        erros.Add("Senha deve conter entre 5 e 30 caracteres");
                    }
                }
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
            return dao.Atualizar(func).Mensagem;

        }
        #endregion

        #region Ler Todos
        public List<Funcionario> LerTodos()
        {
            return dao.LerTodos();
        }
        #endregion

        #region ler por ID
        public List<Funcionario> lerPorId(int id)
        {
            return dao.LerPorID(id).Dados;
        }
        #endregion

        #region ler por Nome
        public List<Funcionario> lerPorNome(string nome)
        {
            return dao.LerPorNome(nome).Dados;
        }
        #endregion

        #region ler por CPF
        public List<Funcionario> lerPorCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");
            return dao.LerPorCPF(cpf).Dados;
        }
        #endregion
    }
}
