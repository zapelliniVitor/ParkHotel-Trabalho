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
            if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
            {
                MessageBox.Show("ID Cliente não informado");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtIdFunc.Text))
            {
                MessageBox.Show("ID Funcionario não informado");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtIdReserva.Text))
            {
                MessageBox.Show("ID Reserva não informado");
                return;
            }
            if (dtpSaida.Value == DateTime.Now)
            {
                MessageBox.Show("Data de saida não pode ser a mesma do Check - in");
                return;
            }

            Check_in chk = new Check_in(Convert.ToInt32(txtIdReserva.Text), DateTime.Now, dtpSaida.Value, Convert.ToInt32(txtIdCliente.Text), Convert.ToInt32(txtIdFunc.Text));
            MessageBox.Show(bll.cadastrar(chk));
        }
    }
}
