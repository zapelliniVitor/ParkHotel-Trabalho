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
    public partial class FormPesquisaProduto : Form
    {
        public FormPesquisaProduto()
        {
            InitializeComponent();
        }

        ProdutoBLL bll = new ProdutoBLL();
        public Produto ProdutoSelecionado { get; set; }

        private void FormPesquisaProduto_Load(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = bll.LerTodos();
            cboxPesquisa.SelectedIndex = 0;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = bll.LerTodos();
                return;
            }

            if (cboxPesquisa.SelectedIndex == 1)
            {
                if (int.TryParse(txtPesquisa.Text, out int id))
                {//id
                    dgvProdutos.DataSource = null;
                    dgvProdutos.DataSource = bll.PesquisarID(id);
                    return;
                }
            }

            if (cboxPesquisa.SelectedIndex == 0)
            {//nome
                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = bll.PesquisarNome(txtPesquisa.Text);
                return;

            }
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvProdutos.Rows[e.RowIndex].Cells[0].Value;
            string nome = (string)dgvProdutos.Rows[e.RowIndex].Cells[1].Value;
            string descricao = (string)dgvProdutos.Rows[e.RowIndex].Cells[2].Value;
            double preco = (double)dgvProdutos.Rows[e.RowIndex].Cells[3].Value;
            int estoque = (int)dgvProdutos.Rows[e.RowIndex].Cells[4].Value;


            this.ProdutoSelecionado = new Produto()
            {
                ID = id,
                Nome = nome,
                Descricao = descricao,
                PrecoVenda = preco,
                quantidadeEstoque = estoque
            };

            this.Close();
        }
    }
}
