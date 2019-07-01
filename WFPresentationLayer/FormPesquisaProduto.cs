using BLL;
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

        private void FormPesquisaProduto_Load(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = bll.LerTodos();
            cboxDadoPesquisa.SelectedIndex = 0;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = bll.LerTodos();
                return;
            }

            if (cboxDadoPesquisa.SelectedIndex == 0)
            {
                if (int.TryParse(txtPesquisa.Text, out int id))
                {//id
                    dgvProdutos.DataSource = null;
                    dgvProdutos.DataSource = bll.PesquisarID(id);
                    return;
                }
            }

            if (cboxDadoPesquisa.SelectedIndex == 1)
            {//nome
                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = bll.PesquisarNome(txtPesquisa.Text);
                return;

            }

            if (cboxDadoPesquisa.SelectedIndex == 2)
            {//descricao
                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = bll.PesquisarDescricao(txtPesquisa.Text);
                return;
            }
        }
    }
}
