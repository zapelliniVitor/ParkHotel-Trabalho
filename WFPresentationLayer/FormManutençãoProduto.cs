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
    public partial class FormManutençãoProduto : Form
    {
        public FormManutençãoProduto()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            double Preco = 0;
            int Quantidade = 0;

            if(!double.TryParse(txtPreco.Text, out Preco))
            {
                MessageBox.Show("Preço inválido");
                return;
            }
            if(!int.TryParse(txtQuantidade.Text, out Quantidade))
            {
                MessageBox.Show("Quantidade Inválida");
                return;
            }
            
            Produto prod = new Produto(txtNome.Text, rtxtDescricao.Text, Preco, Quantidade);
            MessageBox.Show(new ProdutoBLL().Inserir(prod));
            DGVProdutos.DataSource = null;
            DGVProdutos.DataSource = new ProdutoBLL().LerTodos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            double Preco = 0;
            int Quantidade = 0;

            if (!double.TryParse(txtPreco.Text, out Preco))
            {
                MessageBox.Show("Preço inválido");
                return;
            }
            if (!int.TryParse(txtQuantidade.Text, out Quantidade))
            {
                MessageBox.Show("Quantidade Inválida");
                return;
            }

            Produto prod = new Produto(id, txtNome.Text, rtxtDescricao.Text, Preco, Quantidade);
            MessageBox.Show(new ProdutoBLL().Atualizar(prod));
            DGVProdutos.DataSource = null;
            DGVProdutos.DataSource = new ProdutoBLL().LerTodos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == null)
            {
                MessageBox.Show("Selecione um produto a ser excluido.");
                return;
            }
            MessageBox.Show(new ProdutoBLL().delete(Convert.ToInt32(txtID.Text)));
            DGVProdutos.DataSource = null;
            DGVProdutos.DataSource = new ProdutoBLL().LerTodos();
        }

        private void FormManutençãoProduto_Load(object sender, EventArgs e)
        {
            DGVProdutos.DataSource = null;
            DGVProdutos.DataSource = new ProdutoBLL().LerTodos();
        }

        private void DGVProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)DGVProdutos.Rows[e.RowIndex].Cells[0].Value;
            string nome = (string)DGVProdutos.Rows[e.RowIndex].Cells[1].Value;
            string descricao = (string)DGVProdutos.Rows[e.RowIndex].Cells[2].Value;
            double precoVenda = (double)DGVProdutos.Rows[e.RowIndex].Cells[3].Value;
            int estoque = (int)DGVProdutos.Rows[e.RowIndex].Cells[4].Value;

            txtID.Text = Convert.ToString(id);
            txtNome.Text = nome;
            rtxtDescricao.Text = descricao;
            txtPreco.Text = Convert.ToString(precoVenda);
            txtQuantidade.Text = Convert.ToString(estoque);


        }
    }
}
