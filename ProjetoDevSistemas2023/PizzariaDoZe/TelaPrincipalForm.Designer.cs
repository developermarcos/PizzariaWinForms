namespace PizzariaDoZe
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saboresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAcoes = new System.Windows.Forms.Panel();
            this.toolStripAcoes = new System.Windows.Forms.ToolStrip();
            this.BtnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panelInformacoes = new System.Windows.Forms.Panel();
            this.lbRodape = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelAcoes.SuspendLayout();
            this.toolStripAcoes.SuspendLayout();
            this.panelInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.saboresToolStripMenuItem,
            this.ingredientesToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // saboresToolStripMenuItem
            // 
            this.saboresToolStripMenuItem.Name = "saboresToolStripMenuItem";
            this.saboresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saboresToolStripMenuItem.Text = "Sabores";
            this.saboresToolStripMenuItem.Click += new System.EventHandler(this.saboresToolStripMenuItem_Click);
            // 
            // ingredientesToolStripMenuItem
            // 
            this.ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            this.ingredientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingredientesToolStripMenuItem.Text = "Ingredientes";
            this.ingredientesToolStripMenuItem.Click += new System.EventHandler(this.ingredientesToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // panelAcoes
            // 
            this.panelAcoes.Controls.Add(this.toolStripAcoes);
            this.panelAcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAcoes.Location = new System.Drawing.Point(0, 24);
            this.panelAcoes.Name = "panelAcoes";
            this.panelAcoes.Size = new System.Drawing.Size(800, 48);
            this.panelAcoes.TabIndex = 1;
            // 
            // toolStripAcoes
            // 
            this.toolStripAcoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripAcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnInserir,
            this.btnEditar,
            this.btnExcluir,
            this.btnFiltrar});
            this.toolStripAcoes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripAcoes.Location = new System.Drawing.Point(0, 0);
            this.toolStripAcoes.Name = "toolStripAcoes";
            this.toolStripAcoes.Size = new System.Drawing.Size(800, 48);
            this.toolStripAcoes.TabIndex = 0;
            this.toolStripAcoes.Text = "toolStrip1";
            // 
            // BtnInserir
            // 
            this.BtnInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnInserir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnInserir.Image = global::PizzariaDoZe.Properties.Resources.add;
            this.BtnInserir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Padding = new System.Windows.Forms.Padding(10);
            this.BtnInserir.Size = new System.Drawing.Size(48, 45);
            this.BtnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::PizzariaDoZe.Properties.Resources.edit_button;
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(10);
            this.btnEditar.Size = new System.Drawing.Size(48, 45);
            this.btnEditar.Text = "toolStripButton1";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = global::PizzariaDoZe.Properties.Resources.trash;
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(10);
            this.btnExcluir.Size = new System.Drawing.Size(48, 45);
            this.btnExcluir.Text = "toolStripButton2";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFiltrar.Image = global::PizzariaDoZe.Properties.Resources.filter;
            this.btnFiltrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Padding = new System.Windows.Forms.Padding(10);
            this.btnFiltrar.Size = new System.Drawing.Size(48, 45);
            this.btnFiltrar.Text = "toolStripButton3";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(0, 72);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(800, 378);
            this.panelConteudo.TabIndex = 2;
            // 
            // panelInformacoes
            // 
            this.panelInformacoes.Controls.Add(this.lbRodape);
            this.panelInformacoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInformacoes.Location = new System.Drawing.Point(0, 411);
            this.panelInformacoes.Name = "panelInformacoes";
            this.panelInformacoes.Size = new System.Drawing.Size(800, 39);
            this.panelInformacoes.TabIndex = 3;
            // 
            // lbRodape
            // 
            this.lbRodape.AutoSize = true;
            this.lbRodape.Location = new System.Drawing.Point(16, 11);
            this.lbRodape.Name = "lbRodape";
            this.lbRodape.Size = new System.Drawing.Size(0, 15);
            this.lbRodape.TabIndex = 0;
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelInformacoes);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelAcoes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelAcoes.ResumeLayout(false);
            this.panelAcoes.PerformLayout();
            this.toolStripAcoes.ResumeLayout(false);
            this.toolStripAcoes.PerformLayout();
            this.panelInformacoes.ResumeLayout(false);
            this.panelInformacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem saboresToolStripMenuItem;
        private ToolStripMenuItem ingredientesToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private Panel panelAcoes;
        private Panel panelConteudo;
        private Panel panelInformacoes;
        private ToolStrip toolStripAcoes;
        private ToolStripButton BtnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripButton btnFiltrar;
        private Label lbRodape;
    }
}