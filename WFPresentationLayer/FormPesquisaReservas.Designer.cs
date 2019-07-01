namespace WFPresentationLayer
{
    partial class FormPesquisaReservas
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
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.cboxPesqusia = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(12, 51);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(586, 313);
            this.dgvReservas.TabIndex = 0;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(377, 25);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(221, 20);
            this.dtpData.TabIndex = 1;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(155, 22);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.Text = "...";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            // 
            // cboxPesqusia
            // 
            this.cboxPesqusia.FormattingEnabled = true;
            this.cboxPesqusia.Items.AddRange(new object[] {
            "ID",
            "Cliente",
            "Data de Entrada",
            "Data Prevista de Saída",
            "Funcionário",
            "Quarto"});
            this.cboxPesqusia.Location = new System.Drawing.Point(12, 22);
            this.cboxPesqusia.Name = "cboxPesqusia";
            this.cboxPesqusia.Size = new System.Drawing.Size(121, 21);
            this.cboxPesqusia.TabIndex = 3;
            this.cboxPesqusia.SelectedIndexChanged += new System.EventHandler(this.cboxPesqusia_SelectedIndexChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(251, 25);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisa.TabIndex = 4;
            // 
            // FormPesquisaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 381);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.cboxPesqusia);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.dgvReservas);
            this.Name = "FormPesquisaReservas";
            this.Text = "FormPesquisaReservas";
            this.Load += new System.EventHandler(this.FormPesquisaReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.ComboBox cboxPesqusia;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}