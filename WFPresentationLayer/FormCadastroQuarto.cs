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
    public partial class FormCadastroQuarto : Form
    {
        public FormCadastroQuarto()
        {
            InitializeComponent();
            
        }
        QuartoBLL bll = new QuartoBLL();

        #region Gerar dados na GridView
        private void FormCadastroQuarto_Load(object sender, EventArgs e)
        {
            dgvQuartos.DataSource = null;
            dgvQuartos.DataSource = bll.LerTodos();
        }


        #endregion

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int StatusQuarto = 0;
            int TipoQuarto = 0;
            #region if StatusQuarto
            if (cmbStatusQuarto.Text.Contains("1"))
            {
                StatusQuarto = 1;
            }
            else if (cmbStatusQuarto.Text.Contains("2"))
            {
                StatusQuarto = 2;
            }
            else if (cmbStatusQuarto.Text.Contains("3"))
            {
                StatusQuarto = 3;
            }
            else if (cmbStatusQuarto.Text.Contains("4"))
            {
                StatusQuarto = 4;
            }
            #endregion

            #region if TipoQuarto
            if (cmbTipoQuarto.Text.Contains("1"))
            {
                TipoQuarto = 1;
            }
            else if(cmbTipoQuarto.Text.Contains("2"))
            {
                TipoQuarto = 2;
            }
            else if (cmbTipoQuarto.Text.Contains("3"))
            {
                TipoQuarto = 3;
            }
            else if (cmbTipoQuarto.Text.Contains("4"))
            {
                TipoQuarto = 4;
            }
            #endregion
            string precoCorrigido = null;

            for (int i = 0; i < txtPreco.Text.Length; i++)
            {
                if (char.IsNumber(txtPreco.Text[i]))
                {
                    precoCorrigido += txtPreco.Text[i];
                }
            }

            Quarto quarto = new Quarto(TipoQuarto, Convert.ToDouble(precoCorrigido), StatusQuarto, txtDescricao.Text);
            bll.CadastrarQuarto(quarto);
            FormCleaner.Clear(this);
            dgvQuartos.DataSource = null;
            dgvQuartos.DataSource = bll.LerTodos();
        }
    }
}
