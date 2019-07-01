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
    public partial class FormManutençãoFornecedor : Form
    {
        public FormManutençãoFornecedor()
        {
            InitializeComponent();
            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = bll.lerTodos();
        }

        FornecedorBLL bll = new FornecedorBLL();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor(txtContato.Text, txtRSocial.Text, mtxtCnpj.Text, mtxtTelefone.Text, txtEmail.Text);
            MessageBox.Show(bll.cadastrarFornecedor(fornecedor));
            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = bll.lerTodos();
            FormCleaner.Clear(this);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor(Convert.ToInt32(txtID.Text), txtContato.Text, txtRSocial.Text, mtxtCnpj.Text, mtxtTelefone.Text, txtEmail.Text);
            MessageBox.Show(bll.atualizarFornecedor(fornecedor));
        }

        private void dgvFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvFornecedores.Rows[e.RowIndex].Cells[0].Value;
            string razaoSocial = (string)dgvFornecedores.Rows[e.RowIndex].Cells[1].Value;
            string cnpj = (string)dgvFornecedores.Rows[e.RowIndex].Cells[2].Value;
            string nomeContato = (string)dgvFornecedores.Rows[e.RowIndex].Cells[3].Value;
            string telefone = (string)dgvFornecedores.Rows[e.RowIndex].Cells[4].Value;
            string email = (string)dgvFornecedores.Rows[e.RowIndex].Cells[5].Value;

            txtID.Text = id.ToString();
            txtRSocial.Text = razaoSocial;
            mtxtCnpj.Text = cnpj;
            txtContato.Text = nomeContato;
            mtxtTelefone.Text = telefone;
            txtEmail.Text = email;
        }
    }
}
