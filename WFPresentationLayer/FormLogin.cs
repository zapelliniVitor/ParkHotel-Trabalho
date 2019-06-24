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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            string email = txtUsuario.Text;
            string senha = txtSenha.Text;
            LoginResponse resposta = new LoginBLL().Autenticar(email, senha);

            if (!resposta.Sucesso)
            {
                MessageBox.Show(resposta.Mensagem);
            }
            else
            {
                FormMenu frm = new FormMenu();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }
    }
}
