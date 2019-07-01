namespace WFPresentationLayer
{
    partial class FormPesquisaFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtItemPesquisado = new System.Windows.Forms.TextBox();
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(12, 51);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.RowHeadersVisible = false;
            this.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionario.Size = new System.Drawing.Size(614, 150);
            this.dgvFuncionario.TabIndex = 0;
            this.dgvFuncionario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellDoubleClick);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(159, 9);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(34, 13);
            this.lblPesquisa.TabIndex = 1;
            this.lblPesquisa.Text = "Digite";
            // 
            // txtItemPesquisado
            // 
            this.txtItemPesquisado.Location = new System.Drawing.Point(162, 26);
            this.txtItemPesquisado.Name = "txtItemPesquisado";
            this.txtItemPesquisado.Size = new System.Drawing.Size(117, 20);
            this.txtItemPesquisado.TabIndex = 2;
            this.txtItemPesquisado.TextChanged += new System.EventHandler(this.txtItemPesquisado_TextChanged);
            // 
            // cmbOption
            // 
            this.cmbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Items.AddRange(new object[] {
            "ID",
            "NOME",
            "CPF",
            "TODOS"});
            this.cmbOption.Location = new System.Drawing.Point(13, 25);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(121, 21);
            this.cmbOption.TabIndex = 4;
            this.cmbOption.SelectedIndexChanged += new System.EventHandler(this.cmbOption_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pesquisar por:";
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Enabled = false;
            this.mtxtCPF.Location = new System.Drawing.Point(315, 25);
            this.mtxtCPF.Mask = "000,000,000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(128, 20);
            this.mtxtCPF.TabIndex = 6;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(312, 9);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(66, 13);
            this.lblCpf.TabIndex = 7;
            this.lblCpf.Text = "Digite o CPF";
            // 
            // FormPesquisaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 213);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.mtxtCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOption);
            this.Controls.Add(this.txtItemPesquisado);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.dgvFuncionario);
            this.Name = "FormPesquisaFuncionario";
            this.Text = "FormPesquisaFuncionario";
            this.Load += new System.EventHandler(this.FormPesquisaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtItemPesquisado;
        private System.Windows.Forms.ComboBox cmbOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.Label lblCpf;
    }
}