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
    public partial class FormPesquisaQuarto : Form
    {
        public FormPesquisaQuarto()
        {
            InitializeComponent();
        }

        public Quarto QuartoSelecionado { get; set; }

        QuartoBLL bll = new QuartoBLL();

        private void FormPesquisaQuarto_Load(object sender, EventArgs e)
        {
            dgvQuartos.DataSource = null;
            dgvQuartos.DataSource = bll.LerTodos();
            cmbOption.SelectedIndex = 0;
        }

        private void cmbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOption.SelectedIndex == 0)
            {
                labelTextoPesuisa.Text = "Digite o ID";
                txtItemPesquisado.Enabled = true;
            }
            else if (cmbOption.SelectedIndex == 1)
            {
                labelTextoPesuisa.Text = "Digite o Nº QUARTO";
                txtItemPesquisado.Enabled = true;
            }
            else if (cmbOption.SelectedIndex == 2)
            {
                dgvQuartos.DataSource = null;
                dgvQuartos.DataSource = bll.lerLivres();
                txtItemPesquisado.Text = null;
                txtItemPesquisado.Enabled = false;
            }
            else if (cmbOption.SelectedIndex == 3)
            {
                dgvQuartos.DataSource = null;
                dgvQuartos.DataSource = bll.LerTodos();
                txtItemPesquisado.Text = null;
                txtItemPesquisado.Enabled = false;
            }

        }

        private void dgvQuartos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.QuartoSelecionado = new Quarto((int)this.dgvQuartos.Rows[e.RowIndex].Cells[0].Value);
            this.Close();
        }

        private void txtItemPesquisado_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemPesquisado.Text))
            {
                dgvQuartos.DataSource = null;
                dgvQuartos.DataSource = bll.LerTodos();
            }
            else if (cmbOption.SelectedIndex == 0)
            {
                if(int.TryParse(txtItemPesquisado.Text, out int id))
                {
                    dgvQuartos.DataSource = null;
                    dgvQuartos.DataSource = bll.lerPorID(id);
                    return;
                }
                dgvQuartos.DataSource = null;
                return;
            }
            else if (cmbOption.SelectedIndex == 1)
            {
                if (int.TryParse(txtItemPesquisado.Text, out int num))
                {
                    dgvQuartos.DataSource = null;
                    dgvQuartos.DataSource = bll.lerPorNum(num);
                    return;
                }
                dgvQuartos.DataSource = null;
                return;
            }
        }
    }
}
