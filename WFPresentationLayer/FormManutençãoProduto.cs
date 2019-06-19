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
            string nome = txtNome.Text;
            string Descricao = rtxtDescricao.Text;
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
            
            Produto prod = new Produto(nome, Descricao, Preco, Quantidade);
            MessageBox.Show(new ProdutoBLL().Inserir(prod));
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string nome = txtNome.Text;
            string Descricao = rtxtDescricao.Text;
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

            Produto prod = new Produto(id, nome, Descricao, Preco, Quantidade);
            MessageBox.Show(new ProdutoBLL().Atualizar(prod));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
