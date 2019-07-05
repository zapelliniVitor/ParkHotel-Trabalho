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
            dgvFuncionarios.DataSource = null;
            dgvFuncionarios.DataSource = bll.LerTodos();
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
                dgvFuncionarios.DataSource = null;
                dgvFuncionarios.DataSource = bll.LerTodos();
            }
            else if (cmbOption.SelectedIndex == 4)
            {
                txtItemPesquisado.Enabled = false;
                mtxtCPF.Enabled = false;
                dgvFuncionarios.DataSource = null;
                dgvFuncionarios.DataSource = bll.LerAtivos();
            }
            else if (cmbOption.SelectedIndex == 5)
            {
                txtItemPesquisado.Enabled = false;
                mtxtCPF.Enabled = false;
                dgvFuncionarios.DataSource = null;
                dgvFuncionarios.DataSource = bll.LerInativos();
            }

        }

        private void dgvFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvFuncionarios.Rows[e.RowIndex].Cells[0].Value;
            string nome = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[1].Value;
            string cpf = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[2].Value;
            string rg = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[3].Value;
            string endereco = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[4].Value;
            string tel = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[5].Value;
            string email = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[6].Value;
            bool ehadmin = (bool)dgvFuncionarios.Rows[e.RowIndex].Cells[8].Value;
            bool ehativo = (bool)dgvFuncionarios.Rows[e.RowIndex].Cells[9].Value;




            this.funcionarioSelecionado = new Funcionario()
            {
                ID = id,
                Nome = nome,
                CPF = cpf,
                RG = rg,
                Endereco = endereco,
                Telefone = tel,
                Email = email,
                EhAdmin = ehadmin,
                EhAtivo = ehativo
            };

            this.Close();
        }

        private void txtItemPesquisado_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemPesquisado.Text))
            {
                dgvFuncionarios.DataSource = null;
                dgvFuncionarios.DataSource = bll.LerTodos();
                return;
            }

            if (cmbOption.SelectedIndex == 0)
            {
                dgvFuncionarios.DataSource = null;
                int id = -1;
                if (int.TryParse(txtItemPesquisado.Text, out id))
                {
                    dgvFuncionarios.DataSource = bll.lerPorId(id);
                }

            }
            else if (cmbOption.SelectedIndex == 1)
            {
                dgvFuncionarios.DataSource = null;
                dgvFuncionarios.DataSource = bll.lerPorNome(txtItemPesquisado.Text);
            }


        }

        private void mtxtCPF_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtxtCPF.Text.Replace(",","").Replace("-","").Replace(".","")))
            {
                dgvFuncionarios.DataSource = null;
                dgvFuncionarios.DataSource = bll.LerTodos();
                return;
            }

            if (cmbOption.SelectedIndex == 2)
            {
                dgvFuncionarios.DataSource = null;
                dgvFuncionarios.DataSource = bll.lerPorCPF(mtxtCPF.Text);
            }
        }
    }
}

