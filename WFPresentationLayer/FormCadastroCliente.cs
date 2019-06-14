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
            Resetar();
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
            Resetar();
        }

        private void Resetar()
        {
            txtID.Text = null;
            txtNome.Text = null;
            mtxtCPF.Text = null;
            mtxtRG.Text = null;
            txtEmail.Text = null;
            mtxtFone1.Text = null;
            mtxtFone2.Text = null;
            DataGridViewClientes.DataSource = null;
            DataGridViewClientes.DataSource = new ClienteBLL().LerTodos();
        }

        private void DataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)DataGridViewClientes.Rows[e.RowIndex].Cells[0].Value;
            string nome = (string)DataGridViewClientes.Rows[e.RowIndex].Cells[1].Value;
            string cpf = (string)DataGridViewClientes.Rows[e.RowIndex].Cells[2].Value;
            string rg = (string)DataGridViewClientes.Rows[e.RowIndex].Cells[3].Value;
            string telefone1 = (string)DataGridViewClientes.Rows[e.RowIndex].Cells[4].Value;
            string telefone2 = (string)DataGridViewClientes.Rows[e.RowIndex].Cells[5].Value;
            string email = (string)DataGridViewClientes.Rows[e.RowIndex].Cells[6].Value;

            txtID.Text = id.ToString();
            txtNome.Text = nome;
            mtxtCPF.Text = cpf;
            mtxtRG.Text = rg;
            txtEmail.Text = email;
            mtxtFone1.Text = telefone1;
            mtxtFone2.Text = telefone2;
        }
    }
}
