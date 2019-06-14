using BLL;
using Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPresentationLayer
{
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
            DataGridViewClientes.DataSource = new ClienteBLL().LerTodos();
        }

        #region Cadastro
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string CPF = mtxtCPF.Text;
            string RG = mtxtRG.Text;
            string Email = txtEmail.Text;
            string Fone1 = mtxtFone1.Text;
            string Fone2 = mtxtFone2.Text;

            Cliente cli = new Cliente(nome, CPF, RG, Fone1, Fone2, Email);
            MessageBox.Show(new ClienteBLL().Inserir(cli));
        }
        #endregion

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string nome = txtNome.Text;
            string CPF = mtxtCPF.Text;
            string RG = mtxtRG.Text;
            string Email = txtEmail.Text;
            string Fone1 = mtxtFone1.Text;
            string Fone2 = mtxtFone2.Text;

            Cliente cli = new Cliente(id, nome, CPF, RG, Fone1, Fone2, Email);
            MessageBox.Show(new ClienteBLL().Atualizar(cli));
            txtID.Text = null;
        }
    }
}
