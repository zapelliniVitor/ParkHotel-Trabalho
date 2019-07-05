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
    public partial class FormPesquisaReserva : Form
    {
        public FormPesquisaReserva()
        {
            InitializeComponent();
        }

        ReservaBLL bll = new ReservaBLL();

        public Reserva ReservaSelecionada { get; set; }

        private void FormPesquisaReserva_Load(object sender, EventArgs e)
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = bll.LerTodos();
        }

        private void dgvReservas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ReservaSelecionada = new Reserva((int)this.dgvReservas.Rows[e.RowIndex].Cells[0].Value);
            this.Close();
        }
    }
}
