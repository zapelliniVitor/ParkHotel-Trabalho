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
    public partial class FormPesquisaCheckIn : Form
    {
        public FormPesquisaCheckIn()
        {
            InitializeComponent();
        }

        Check_inBLL bll = new Check_inBLL();

        private void FormPesquisaCheckIn_Load(object sender, EventArgs e)
        {
            dgvCheckIN.DataSource = null;
            dgvCheckIN.DataSource = bll.lerTodos();
        }
    }
}
