namespace WFPresentationLayer
{
    partial class FormReservas
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
            this.btnReserva = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.dtpSaidaPrevista = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDReserva = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDFuncionario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDQuarto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPesquisarQuarto = new System.Windows.Forms.Button();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.btnPesquisaFuncionario = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReserva
            // 
            this.btnReserva.Location = new System.Drawing.Point(12, 158);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(206, 23);
            this.btnReserva.TabIndex = 0;
            this.btnReserva.Text = "Reservar";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(237, 13);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(377, 160);
            this.dgvReservas.TabIndex = 1;
            this.dgvReservas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellDoubleClick);
            // 
            // dtpSaidaPrevista
            // 
            this.dtpSaidaPrevista.Location = new System.Drawing.Point(118, 103);
            this.dtpSaidaPrevista.Name = "dtpSaidaPrevista";
            this.dtpSaidaPrevista.Size = new System.Drawing.Size(100, 20);
            this.dtpSaidaPrevista.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID da Reserva";
            // 
            // txtIDReserva
            // 
            this.txtIDReserva.Enabled = false;
            this.txtIDReserva.Location = new System.Drawing.Point(12, 25);
            this.txtIDReserva.Name = "txtIDReserva";
            this.txtIDReserva.Size = new System.Drawing.Size(100, 20);
            this.txtIDReserva.TabIndex = 4;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(12, 64);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIDCliente.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID Cliente";
            // 
            // txtIDFuncionario
            // 
            this.txtIDFuncionario.Location = new System.Drawing.Point(12, 103);
            this.txtIDFuncionario.Name = "txtIDFuncionario";
            this.txtIDFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtIDFuncionario.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID Funcionario";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Location = new System.Drawing.Point(121, 64);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(97, 20);
            this.dtpEntrada.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data Prevista de Saida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data de entrada";
            // 
            // txtIDQuarto
            // 
            this.txtIDQuarto.Location = new System.Drawing.Point(118, 25);
            this.txtIDQuarto.Name = "txtIDQuarto";
            this.txtIDQuarto.Size = new System.Drawing.Size(100, 20);
            this.txtIDQuarto.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID Quarto";
            // 
            // btnPesquisarQuarto
            // 
            this.btnPesquisarQuarto.Location = new System.Drawing.Point(197, 6);
            this.btnPesquisarQuarto.Name = "btnPesquisarQuarto";
            this.btnPesquisarQuarto.Size = new System.Drawing.Size(21, 19);
            this.btnPesquisarQuarto.TabIndex = 18;
            this.btnPesquisarQuarto.Text = "...";
            this.btnPesquisarQuarto.UseVisualStyleBackColor = true;
            this.btnPesquisarQuarto.Click += new System.EventHandler(this.btnPesquisarQuarto_Click);
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.Location = new System.Drawing.Point(91, 45);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(21, 19);
            this.btnPesquisaCliente.TabIndex = 19;
            this.btnPesquisaCliente.Text = "...";
            this.btnPesquisaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.btnPesquisaCliente_Click);
            // 
            // btnPesquisaFuncionario
            // 
            this.btnPesquisaFuncionario.Location = new System.Drawing.Point(91, 84);
            this.btnPesquisaFuncionario.Name = "btnPesquisaFuncionario";
            this.btnPesquisaFuncionario.Size = new System.Drawing.Size(21, 19);
            this.btnPesquisaFuncionario.TabIndex = 20;
            this.btnPesquisaFuncionario.Text = "...";
            this.btnPesquisaFuncionario.UseVisualStyleBackColor = true;
            this.btnPesquisaFuncionario.Click += new System.EventHandler(this.btnPesquisaFuncionario_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(118, 129);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 23);
            this.btnAtualizar.TabIndex = 21;
            this.btnAtualizar.Text = "Alterar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(12, 129);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 23);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 185);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnPesquisaFuncionario);
            this.Controls.Add(this.btnPesquisaCliente);
            this.Controls.Add(this.btnPesquisarQuarto);
            this.Controls.Add(this.txtIDQuarto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.txtIDFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSaidaPrevista);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.btnReserva);
            this.Name = "FormReservas";
            this.Text = "FormCheckin";
            this.Load += new System.EventHandler(this.FormReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DateTimePicker dtpSaidaPrevista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDReserva;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDQuarto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPesquisarQuarto;
        private System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.Button btnPesquisaFuncionario;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
    }
}