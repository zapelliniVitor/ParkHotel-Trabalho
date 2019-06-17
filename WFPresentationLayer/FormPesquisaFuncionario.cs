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
    public partial class FormPesquisaFuncionario : Form
    {
        public FormPesquisaFuncionario()
        {
            InitializeComponent();
        }
        FuncionarioBLL bll = new FuncionarioBLL();

        private void FormPesquisaFuncionario_Load(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = null;
            dgvFuncionario.DataSource = bll.LerTodos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = null;
            dgvFuncionario.DataSource = bll.lerPorId(Convert.ToInt32(txtID.Text));
        }
    }
}
