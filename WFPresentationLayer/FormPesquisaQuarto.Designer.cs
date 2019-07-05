namespace WFPresentationLayer
{
    partial class FormPesquisaQuarto
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
            this.dgvQuartos = new System.Windows.Forms.DataGridView();
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemPesquisado = new System.Windows.Forms.TextBox();
            this.labelTextoPesuisa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuartos
            // 
            this.dgvQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuartos.Location = new System.Drawing.Point(12, 52);
            this.dgvQuartos.Name = "dgvQuartos";
            this.dgvQuartos.ReadOnly = true;
            this.dgvQuartos.RowHeadersVisible = false;
            this.dgvQuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuartos.Size = new System.Drawing.Size(552, 239);
            this.dgvQuartos.TabIndex = 0;
            this.dgvQuartos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuartos_CellDoubleClick);
            // 
            // cmbOption
            // 
            this.cmbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Items.AddRange(new object[] {
            "ID",
            "Nº QUARTO",
            "TIPO",
            "LIVRES",
            "TODOS"});
            this.cmbOption.Location = new System.Drawing.Point(12, 25);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(121, 21);
            this.cmbOption.TabIndex = 2;
            this.cmbOption.SelectedIndexChanged += new System.EventHandler(this.cmbOption_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar por:";
            // 
            // txtItemPesquisado
            // 
            this.txtItemPesquisado.Location = new System.Drawing.Point(157, 26);
            this.txtItemPesquisado.Name = "txtItemPesquisado";
            this.txtItemPesquisado.Size = new System.Drawing.Size(407, 20);
            this.txtItemPesquisado.TabIndex = 4;
            this.txtItemPesquisado.TextChanged += new System.EventHandler(this.txtItemPesquisado_TextChanged);
            // 
            // labelTextoPesuisa
            // 
            this.labelTextoPesuisa.AutoSize = true;
            this.labelTextoPesuisa.Location = new System.Drawing.Point(154, 10);
            this.labelTextoPesuisa.Name = "labelTextoPesuisa";
            this.labelTextoPesuisa.Size = new System.Drawing.Size(43, 13);
            this.labelTextoPesuisa.TabIndex = 5;
            this.labelTextoPesuisa.Text = "Digite o";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipos de quartos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "1- Suite Dupla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "2 - Suite Simples";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "3 - Quarto Duplo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "4 - Quarto Simples";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "5 - Quarto com Beliche";
            // 
            // FormPesquisaQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 337);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTextoPesuisa);
            this.Controls.Add(this.txtItemPesquisado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOption);
            this.Controls.Add(this.dgvQuartos);
            this.Name = "FormPesquisaQuarto";
            this.Text = "FormPesquisaQuarto";
            this.Load += new System.EventHandler(this.FormPesquisaQuarto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuartos;
        private System.Windows.Forms.ComboBox cmbOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemPesquisado;
        private System.Windows.Forms.Label labelTextoPesuisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}