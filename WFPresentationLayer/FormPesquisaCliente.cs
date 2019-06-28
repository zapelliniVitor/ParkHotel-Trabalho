using BLL;
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
        
        private void FormPesquisaCliente_Load(object sender, EventArgs e)
        {
            cboxDadoPesquisa.SelectedIndex = 1;
            dgvClientes.DataSource = bll.LerTodos();
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
                {
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = bll.PesquisarID(id);
                        return;
                }
            }

            if (cboxDadoPesquisa.SelectedIndex == 1)
            {
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = bll.PesquisarNome(txtPesquisa.Text);
                    return;
                
            }
        }
    }
}
