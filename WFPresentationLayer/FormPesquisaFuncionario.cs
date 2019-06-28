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
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cmbOption.Text == "ID")
            {
                dgvFuncionario.DataSource = null;
                dgvFuncionario.DataSource = bll.lerPorId(Convert.ToInt32(txtItemPesquisado.Text));
            }
            else if (cmbOption.Text == "NOME")
            {
                dgvFuncionario.DataSource = null;
                dgvFuncionario.DataSource = bll.lerPorNome(txtItemPesquisado.Text);
            }
            else if (cmbOption.Text == "CPF")
            {
                dgvFuncionario.DataSource = null;
                dgvFuncionario.DataSource = bll.lerPorCPF(mtxtCPF.Text);
            }
            else if (cmbOption.Text == "TODOS")
            {
                dgvFuncionario.DataSource = null;
                dgvFuncionario.DataSource = bll.LerTodos();
            }
        }

        private void cmbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOption.Text == "ID")
            {
                lblPesquisa.Text = "Digite o ID";
                txtItemPesquisado.Enabled = true;
                mtxtCPF.Enabled = false;
            }
            else if (cmbOption.Text == "NOME")
            {
                lblPesquisa.Text = "Digite o Nome";
                txtItemPesquisado.Enabled = true;
                mtxtCPF.Enabled = false;
            }
            else if (cmbOption.Text == "CPF")
            {
                txtItemPesquisado.Enabled = false;
                mtxtCPF.Enabled = true;
            }
            else if (cmbOption.Text == "TODOS")
            {
                lblPesquisa.Text = "Clique em pesquisar";
                txtItemPesquisado.Enabled = false;
                mtxtCPF.Enabled = false;
            }
        }

        private void dgvFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.funcionarioSelecionado = new Funcionario((int)this.dgvFuncionario.Rows[e.RowIndex].Cells[0].Value);
            this.Close();
        }
    }
}
