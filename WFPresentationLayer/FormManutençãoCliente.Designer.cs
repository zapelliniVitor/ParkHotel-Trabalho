namespace WFPresentationLayer
{
    partial class FormManutençãoCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtRG = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFone2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFone1 = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.DataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.cboxDadosPesquisa = new System.Windows.Forms.ComboBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbInativos = new System.Windows.Forms.RadioButton();
            this.rbAtivos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(19, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefone 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefone 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(149, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "CPF";
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(149, 77);
            this.mtxtCPF.Mask = "000.000.000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(100, 20);
            this.mtxtCPF.TabIndex = 27;
            // 
            // mtxtRG
            // 
            this.mtxtRG.Location = new System.Drawing.Point(19, 126);
            this.mtxtRG.Mask = "0,000,000";
            this.mtxtRG.Name = "mtxtRG";
            this.mtxtRG.Size = new System.Drawing.Size(100, 20);
            this.mtxtRG.TabIndex = 28;
            // 
            // mtxtFone2
            // 
            this.mtxtFone2.Location = new System.Drawing.Point(149, 175);
            this.mtxtFone2.Mask = "(00)00000-0000";
            this.mtxtFone2.Name = "mtxtFone2";
            this.mtxtFone2.Size = new System.Drawing.Size(100, 20);
            this.mtxtFone2.TabIndex = 29;
            // 
            // mtxtFone1
            // 
            this.mtxtFone1.Location = new System.Drawing.Point(19, 175);
            this.mtxtFone1.Mask = "(00)00000-0000";
            this.mtxtFone1.Name = "mtxtFone1";
            this.mtxtFone1.Size = new System.Drawing.Size(100, 20);
            this.mtxtFone1.TabIndex = 30;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(19, 244);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(230, 42);
            this.btnCadastro.TabIndex = 31;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(19, 292);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(230, 42);
            this.btnAtualizar.TabIndex = 32;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Código do Cliente";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(19, 218);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 33;
            // 
            // DataGridViewClientes
            // 
            this.DataGridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewClientes.Location = new System.Drawing.Point(282, 56);
            this.DataGridViewClientes.Name = "DataGridViewClientes";
            this.DataGridViewClientes.ReadOnly = true;
            this.DataGridViewClientes.RowHeadersVisible = false;
            this.DataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewClientes.Size = new System.Drawing.Size(552, 326);
            this.DataGridViewClientes.TabIndex = 35;
            this.DataGridViewClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewClientes_CellDoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(19, 340);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(230, 42);
            this.btnExcluir.TabIndex = 36;
            this.btnExcluir.Text = "Desativar";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(282, 30);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(337, 20);
            this.txtPesquisa.TabIndex = 37;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(282, 11);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 38;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // cboxDadosPesquisa
            // 
            this.cboxDadosPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDadosPesquisa.FormattingEnabled = true;
            this.cboxDadosPesquisa.Items.AddRange(new object[] {
            "ID",
            "Nome",
            "CPF",
            "RG",
            "Telefone",
            "Email"});
            this.cboxDadosPesquisa.Location = new System.Drawing.Point(675, 8);
            this.cboxDadosPesquisa.Name = "cboxDadosPesquisa";
            this.cboxDadosPesquisa.Size = new System.Drawing.Size(159, 21);
            this.cboxDadosPesquisa.TabIndex = 39;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(779, 31);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 40;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbInativos
            // 
            this.rbInativos.AutoSize = true;
            this.rbInativos.Location = new System.Drawing.Point(711, 31);
            this.rbInativos.Name = "rbInativos";
            this.rbInativos.Size = new System.Drawing.Size(62, 17);
            this.rbInativos.TabIndex = 41;
            this.rbInativos.Text = "Inativos";
            this.rbInativos.UseVisualStyleBackColor = true;
            // 
            // rbAtivos
            // 
            this.rbAtivos.AutoSize = true;
            this.rbAtivos.Checked = true;
            this.rbAtivos.Location = new System.Drawing.Point(651, 31);
            this.rbAtivos.Name = "rbAtivos";
            this.rbAtivos.Size = new System.Drawing.Size(54, 17);
            this.rbAtivos.TabIndex = 42;
            this.rbAtivos.TabStop = true;
            this.rbAtivos.Text = "Ativos";
            this.rbAtivos.UseVisualStyleBackColor = true;
            // 
            // FormManutençãoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 409);
            this.Controls.Add(this.rbAtivos);
            this.Controls.Add(this.rbInativos);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.cboxDadosPesquisa);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.DataGridViewClientes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.mtxtFone1);
            this.Controls.Add(this.mtxtFone2);
            this.Controls.Add(this.mtxtRG);
            this.Controls.Add(this.mtxtCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "FormManutençãoCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormManutençãoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.MaskedTextBox mtxtRG;
        private System.Windows.Forms.MaskedTextBox mtxtFone2;
        private System.Windows.Forms.MaskedTextBox mtxtFone1;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView DataGridViewClientes;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.ComboBox cboxDadosPesquisa;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbInativos;
        private System.Windows.Forms.RadioButton rbAtivos;
    }
}

