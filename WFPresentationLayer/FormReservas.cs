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
    public partial class FormReservas : Form
    {
        public FormReservas()
        {
            InitializeComponent();
        }

        private void FormReservas_Load(object sender, EventArgs e)
        {
            dgvReservas.DataSource = null;
           // dgvReservas.DataSource = 
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrWhiteSpace(txtIDCliente.Text))
            {
                sb.AppendLine("ID do Cliente não informado.");
            }
            if (string.IsNullOrWhiteSpace(txtIDFuncionario.Text))
            {
                sb.AppendLine("ID do Funcionário não informado.");
            }
            if (string.IsNullOrWhiteSpace(txtIDQuarto.Text))
            {
                sb.AppendLine("ID do Quarto não informado.");
            }
            if (sb.Length != 0)
            {
                MessageBox.Show(sb.ToString());
                return;
            }

            int idC = Convert.ToInt32(txtIDCliente.Text);
            int idF = Convert.ToInt32(txtIDFuncionario.Text);
            int idQ = Convert.ToInt32(txtIDQuarto.Text);

            
            Reserva rsv = new Reserva(idC, dtpEntrada.Value, dtpSaidaPrevista.Value, idF, idQ);
            MessageBox.Show(new ReservaBLL().Cadastro(rsv));
            
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
