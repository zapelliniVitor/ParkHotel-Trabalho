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

        ReservaBLL bll = new ReservaBLL();

        private void FormReservas_Load(object sender, EventArgs e)
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = bll.LerTodos();
            cboxPesquisa.SelectedIndex = 0;
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
            MessageBox.Show(bll.Cadastro(rsv));

            dgvReservas.DataSource = null;
            dgvReservas.DataSource = bll.LerTodos();
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
        
        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            FormPesquisaCliente frm = new FormPesquisaCliente();
            frm.ShowDialog();
            if (frm.clienteSelecionado != null)
            {
                this.txtIDCliente.Text = frm.clienteSelecionado.ID.ToString();
            }
        }

        private void btnPesquisaFuncionario_Click(object sender, EventArgs e)
        {
            FormPesquisaFuncionario frm = new FormPesquisaFuncionario();
            frm.ShowDialog();
            if (frm.funcionarioSelecionado != null)
            {
                this.txtIDFuncionario.Text = frm.funcionarioSelecionado.ID.ToString();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
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
            MessageBox.Show(bll.Atualizar(rsv));

        }

        private void dgvReservas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvReservas.Rows[e.RowIndex].Cells[0].Value;
            Cliente idC = (Cliente)dgvReservas.Rows[e.RowIndex].Cells[1].Value;
            Quarto idQ = (Quarto)dgvReservas.Rows[e.RowIndex].Cells[2].Value;
            Funcionario idF = (Funcionario)dgvReservas.Rows[e.RowIndex].Cells[3].Value;
            DateTime entrada = (DateTime)dgvReservas.Rows[e.RowIndex].Cells[4].Value;
            DateTime saidaP = (DateTime)dgvReservas.Rows[e.RowIndex].Cells[5].Value;
            


            txtIDReserva.Text = id.ToString();
            txtIDCliente.Text = idC.ID.ToString();
            dtpEntrada.Value = entrada;
            dtpSaidaPrevista.Value = saidaP;
            txtIDFuncionario.Text = idF.ID.ToString();
            txtIDQuarto.Text = idQ.ID.ToString();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDCliente.Text))
            {
                MessageBox.Show("Informar ID");
                return;
            }

            DialogResult result = MessageBox.Show("Deseja cancelar essa reserva?", "ATENÇÂO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                MessageBox.Show(new ReservaBLL().delete(Convert.ToInt32(txtIDCliente.Text)));
            }
            FormCleaner.Clear(this);
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = bll.LerTodos();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                dgvReservas.DataSource = null;
                dgvReservas.DataSource = bll.LerTodos();
                return;
            }

            

            if (cboxPesquisa.SelectedIndex == 0)
            {//nome
                dgvReservas.DataSource = null;
                dgvReservas.DataSource = bll.PesquisarNome(txtPesquisa.Text);
                return;

            }

            if (cboxPesquisa.SelectedIndex == 1)
            {//quarto
                if (int.TryParse(txtPesquisa.Text, out int id))
                {
                    dgvReservas.DataSource = null;
                    dgvReservas.DataSource = bll.PesquisarQuarto(txtPesquisa.Text);
                    return;
                }
            }
            
            if (cboxPesquisa.SelectedIndex == 2)
            {
                if (int.TryParse(txtPesquisa.Text, out int id))
                {//id
                    dgvReservas.DataSource = null;
                    dgvReservas.DataSource = bll.PesquisarID(id);
                    return;
                }
            }
        }
    }
}
