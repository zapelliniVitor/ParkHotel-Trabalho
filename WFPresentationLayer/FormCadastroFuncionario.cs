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
    public partial class FormCadastroFuncionario : Form
    {
        public FormCadastroFuncionario()
        {
            InitializeComponent();
        }

       

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string endereco = cmbCidade.Text + ", " + cmbEstado.Text;
            bool ehAtivo;
            if (chkÉAtivo.Checked)
            {
                ehAtivo = true;
            }
            else
            {
                ehAtivo = false;
            }
            bool ehAdmin;
            if (chkÉAdm.Checked)
            {
                ehAdmin = true;
            }
            else
            {
                ehAdmin = false;
            }
            Funcionario f = new Funcionario(txtNomeFuncionario.Text, mtxtCPFFuncionario.Text, mtxtRGFuncionario.Text,
                                        endereco, mtxtTelefoneFuncionario.Text, txtEmailFuncionario.Text, txtSenhaFuncionario.Text,
                                        ehAdmin, ehAtivo);

            FuncionarioBLL bll = new FuncionarioBLL();
            string menssagem = bll.cadastrarFuncionario(f);
            MessageBox.Show(menssagem);
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] cidades = null;
            if (cmbEstado.Text == "SC")
            {
                   cidades = new string[3] { "Timbó", "Blumenau", "Pomerode" };
            }
            else if (cmbEstado.Text == "SP")
            {
                  cidades = new string[3] { "São Paulo", "Americana", "Campinas" };
            }
            cmbCidade.DataSource = null;
            cmbCidade.DataSource = cidades;
        }
    }
}
