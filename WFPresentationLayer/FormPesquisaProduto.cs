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
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == null)
            {
                MessageBox.Show("Informe um ID a ser pesquisado.");
                return;
            }

            FormCleaner.Clear(this);
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = bll.LerPorID(Convert.ToInt32(txtID.Text));
        }
    }
}
