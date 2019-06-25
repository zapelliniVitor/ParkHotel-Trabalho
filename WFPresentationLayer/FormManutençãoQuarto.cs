using BLL;
using DAO;
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
    public partial class FormManutençãoQuarto : Form
    {
        public FormManutençãoQuarto()
        {
            InitializeComponent();
            
        }

        QuartoBLL bll = new QuartoBLL();

        private void FormManutençãoQuarto_Load(object sender, EventArgs e)
        {
            dgvQuartos.DataSource = null;
            dgvQuartos.DataSource = bll.LerTodos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            #region TipoQuarto
            int tipoQuarto = 0;
            if (cmbTipoQuarto.Text.Contains("1"))
            {
                tipoQuarto = 1;
            }
            else if (cmbTipoQuarto.Text.Contains("2"))
            {
                tipoQuarto = 2;
            }
            else if (cmbTipoQuarto.Text.Contains("3"))
            {
                tipoQuarto = 3;
            }
            else if (cmbTipoQuarto.Text.Contains("4"))
            {
                tipoQuarto = 4;
            }
            else if (cmbTipoQuarto.Text.Contains("5"))
            {
                tipoQuarto = 5;
            }
            #endregion

            #region StatusQuarto
            int statusQuarto = 0;
            if (cmbStatusQuarto.Text.Contains("1"))
            {
                statusQuarto = 1;
            }
            else if (cmbStatusQuarto.Text.Contains("2"))
            {
                statusQuarto = 2;
            }
            else if (cmbStatusQuarto.Text.Contains("3"))
            {
                statusQuarto = 3;
            }
            else if (cmbStatusQuarto.Text.Contains("4"))
            {
                statusQuarto = 4;
            }
            #endregion

            Quarto quarto = new Quarto(tipoQuarto, txtPreco.Text, statusQuarto, rtxtDescricao.Text, Convert.ToInt32(txtNQuarto.Text));
            MessageBox.Show(bll.CadastrarQuarto(quarto));
            dgvQuartos.DataSource = null;
            dgvQuartos.DataSource = bll.LerTodos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            #region TipoQuarto
            int tipoQuarto = 0;
            if (cmbTipoQuarto.Text.Contains("1"))
            {
                tipoQuarto = 1;
            }
            else if (cmbTipoQuarto.Text.Contains("2"))
            {
                tipoQuarto = 2;
            }
            else if (cmbTipoQuarto.Text.Contains("3"))
            {
                tipoQuarto = 3;
            }
            else if (cmbTipoQuarto.Text.Contains("4"))
            {
                tipoQuarto = 4;
            }
            else if (cmbTipoQuarto.Text.Contains("5"))
            {
                tipoQuarto = 5;
            }
            #endregion

            #region StatusQuarto
            int statusQuarto = 0;
            if (cmbStatusQuarto.Text.Contains("1"))
            {
                statusQuarto = 1;
            }
            else if (cmbStatusQuarto.Text.Contains("2"))
            {
                statusQuarto = 2;
            }
            else if (cmbStatusQuarto.Text.Contains("3"))
            {
                statusQuarto = 3;
            }
            else if (cmbStatusQuarto.Text.Contains("4"))
            {
                statusQuarto = 4;
            }
            #endregion

            double preco = 0;
            for (int i = 0; i < txtPreco.Text.Length; i++)
            {
                if (!double.IsNaN(Convert.ToDouble(txtPreco.Text)))
                {
                    int I = Convert.ToInt32(txtPreco.Text[i]);
                    preco += I;
                }
            }

            Quarto quarto = new Quarto(tipoQuarto, txtPreco.Text, statusQuarto, rtxtDescricao.Text, Convert.ToInt32(txtNQuarto.Text));
            MessageBox.Show(bll.AtualizarQuarto(quarto));
            dgvQuartos.DataSource = null;
            dgvQuartos.DataSource = bll.LerTodos();
            FormCleaner.Clear(this);
        }

        private void dgvQuartos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvQuartos.Rows[e.RowIndex].Cells[0].Value;
            int tipoQuarto = (int)dgvQuartos.Rows[e.RowIndex].Cells[1].Value;
            string preco = (string)dgvQuartos.Rows[e.RowIndex].Cells[2].Value;
            int status = (int)dgvQuartos.Rows[e.RowIndex].Cells[3].Value;
            string descricao = (string)dgvQuartos.Rows[e.RowIndex].Cells[4].Value;
            int nQuarto = (int)dgvQuartos.Rows[e.RowIndex].Cells[5].Value;

            txtID.Text = Convert.ToString(id);
            if (tipoQuarto == 1)
            {
                cmbTipoQuarto.Text = "1 - Suite Dupla";
            }
            else if (tipoQuarto == 2)
            {
                cmbTipoQuarto.Text = "2 - Suite Simples";
            }
            else if (tipoQuarto == 3)
            {
                cmbTipoQuarto.Text = "3 - Quarto Duplo";
            }
            else if (tipoQuarto == 4)
            {
                cmbTipoQuarto.Text = "4 - Quarto Simples";
            }
            else if (tipoQuarto == 5)
            {
                cmbTipoQuarto.Text = "5 - Quarto Com Beliche";
            }
            txtPreco.Text = preco;
            if (status == 1)
            {
                cmbStatusQuarto.Text = "1 - Livre";
            }
            else if (status == 2)
            {
                cmbStatusQuarto.Text = "2 - Ocupado";
            }
            else if (status == 3)
            {
                cmbStatusQuarto.Text = "3 - Em Limpeza";
            }
            else if (status == 4)
            {
                cmbStatusQuarto.Text = "4 - Em Manutenção";
            }
            txtNQuarto.Text = Convert.ToString(nQuarto);
            rtxtDescricao.Text = descricao;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja apagar os dados do Quarto?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            MessageBox.Show(new QuartoDAO().excluir(Convert.ToInt32(txtID.Text)).Mensagem);
            dgvQuartos.DataSource = null;
            dgvQuartos.DataSource = bll.LerTodos();
            FormCleaner.Clear(this);
        }
    }
}
