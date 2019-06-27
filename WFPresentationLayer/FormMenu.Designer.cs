namespace WFPresentationLayer
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManutencaoQuartosItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManutencaoClientesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManutencaoProdutosItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManutencaoFuncionariosItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManutencaoFornecedoresItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.checkInToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManutencaoQuartosItem,
            this.ManutencaoClientesItem,
            this.ManutencaoProdutosItem,
            this.ManutencaoFuncionariosItem,
            this.ManutencaoFornecedoresItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.cadastrosToolStripMenuItem.Text = "Dados";
            // 
            // ManutencaoQuartosItem
            // 
            this.ManutencaoQuartosItem.Name = "ManutencaoQuartosItem";
            this.ManutencaoQuartosItem.Size = new System.Drawing.Size(180, 22);
            this.ManutencaoQuartosItem.Text = "Quartos";
            this.ManutencaoQuartosItem.Click += new System.EventHandler(this.ManutencaoQuartosItem_Click);
            // 
            // ManutencaoClientesItem
            // 
            this.ManutencaoClientesItem.Name = "ManutencaoClientesItem";
            this.ManutencaoClientesItem.Size = new System.Drawing.Size(180, 22);
            this.ManutencaoClientesItem.Text = "Clientes";
            this.ManutencaoClientesItem.Click += new System.EventHandler(this.ManutencaoClientesItem_Click);
            // 
            // ManutencaoProdutosItem
            // 
            this.ManutencaoProdutosItem.Name = "ManutencaoProdutosItem";
            this.ManutencaoProdutosItem.Size = new System.Drawing.Size(180, 22);
            this.ManutencaoProdutosItem.Text = "Produtos";
            this.ManutencaoProdutosItem.Click += new System.EventHandler(this.ManutencaoProdutosItem_Click);
            // 
            // ManutencaoFuncionariosItem
            // 
            this.ManutencaoFuncionariosItem.Name = "ManutencaoFuncionariosItem";
            this.ManutencaoFuncionariosItem.Size = new System.Drawing.Size(180, 22);
            this.ManutencaoFuncionariosItem.Text = "Funcionários";
            this.ManutencaoFuncionariosItem.Click += new System.EventHandler(this.ManutencaoFuncionariosItem_Click);
            // 
            // ManutencaoFornecedoresItem
            // 
            this.ManutencaoFornecedoresItem.Name = "ManutencaoFornecedoresItem";
            this.ManutencaoFornecedoresItem.Size = new System.Drawing.Size(180, 22);
            this.ManutencaoFornecedoresItem.Text = "Fornecedores";
            this.ManutencaoFornecedoresItem.Click += new System.EventHandler(this.ManutencaoFornecedoresItem_Click);
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.checkInToolStripMenuItem.Text = "Check- in";
            this.checkInToolStripMenuItem.Click += new System.EventHandler(this.checkInToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManutencaoFuncionariosItem;
        private System.Windows.Forms.ToolStripMenuItem ManutencaoProdutosItem;
        private System.Windows.Forms.ToolStripMenuItem ManutencaoClientesItem;
        private System.Windows.Forms.ToolStripMenuItem ManutencaoQuartosItem;
        private System.Windows.Forms.ToolStripMenuItem ManutencaoFornecedoresItem;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
    }
}