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

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManutençãoFuncionario frm = new FormManutençãoFuncionario();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManutençãoCliente frm = new FormManutençãoCliente();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManutençãoProduto frm = new FormManutençãoProduto();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaFuncionario frm = new FormPesquisaFuncionario();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaCliente frm = new FormPesquisaCliente();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
