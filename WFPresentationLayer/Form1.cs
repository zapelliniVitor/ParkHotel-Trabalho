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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string CPF = txtCPF.Text;
            string RG = txtRG.Text;
            string Email = txtEmail.Text;
            string Fone1 = txtFone1.Text;
            string Fone2 = txtFone2.Text;

            Cliente cli = new Cliente(nome, CPF, RG, Fone1, Fone2, Email);
            MessageBox.Show(new ClienteBLL().Inserir(cli));
        }
    }
}
