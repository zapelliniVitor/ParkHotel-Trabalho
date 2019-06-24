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
            Fornecedor fornecedor = new Fornecedor(textContato.Text, txtRSocial.Text, mtxtCnpj.Text, mtxtTelefone.Text, textEmail.Text);
            MessageBox.Show(bll.cadastrarFornecedor(fornecedor));
            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = bll.lerTodos();
            FormCleaner.Clear(this);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor(Convert.ToInt32(txtID.Text), textContato.Text, txtRSocial.Text, mtxtCnpj.Text, mtxtTelefone.Text, textEmail.Text);
            MessageBox.Show(bll.atualizarFornecedor(fornecedor));
        }
    }
}
