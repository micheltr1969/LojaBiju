namespace WinAPP
{
    partial class frmPrincipal
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
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaDeProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestarContaDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasPorVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etiquetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.operaçãoToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.impressãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.vendedorToolStripMenuItem,
            this.tiposDeProdutosToolStripMenuItem,
            this.categoriaDeProdutoToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            // 
            // tiposDeProdutosToolStripMenuItem
            // 
            this.tiposDeProdutosToolStripMenuItem.Name = "tiposDeProdutosToolStripMenuItem";
            this.tiposDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.tiposDeProdutosToolStripMenuItem.Text = "Tipos de Produtos";
            // 
            // categoriaDeProdutoToolStripMenuItem
            // 
            this.categoriaDeProdutoToolStripMenuItem.Name = "categoriaDeProdutoToolStripMenuItem";
            this.categoriaDeProdutoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.categoriaDeProdutoToolStripMenuItem.Text = "Categoria de Produto";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // operaçãoToolStripMenuItem
            // 
            this.operaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.prestarContaDeVendasToolStripMenuItem});
            this.operaçãoToolStripMenuItem.Name = "operaçãoToolStripMenuItem";
            this.operaçãoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.operaçãoToolStripMenuItem.Text = "Operação";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // prestarContaDeVendasToolStripMenuItem
            // 
            this.prestarContaDeVendasToolStripMenuItem.Name = "prestarContaDeVendasToolStripMenuItem";
            this.prestarContaDeVendasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.prestarContaDeVendasToolStripMenuItem.Text = "Prestar conta de vendas";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem1,
            this.vendasPorVendedorToolStripMenuItem});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.vendasToolStripMenuItem1.Text = "Vendas";
            // 
            // vendasPorVendedorToolStripMenuItem
            // 
            this.vendasPorVendedorToolStripMenuItem.Name = "vendasPorVendedorToolStripMenuItem";
            this.vendasPorVendedorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.vendasPorVendedorToolStripMenuItem.Text = "Vendas por Vendedor";
            // 
            // impressãoToolStripMenuItem
            // 
            this.impressãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etiquetasToolStripMenuItem});
            this.impressãoToolStripMenuItem.Name = "impressãoToolStripMenuItem";
            this.impressãoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.impressãoToolStripMenuItem.Text = "Impressão";
            // 
            // etiquetasToolStripMenuItem
            // 
            this.etiquetasToolStripMenuItem.Name = "etiquetasToolStripMenuItem";
            this.etiquetasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.etiquetasToolStripMenuItem.Text = "Etiquetas";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 261);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaDeProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestarContaDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasPorVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impressãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etiquetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}