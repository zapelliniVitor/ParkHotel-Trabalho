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

        private void ManutencaoQuartosItem_Click(object sender, EventArgs e)
        {
            FormManutençãoQuarto frm = new FormManutençãoQuarto();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void ManutencaoClientesItem_Click(object sender, EventArgs e)
        {
            FormManutençãoCliente frm = new FormManutençãoCliente();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void ManutencaoProdutosItem_Click(object sender, EventArgs e)
        {
            FormManutençãoProduto frm = new FormManutençãoProduto();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void ManutencaoFuncionariosItem_Click(object sender, EventArgs e)
        {
            FormManutençãoFuncionario frm = new FormManutençãoFuncionario();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void ManutencaoFornecedoresItem_Click(object sender, EventArgs e)
        {
            FormManutençãoFornecedor frm = new FormManutençãoFornecedor();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void PesquisaFuncionarioItem_Click(object sender, EventArgs e)
        {
            FormPesquisaFuncionario frm = new FormPesquisaFuncionario();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void PesquisaClienteItem_Click(object sender, EventArgs e)
        {
            FormPesquisaCliente frm = new FormPesquisaCliente();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void PesquisaQuartoItem_Click(object sender, EventArgs e)
        {
            FormPesquisaQuarto frm = new FormPesquisaQuarto();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void PesquisaProduto_Click(object sender, EventArgs e)
        {
            FormPesquisaProduto frm = new FormPesquisaProduto();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void PesquisaFornecedorItem_Click(object sender, EventArgs e)
        {
            FormPesquisaFornecedor frm = new FormPesquisaFornecedor();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReservas frm = new FormReservas();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void checkinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormManutençãoCheck_In frm = new FormManutençãoCheck_In();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
