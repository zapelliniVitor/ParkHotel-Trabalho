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
    public partial class FormPesquisaFornecedor : Form
    {
        public FormPesquisaFornecedor()
        {
            InitializeComponent();
        }

        FornecedorBLL bll = new FornecedorBLL();
        public Fornecedor fornecedorSelecionado { get; set; }
        
        private void FormPesquisaFornecedor_Load_1(object sender, EventArgs e)
        {
            cboxDadoPesquisa.SelectedIndex = 1;
            dgvFornecedores.DataSource = bll.LerTodos();
            cboxDadoPesquisa.SelectedIndex = 0;
        }

        private void dgvFornecedores_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvFornecedores.Rows[e.RowIndex].Cells[0].Value;
            string nomeContato = (string)dgvFornecedores.Rows[e.RowIndex].Cells[1].Value;
            string razaoSocial = (string)dgvFornecedores.Rows[e.RowIndex].Cells[2].Value;
            string cnpj = (string)dgvFornecedores.Rows[e.RowIndex].Cells[3].Value;
            string telefone = (string)dgvFornecedores.Rows[e.RowIndex].Cells[4].Value;
            string email = (string)dgvFornecedores.Rows[e.RowIndex].Cells[5].Value;

            this.fornecedorSelecionado = new Fornecedor()
            {
                ID = id,
                NomeContato = nomeContato,
                RazaoSocial = razaoSocial,
                CNPJ = cnpj,
                Telefone = telefone,
                Email = email
            };

            this.Close();
        }

        private void txtPesquisa_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                dgvFornecedores.DataSource = null;
                dgvFornecedores.DataSource = bll.LerTodos();
                return;
            }

            if (cboxDadoPesquisa.SelectedIndex == 0)
            {
                if (int.TryParse(txtPesquisa.Text, out int id))
                {//id
                    dgvFornecedores.DataSource = null;
                    dgvFornecedores.DataSource = bll.PesquisarID(id);
                    return;
                }
            }

            if (cboxDadoPesquisa.SelectedIndex == 1)
            {//nome
                dgvFornecedores.DataSource = null;
                dgvFornecedores.DataSource = bll.PesquisarNome(txtPesquisa.Text);
                return;
            }

            if (cboxDadoPesquisa.SelectedIndex == 2)
            {//cpf
                dgvFornecedores.DataSource = null;
                dgvFornecedores.DataSource = bll.PesquisarCNPJ(txtPesquisa.Text);
                return;
            }
        }
    }
}
