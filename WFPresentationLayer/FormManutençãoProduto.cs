﻿using BLL;
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

        ProdutoBLL bll = new ProdutoBLL();

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
            MessageBox.Show(bll.Inserir(prod));
            DGVProdutos.DataSource = null;
            DGVProdutos.DataSource = bll.LerTodos();
            FormCleaner.Clear(this);
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
            MessageBox.Show(bll.Atualizar(prod));
            DGVProdutos.DataSource = null;
            DGVProdutos.DataSource = bll.LerTodos();
            FormCleaner.Clear(this);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == null)
            {
                MessageBox.Show("Selecione um produto a ser excluido.");
                return;
            }
            MessageBox.Show(bll.delete(Convert.ToInt32(txtID.Text)));
            DGVProdutos.DataSource = null;
            DGVProdutos.DataSource = bll.LerTodos();
            FormCleaner.Clear(this);

        }

        private void FormManutençãoProduto_Load(object sender, EventArgs e)
        {
            DGVProdutos.DataSource = null;
            DGVProdutos.DataSource = bll.LerTodos();
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            FormPesquisaProduto frm = new FormPesquisaProduto();
            frm.ShowDialog();
            if(frm.ProdutoSelecionado != null)
            {
                Produto p = frm.ProdutoSelecionado;
                txtID.Text = p.ID.ToString();
                txtNome.Text = p.Nome;
                txtPreco.Text = p.PrecoVenda.ToString();
                txtQuantidade.Text = p.quantidadeEstoque.ToString();
                rtxtDescricao.Text = p.Descricao;
            }
        }
    }
}
