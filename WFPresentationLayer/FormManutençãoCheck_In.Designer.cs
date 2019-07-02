namespace WFPresentationLayer
{
    partial class FormManutençãoCheck_In
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdFunc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.btnCheck_in = new System.Windows.Forms.Button();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.btnPesquisarFuncionario = new System.Windows.Forms.Button();
            this.btnPesquisarReserva = new System.Windows.Forms.Button();
            this.btnPesquisarQuarto = new System.Windows.Forms.Button();
            this.txtIDQuarto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbReserva = new System.Windows.Forms.RadioButton();
            this.rbSemReserva = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(12, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID Reserva";
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Location = new System.Drawing.Point(12, 66);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(100, 20);
            this.txtIdReserva.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(121, 25);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID Fucionario";
            // 
            // txtIdFunc
            // 
            this.txtIdFunc.Location = new System.Drawing.Point(121, 66);
            this.txtIdFunc.Name = "txtIdFunc";
            this.txtIdFunc.Size = new System.Drawing.Size(100, 20);
            this.txtIdFunc.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data prevista de saida";
            // 
            // dtpSaida
            // 
            this.dtpSaida.Location = new System.Drawing.Point(12, 142);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(209, 20);
            this.dtpSaida.TabIndex = 13;
            // 
            // btnCheck_in
            // 
            this.btnCheck_in.Location = new System.Drawing.Point(12, 168);
            this.btnCheck_in.Name = "btnCheck_in";
            this.btnCheck_in.Size = new System.Drawing.Size(209, 26);
            this.btnCheck_in.TabIndex = 15;
            this.btnCheck_in.Text = "Check - in";
            this.btnCheck_in.UseVisualStyleBackColor = true;
            this.btnCheck_in.Click += new System.EventHandler(this.btnCheck_in_Click);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Location = new System.Drawing.Point(200, 6);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(21, 19);
            this.btnPesquisarCliente.TabIndex = 19;
            this.btnPesquisarCliente.Text = "...";
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // btnPesquisarFuncionario
            // 
            this.btnPesquisarFuncionario.Location = new System.Drawing.Point(200, 47);
            this.btnPesquisarFuncionario.Name = "btnPesquisarFuncionario";
            this.btnPesquisarFuncionario.Size = new System.Drawing.Size(21, 19);
            this.btnPesquisarFuncionario.TabIndex = 21;
            this.btnPesquisarFuncionario.Text = "...";
            this.btnPesquisarFuncionario.UseVisualStyleBackColor = true;
            this.btnPesquisarFuncionario.Click += new System.EventHandler(this.btnPesquisarFuncionario_Click);
            // 
            // btnPesquisarReserva
            // 
            this.btnPesquisarReserva.Location = new System.Drawing.Point(91, 47);
            this.btnPesquisarReserva.Name = "btnPesquisarReserva";
            this.btnPesquisarReserva.Size = new System.Drawing.Size(21, 19);
            this.btnPesquisarReserva.TabIndex = 22;
            this.btnPesquisarReserva.Text = "...";
            this.btnPesquisarReserva.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarQuarto
            // 
            this.btnPesquisarQuarto.Location = new System.Drawing.Point(91, 86);
            this.btnPesquisarQuarto.Name = "btnPesquisarQuarto";
            this.btnPesquisarQuarto.Size = new System.Drawing.Size(21, 19);
            this.btnPesquisarQuarto.TabIndex = 25;
            this.btnPesquisarQuarto.Text = "...";
            this.btnPesquisarQuarto.UseVisualStyleBackColor = true;
            // 
            // txtIDQuarto
            // 
            this.txtIDQuarto.Location = new System.Drawing.Point(12, 105);
            this.txtIDQuarto.Name = "txtIDQuarto";
            this.txtIDQuarto.Size = new System.Drawing.Size(100, 20);
            this.txtIDQuarto.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "ID Quarto";
            // 
            // rbReserva
            // 
            this.rbReserva.AutoSize = true;
            this.rbReserva.Location = new System.Drawing.Point(134, 92);
            this.rbReserva.Name = "rbReserva";
            this.rbReserva.Size = new System.Drawing.Size(84, 17);
            this.rbReserva.TabIndex = 26;
            this.rbReserva.TabStop = true;
            this.rbReserva.Text = "Com reserva";
            this.rbReserva.UseVisualStyleBackColor = true;
            // 
            // rbSemReserva
            // 
            this.rbSemReserva.AutoSize = true;
            this.rbSemReserva.Location = new System.Drawing.Point(134, 116);
            this.rbSemReserva.Name = "rbSemReserva";
            this.rbSemReserva.Size = new System.Drawing.Size(84, 17);
            this.rbSemReserva.TabIndex = 27;
            this.rbSemReserva.TabStop = true;
            this.rbSemReserva.Text = "Sem reserva";
            this.rbSemReserva.UseVisualStyleBackColor = true;
            // 
            // FormManutençãoCheck_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 205);
            this.Controls.Add(this.rbSemReserva);
            this.Controls.Add(this.rbReserva);
            this.Controls.Add(this.btnPesquisarQuarto);
            this.Controls.Add(this.txtIDQuarto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPesquisarReserva);
            this.Controls.Add(this.btnPesquisarFuncionario);
            this.Controls.Add(this.btnPesquisarCliente);
            this.Controls.Add(this.btnCheck_in);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpSaida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Name = "FormManutençãoCheck_In";
            this.Text = "FormManutençãoCheck_In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdFunc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpSaida;
        private System.Windows.Forms.Button btnCheck_in;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Button btnPesquisarFuncionario;
        private System.Windows.Forms.Button btnPesquisarReserva;
        private System.Windows.Forms.Button btnPesquisarQuarto;
        private System.Windows.Forms.TextBox txtIDQuarto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbReserva;
        private System.Windows.Forms.RadioButton rbSemReserva;
    }
}