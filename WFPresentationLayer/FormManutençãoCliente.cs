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
    public partial class FormManutençãoCliente : Form
    {
        public FormManutençãoCliente()
        {
            InitializeComponent();
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
            bool ativo = true;
            
            Cliente cli = new Cliente(nome, CPF, RG, Fone1, Fone2, Email, ativo);
            cli = new ClienteBLL().ProcurarCPF(cli);
            if(cli.ID == -1)
            {
                MessageBox.Show("Banco de dados indisponível");
                return;
            }
            if (cli.ID > -1)
            {
                DialogResult resposta = MessageBox.Show("Cliente já cadastrado, porém inativo\r\nDeseja ativá-lo?", "Cliente inativo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resposta == DialogResult.Yes)
                {
                    MessageBox.Show(new ClienteBLL().Atualizar(cli));
                }
                FormCleaner.Clear(this);;
                DataGridViewClientes.DataSource = null;
                DataGridViewClientes.DataSource = new ClienteBLL().LerTodos();
                return;
            }

            MessageBox.Show(new ClienteBLL().Inserir(cli));
            FormCleaner.Clear(this);
            DataGridViewClientes.DataSource = null;
            DataGridViewClientes.DataSource = new ClienteBLL().LerTodos();
        }
        #endregion

        #region Atualizar
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string nome = txtNome.Text;
            string CPF = mtxtCPF.Text;
            string RG = mtxtRG.Text;
            string Email = txtEmail.Text;
            string Fone1 = mtxtFone1.Text;
            string Fone2 = mtxtFone2.Text;
            bool ativo = true;
            

            Cliente cli = new Cliente(id, nome, CPF, RG, Fone1, Fone2, Email, ativo);
            MessageBox.Show(new ClienteBLL().Atualizar(cli));
            txtID.Text = null;
            FormCleaner.Clear(this);
            DataGridViewClientes.DataSource = null;
            DataGridViewClientes.DataSource = new ClienteBLL().LerTodos();

        }
        #endregion

        #region SelecionarCliente
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
        #endregion

        #region Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            DialogResult resposta = MessageBox.Show("Deseja mesmo deletar esse cliente?", "Deletar Cliente", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resposta == DialogResult.No || resposta == DialogResult.None)
            {
                return;
            }
            else
            {
                new ClienteBLL().Excluir(id);
            }
            FormCleaner.Clear(this);
            DataGridViewClientes.DataSource = null;
            DataGridViewClientes.DataSource = new ClienteBLL().LerTodos();
        }
        #endregion

        private void FormManutençãoCliente_Load(object sender, EventArgs e)
        {
            DataGridViewClientes.DataSource = null;
            DataGridViewClientes.DataSource = new ClienteBLL().LerTodos();
        }
    }
}
