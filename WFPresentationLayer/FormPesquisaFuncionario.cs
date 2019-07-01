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
    public partial class FormPesquisaFuncionario : Form
    {
        public FormPesquisaFuncionario()
        {
            InitializeComponent();
        }

        FuncionarioBLL bll = new FuncionarioBLL();

        public Funcionario funcionarioSelecionado { get; set; }

        private void FormPesquisaFuncionario_Load(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = null;
            dgvFuncionario.DataSource = bll.LerTodos();
            cmbOption.SelectedIndex = 0;
            mtxtCPF.Enabled = false;
        }

        private void cmbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOption.SelectedIndex == 0)
            {
                lblPesquisa.Text = "Digite o ID";
                txtItemPesquisado.Enabled = true;
                mtxtCPF.Enabled = false;
            }
            else if (cmbOption.SelectedIndex == 1)
            {
                lblPesquisa.Text = "Digite o Nome";
                txtItemPesquisado.Enabled = true;
                mtxtCPF.Enabled = false;
            }
            else if (cmbOption.SelectedIndex == 2)
            {
                txtItemPesquisado.Enabled = false;
                mtxtCPF.Enabled = true;
            }
            else if (cmbOption.SelectedIndex == 3)
            {
                txtItemPesquisado.Enabled = false;
                mtxtCPF.Enabled = false;
            }
        }

        private void dgvFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.funcionarioSelecionado = new Funcionario((int)this.dgvFuncionario.Rows[e.RowIndex].Cells[0].Value);
            this.Close();
        }

        private void txtItemPesquisado_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemPesquisado.Text))
            {
                dgvFuncionario.DataSource = null;
                dgvFuncionario.DataSource = bll.LerTodos();
                return;
            }

            if (cmbOption.SelectedIndex == 0)
            {
                dgvFuncionario.DataSource = null;
                int id = -1;
                if (int.TryParse(txtItemPesquisado.Text, out id))
                {
                    dgvFuncionario.DataSource = bll.lerPorId(id);
                }
                
            }
            else if (cmbOption.SelectedIndex == 1)
            {
                dgvFuncionario.DataSource = null;
                dgvFuncionario.DataSource = bll.lerPorNome(txtItemPesquisado.Text);
            }
            else if (cmbOption.SelectedIndex == 2)
            {
                dgvFuncionario.DataSource = null;
                dgvFuncionario.DataSource = bll.lerPorCPF(mtxtCPF.Text);
            }
            else if (cmbOption.SelectedIndex == 3)
            {
                dgvFuncionario.DataSource = null;
                dgvFuncionario.DataSource = bll.LerTodos();
            }
        }
    }
}
