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
        }

        private void cmbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOption.Text == "ID")
            {
                labelTextoPesuisa.Text = "Digite o ID";
                txtItemPesquisado.Enabled = true;
            }
            else if (cmbOption.Text == "Nº QUARTO")
            {
                labelTextoPesuisa.Text = "Digite o Nº QUARTO";
                txtItemPesquisado.Enabled = true;
            }
            else if (cmbOption.Text == "LIVRES")
            {
                labelTextoPesuisa.Text = "Clique em Pesquisar";
                txtItemPesquisado.Enabled = false;
            }
            else if (cmbOption.Text == "TODOS")
            {
                labelTextoPesuisa.Text = "Clique em Pesquisar";
                txtItemPesquisado.Enabled = false;
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cmbOption.Text == "ID")
            {
                dgvQuartos.DataSource = null;
                dgvQuartos.DataSource = bll.lerPorID(Convert.ToInt32(txtItemPesquisado.Text));
            }
            else if (cmbOption.Text == "Nº QUARTO")
            {
                dgvQuartos.DataSource = null;
                dgvQuartos.DataSource = bll.lerPorNum(Convert.ToInt32(txtItemPesquisado.Text));
            }
            else if (cmbOption.Text == "LIVRES")
            {
                dgvQuartos.DataSource = null;
                dgvQuartos.DataSource = bll.lerLivres();
            }
            else if (cmbOption.Text == "TODOS")
            {
                dgvQuartos.DataSource = null;
                dgvQuartos.DataSource = bll.LerTodos();
            }

        }

        private void dgvQuartos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvQuartos.Rows[e.RowIndex].Cells[0].Value;
            int tipo = (int)dgvQuartos.Rows[e.RowIndex].Cells[1].Value;
            string preco = (string)dgvQuartos.Rows[e.RowIndex].Cells[2].Value;
            int status = (int)dgvQuartos.Rows[e.RowIndex].Cells[3].Value;
            string descricao = (string)dgvQuartos.Rows[e.RowIndex].Cells[4].Value;
            int numero = (int)dgvQuartos.Rows[e.RowIndex].Cells[5].Value;


            this.QuartoSelecionado = new Quarto()
            {
                ID = id,
                TipoQuarto = tipo,
                PrecoQuarto = preco,
                StatusQuarto = status,
                DescriçãoQuarto = descricao,
                n_Quarto = numero
            };
            this.Close();
        }
    }
}
