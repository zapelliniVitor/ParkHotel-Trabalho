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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionario frm = new FormCadastroFuncionario();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void manutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCliente frm = new FormCadastroCliente();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaFuncionario frm = new FormPesquisaFuncionario();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void PesquisarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaCliente frm = new FormPesquisaCliente();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void manutençãoProdutosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormManutençãoProduto frm = new FormManutençãoProduto();
        }
    }
}
