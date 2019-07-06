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
    public partial class FormPesquisaCliente : Form
    {
        ClienteBLL bll = new ClienteBLL();

        public FormPesquisaCliente()
        {
            InitializeComponent();
        }
        
        public Cliente clienteSelecionado { get; set; }

        private void FormPesquisaCliente_Load(object sender, EventArgs e)
        {
            cboxDadoPesquisa.SelectedIndex = 1;
            dgvClientes.DataSource = bll.LerTodos();
            cboxDadoPesquisa.SelectedIndex = 0;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = bll.LerTodos();
                return;
            }

            if(cboxDadoPesquisa.SelectedIndex == 0)
            {
                if(int.TryParse(txtPesquisa.Text, out int id))
                {//id
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = bll.PesquisarID(id);
                        return;
                }
            }

            if (cboxDadoPesquisa.SelectedIndex == 1)
            {//nome
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = bll.PesquisarNome(txtPesquisa.Text);
                    return;
                
            }

            if (cboxDadoPesquisa.SelectedIndex == 2)
            {//cpf
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = bll.PesquisarCPF(txtPesquisa.Text);
                return;
            }

            if (cboxDadoPesquisa.SelectedIndex == 3)
            {//rg
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = bll.PesquisarRG(txtPesquisa.Text);
                return;
            }

            if (cboxDadoPesquisa.SelectedIndex == 4)
            {//email
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = bll.PesquisarEmail(txtPesquisa.Text);
                return;
            }

            if (cboxDadoPesquisa.SelectedIndex == 5)
            {//telefone
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = bll.PesquisarTelefone(txtPesquisa.Text);
                return;
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvClientes.Rows[e.RowIndex].Cells[0].Value;
            string nome = (string)dgvClientes.Rows[e.RowIndex].Cells[1].Value;
            string cpf = (string)dgvClientes.Rows[e.RowIndex].Cells[2].Value;
            string rg = (string)dgvClientes.Rows[e.RowIndex].Cells[3].Value;
            string tel1 = (string)dgvClientes.Rows[e.RowIndex].Cells[4].Value;
            string tel2 = (string)dgvClientes.Rows[e.RowIndex].Cells[5].Value;
            string email = (string)dgvClientes.Rows[e.RowIndex].Cells[6].Value;


            this.clienteSelecionado = new Cliente()
            {
                ID = id,
                Nome = nome,
                CPF = cpf,
                RG = rg,
                Telefone1 = tel1,
                Telefone2 = tel2,
                Email = email
            };
            
            this.Close();
        }
    }
}
