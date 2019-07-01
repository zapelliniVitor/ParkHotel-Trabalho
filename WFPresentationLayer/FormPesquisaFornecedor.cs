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
    public partial class FormPesquisaFornecedor : Form
    {
        public FormPesquisaFornecedor()
        {
            InitializeComponent();
        }

        FornecedorBLL bll = new FornecedorBLL();

        private void FormPesquisaFornecedor_Load(object sender, EventArgs e)
        {
            cboxDadoPesquisa.SelectedIndex = 0;
            dgvFornecedores.DataSource = bll.LerTodos();
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
            {//Email
                dgvFornecedores.DataSource = null;
                dgvFornecedores.DataSource = bll.PesquisarEmail(txtPesquisa.Text);
                return;
            }
        }
    }
}
