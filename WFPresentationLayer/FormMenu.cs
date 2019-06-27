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


        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReservas frm = new FormReservas();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
