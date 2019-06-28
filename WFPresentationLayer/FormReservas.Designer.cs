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
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReserva
            // 
            this.btnReserva.Location = new System.Drawing.Point(12, 129);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(100, 23);
            this.btnReserva.TabIndex = 0;
            this.btnReserva.Text = "Reservar";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(243, 12);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(319, 150);
            this.dgvReservas.TabIndex = 1;
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
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 175);
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
    }
}