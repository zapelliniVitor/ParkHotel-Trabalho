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
    public partial class FormCadastroFuncionario : Form
    {
        public FormCadastroFuncionario()
        {
            InitializeComponent();
            txtID.Enabled = false;
        }

        FuncionarioBLL bll = new FuncionarioBLL();

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

            
            string menssagem = bll.cadastrarFuncionario(f);
            MessageBox.Show(menssagem);

            dgvFuncionarios.DataSource = null;
            dgvFuncionarios.DataSource = bll.LerTodos();
            apagarDados();
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
            apagarDados();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvFuncionarios.Rows[e.RowIndex].Cells[0].Value;
            string nome = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[1].Value;
            string cpf = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[2].Value;
            string rg = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[3].Value;
            string endereco = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[4].Value;
            string telefone = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[5].Value;
            string email = (string)dgvFuncionarios.Rows[e.RowIndex].Cells[6].Value;
            bool ehAdmin = (bool)dgvFuncionarios.Rows[e.RowIndex].Cells[8].Value;
            bool ehAtivo = (bool)dgvFuncionarios.Rows[e.RowIndex].Cells[9].Value;

            txtID.Text = id.ToString();
            txtNomeFuncionario.Text = nome;
            mtxtCPFFuncionario.Text = cpf;
            mtxtRGFuncionario.Text = rg;
            if (endereco.Contains("SC"))
            {
                cmbEstado.Text = "SC";
            }
            if (endereco.Contains("SP"))
            {
                cmbEstado.Text = "SP";
            }
            if (endereco.Contains("Pomerode"))
            {
                cmbCidade.Text = "Pomerode";
            }
            if (endereco.Contains("Blumenau"))
            {
                cmbCidade.Text = "Blumenau";
            }
            if (endereco.Contains("Timbó"))
            {
                cmbCidade.Text = "Timbó";
            }
            if (endereco.Contains("São Paulo"))
            {
                cmbCidade.Text = "São Paulo";
            }
            if (endereco.Contains("Americana"))
            {
                cmbCidade.Text = "Americana";
            }
            if (endereco.Contains("Campinas"))
            {
                cmbCidade.Text = "Campinas";
            }
            mtxtTelefoneFuncionario.Text = telefone;
            txtEmailFuncionario.Text = email;
            if (ehAdmin)
            {
                chkÉAdm.Checked = true;
            }
            if (ehAtivo)
            {
                chkÉAtivo.Checked = true;
            }
            
        }

        private void FormCadastroFuncionario_Load(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = bll.LerTodos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
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
            Funcionario f = new Funcionario(Convert.ToInt32(txtID.Text),txtNomeFuncionario.Text, mtxtCPFFuncionario.Text, mtxtRGFuncionario.Text,
                                        endereco, mtxtTelefoneFuncionario.Text, txtEmailFuncionario.Text, txtSenhaFuncionario.Text,
                                        ehAdmin, ehAtivo);
            string menssagem = new FuncionarioBLL().atualizarFuncionario(f);
            MessageBox.Show(menssagem);
            dgvFuncionarios.DataSource = null;
            dgvFuncionarios.DataSource = bll.LerTodos();
            apagarDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja apagar os dados do funcionario?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
            string mensagem = new FuncionarioDAO().Delete(Convert.ToInt32(txtID.Text));
            MessageBox.Show(mensagem);
            dgvFuncionarios.DataSource = null;
            dgvFuncionarios.DataSource = bll.LerTodos();
            apagarDados();

        }   

        private void apagarDados()
        {
            FormCleaner.Clear(this);
        }
    }
}
