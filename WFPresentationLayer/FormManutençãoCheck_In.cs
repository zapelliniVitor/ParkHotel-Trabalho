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
    public partial class FormManutençãoCheck_In : Form
    {
        public FormManutençãoCheck_In()
        {
            InitializeComponent();
        }

        Check_inBLL bll = new Check_inBLL();

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            FormPesquisaCliente frm = new FormPesquisaCliente();
            frm.ShowDialog();
            if (frm.clienteSelecionado != null)
            {
                this.txtIdCliente.Text = frm.clienteSelecionado.ID.ToString();
            }
        }

        private void btnPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            FormPesquisaFuncionario frm = new FormPesquisaFuncionario();
            frm.ShowDialog();
            if (frm.funcionarioSelecionado != null)
            {
                this.txtIdFunc.Text = frm.funcionarioSelecionado.ID.ToString();
            }
        }

        private void btnCheck_in_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
            {
                sb.AppendLine("ID Cliente não informado");
            }
            if (string.IsNullOrWhiteSpace(txtIdFunc.Text))
            {
                sb.AppendLine("ID Funcionario não informado");
            }
            if (string.IsNullOrWhiteSpace(txtIdReserva.Text) && rbReserva.Checked == true)
            {
                sb.AppendLine("ID Reserva não informado");
            }
            if (string.IsNullOrWhiteSpace(txtIDQuarto.Text) && rbSemReserva.Checked == true)
            {
                sb.AppendLine("ID do quarto não informado");
            }
            if (dtpSaida.Value == DateTime.Now)
            {
                sb.AppendLine("Data de saida não pode ser a mesma do Check - in");
            }
            if (sb.Length != 0)
            {
                MessageBox.Show(sb.ToString());
                return;
            }

            if (rbReserva.Checked == true)
            {
                Check_in chk = new Check_in(Convert.ToInt32(txtIdReserva.Text), DateTime.Now, dtpSaida.Value, Convert.ToInt32(txtIdCliente.Text), Convert.ToInt32(txtIdFunc.Text));
                MessageBox.Show(bll.cadastrar(chk));
            }
            if (rbSemReserva.Checked == true)
            {
                Check_in chk = new Check_in(DateTime.Now, dtpSaida.Value, Convert.ToInt32(txtIdCliente.Text), Convert.ToInt32(txtIdFunc.Text), Convert.ToInt32(txtIDQuarto.Text));
                MessageBox.Show(bll.inserir(chk));
            }
        }

        private void rbReserva_CheckedChanged(object sender, EventArgs e)
        {
            txtIdReserva.Enabled = true;
            txtIDQuarto.Enabled = false;
            btnPesquisarReserva.Enabled = true;
            btnPesquisarQuarto.Enabled = false;
            txtIDQuarto.Text = null;
        }

        private void rbSemReserva_CheckedChanged(object sender, EventArgs e)
        {
            txtIdReserva.Enabled = false;
            txtIDQuarto.Enabled = true;
            btnPesquisarReserva.Enabled = false;
            btnPesquisarQuarto.Enabled = true;
            txtIdReserva.Text = null;
        }

        private void btnPesquisarReserva_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não funciona ainda.");
        }

        private void btnPesquisarQuarto_Click(object sender, EventArgs e)
        {
            FormPesquisaQuarto frm = new FormPesquisaQuarto();
            frm.ShowDialog();
            if (frm.QuartoSelecionado != null)
            {
                this.txtIDQuarto.Text = frm.QuartoSelecionado.ID.ToString();
            }
        }
    }
}
