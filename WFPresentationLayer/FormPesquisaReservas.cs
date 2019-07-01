﻿using BLL;
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
    public partial class FormPesquisaReservas : Form
    {
        public FormPesquisaReservas()
        {
            InitializeComponent();
        }

        ReservaBLL bll = new ReservaBLL();

        private void FormPesquisaReservas_Load(object sender, EventArgs e)
        {
            dgvReservas.DataSource = bll.LerTodos();
        }

        private void cboxPesqusia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
