namespace WFPresentationLayer
{
    partial class FormManutençãoFuncionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailFuncionario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenhaFuncionario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.chkÉAdm = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkÉAtivo = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.mtxtTelefoneFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.mtxtRGFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPFFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone";
            // 
            // txtEmailFuncionario
            // 
            this.txtEmailFuncionario.Location = new System.Drawing.Point(139, 26);
            this.txtEmailFuncionario.Name = "txtEmailFuncionario";
            this.txtEmailFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtEmailFuncionario.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "E-mail";
            // 
            // txtSenhaFuncionario
            // 
            this.txtSenhaFuncionario.Location = new System.Drawing.Point(139, 185);
            this.txtSenhaFuncionario.Name = "txtSenhaFuncionario";
            this.txtSenhaFuncionario.Size = new System.Drawing.Size(121, 20);
            this.txtSenhaFuncionario.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Senha";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "SC",
            "SP"});
            this.cmbEstado.Location = new System.Drawing.Point(139, 65);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 12;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // cmbCidade
            // 
            this.cmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(139, 104);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(121, 21);
            this.cmbCidade.TabIndex = 13;
            // 
            // chkÉAdm
            // 
            this.chkÉAdm.AutoSize = true;
            this.chkÉAdm.Location = new System.Drawing.Point(139, 125);
            this.chkÉAdm.Name = "chkÉAdm";
            this.chkÉAdm.Size = new System.Drawing.Size(98, 17);
            this.chkÉAdm.TabIndex = 14;
            this.chkÉAdm.Text = "É administrador";
            this.chkÉAdm.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cidade";
            // 
            // chkÉAtivo
            // 
            this.chkÉAtivo.AutoSize = true;
            this.chkÉAtivo.Location = new System.Drawing.Point(139, 149);
            this.chkÉAtivo.Name = "chkÉAtivo";
            this.chkÉAtivo.Size = new System.Drawing.Size(59, 17);
            this.chkÉAtivo.TabIndex = 20;
            this.chkÉAtivo.Text = "É ativo";
            this.chkÉAtivo.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(15, 225);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(245, 23);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtNomeFuncionario.Location = new System.Drawing.Point(15, 66);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFuncionario.TabIndex = 1;
            // 
            // mtxtTelefoneFuncionario
            // 
            this.mtxtTelefoneFuncionario.Location = new System.Drawing.Point(15, 184);
            this.mtxtTelefoneFuncionario.Mask = "(00)00000-0000";
            this.mtxtTelefoneFuncionario.Name = "mtxtTelefoneFuncionario";
            this.mtxtTelefoneFuncionario.Size = new System.Drawing.Size(100, 20);
            this.mtxtTelefoneFuncionario.TabIndex = 23;
            // 
            // mtxtRGFuncionario
            // 
            this.mtxtRGFuncionario.Location = new System.Drawing.Point(15, 145);
            this.mtxtRGFuncionario.Mask = "0,000,000";
            this.mtxtRGFuncionario.Name = "mtxtRGFuncionario";
            this.mtxtRGFuncionario.Size = new System.Drawing.Size(100, 20);
            this.mtxtRGFuncionario.TabIndex = 24;
            // 
            // mtxtCPFFuncionario
            // 
            this.mtxtCPFFuncionario.Location = new System.Drawing.Point(15, 105);
            this.mtxtCPFFuncionario.Mask = "000,000,000-00";
            this.mtxtCPFFuncionario.Name = "mtxtCPFFuncionario";
            this.mtxtCPFFuncionario.Size = new System.Drawing.Size(100, 20);
            this.mtxtCPFFuncionario.TabIndex = 25;
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(287, 9);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.RowHeadersVisible = false;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(513, 297);
            this.dgvFuncionarios.TabIndex = 26;
            this.dgvFuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtID
            // 
            this.txtID.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtID.Location = new System.Drawing.Point(15, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "ID";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(15, 254);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(245, 23);
            this.btnAtualizar.TabIndex = 29;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(15, 283);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(245, 23);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FormManutençãoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 315);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.mtxtCPFFuncionario);
            this.Controls.Add(this.mtxtRGFuncionario);
            this.Controls.Add(this.mtxtTelefoneFuncionario);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.chkÉAtivo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkÉAdm);
            this.Controls.Add(this.cmbCidade);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtSenhaFuncionario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmailFuncionario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.label1);
            this.Name = "FormManutençãoFuncionario";
            this.Text = "FormCadastroFuncionario";
            this.Load += new System.EventHandler(this.FormCadastroFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailFuncionario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenhaFuncionario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.CheckBox chkÉAdm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkÉAtivo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.MaskedTextBox mtxtTelefoneFuncionario;
        private System.Windows.Forms.MaskedTextBox mtxtRGFuncionario;
        private System.Windows.Forms.MaskedTextBox mtxtCPFFuncionario;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
    }
}