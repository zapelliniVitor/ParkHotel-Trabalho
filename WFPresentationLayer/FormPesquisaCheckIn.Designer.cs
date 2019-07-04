namespace WFPresentationLayer
{
    partial class FormPesquisaCheckIn
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
            this.dgvCheckIN = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIN)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCheckIN
            // 
            this.dgvCheckIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckIN.Location = new System.Drawing.Point(12, 40);
            this.dgvCheckIN.Name = "dgvCheckIN";
            this.dgvCheckIN.RowHeadersVisible = false;
            this.dgvCheckIN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckIN.Size = new System.Drawing.Size(485, 154);
            this.dgvCheckIN.TabIndex = 0;
            // 
            // FormPesquisaCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 206);
            this.Controls.Add(this.dgvCheckIN);
            this.Name = "FormPesquisaCheckIn";
            this.Text = "FormPesquisaCheckIn";
            this.Load += new System.EventHandler(this.FormPesquisaCheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckIN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCheckIN;
    }
}