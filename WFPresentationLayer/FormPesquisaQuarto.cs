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
            else if(cmbOption.SelectedIndex == 2)
            {
                labelTextoPesuisa.Text = "Digite o Tipo do quarto";
                txtItemPesquisado.Enabled = true;
            }
            else if (cmbOption.SelectedIndex == 3)
            {
                labelTextoPesuisa.Text = "Clique em Pesquisar";
                txtItemPesquisado.Enabled = false;
            }
            else if (cmbOption.SelectedIndex == 4)
            {
                labelTextoPesuisa.Text = "Clique em Pesquisar";
                txtItemPesquisado.Enabled = false;
            }

        }

        private void dgvQuartos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvQuartos.Rows[e.RowIndex].Cells[0].Value;
            int tipo = (int)dgvQuartos.Rows[e.RowIndex].Cells[1].Value;
            string preco = (string)dgvQuartos.Rows[e.RowIndex].Cells[2].Value;
            int status = (int)dgvQuartos.Rows[e.RowIndex].Cells[3].Value;
            string descricao = (string)dgvQuartos.Rows[e.RowIndex].Cells[4].Value;
            int quarto = (int)dgvQuartos.Rows[e.RowIndex].Cells[5].Value;


            QuartoSelecionado = new Quarto()
            {
                ID = id,
                TipoQuarto = tipo,
                PrecoQuarto = preco,
                StatusQuarto = status,
                DescriçãoQuarto = descricao,
                n_Quarto = quarto
            };
            this.Close();
        }

        private void txtItemPesquisado_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemPesquisado.Text))
            {
                dgvQuartos.DataSource = null;
                dgvQuartos.DataSource = bll.LerTodos();
                return;
            }

            if (cmbOption.SelectedIndex == 0)
            {
                if (int.TryParse(txtItemPesquisado.Text, out int id))
                {
                    dgvQuartos.DataSource = null;
                    dgvQuartos.DataSource = bll.lerPorID(id);
                }
            }
            else if (cmbOption.SelectedIndex == 1)
            {
                if (int.TryParse(txtItemPesquisado.Text, out int numero))
                {
                    dgvQuartos.DataSource = null;
                    dgvQuartos.DataSource = bll.lerPorNum(numero);
                }
            }
            else if(cmbOption.SelectedIndex == 2)
            {
                if (int.TryParse(txtItemPesquisado.Text, out int tipo))
                {
                    dgvQuartos.DataSource = null;
                    dgvQuartos.DataSource = bll.lerPorTipo(tipo);
                }
            }
            else if (cmbOption.SelectedIndex == 3)
            {
                dgvQuartos.DataSource = null;
                dgvQuartos.DataSource = bll.lerLivres();
            }
            else if (cmbOption.SelectedIndex == 4)
            {
                dgvQuartos.DataSource = null;
                dgvQuartos.DataSource = bll.LerTodos();
            }
        }
    }
}
