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
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            funcionáriosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            saboresToolStripMenuItem = new ToolStripMenuItem();
            ingredientesToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            panelAcoes = new Panel();
            toolStripAcoes = new ToolStrip();
            BtnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            btnFiltrar = new ToolStripButton();
            panelConteudo = new Panel();
            panelInformacoes = new Panel();
            lbRodape = new Label();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            valoresToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panelAcoes.SuspendLayout();
            toolStripAcoes.SuspendLayout();
            panelInformacoes.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, pedidosToolStripMenuItem, relatóriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { funcionáriosToolStripMenuItem, clientesToolStripMenuItem, saboresToolStripMenuItem, ingredientesToolStripMenuItem, produtosToolStripMenuItem, valoresToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // funcionáriosToolStripMenuItem
            // 
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.Size = new Size(180, 22);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            funcionáriosToolStripMenuItem.Click += funcionáriosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // saboresToolStripMenuItem
            // 
            saboresToolStripMenuItem.Name = "saboresToolStripMenuItem";
            saboresToolStripMenuItem.Size = new Size(180, 22);
            saboresToolStripMenuItem.Text = "Sabores";
            saboresToolStripMenuItem.Click += saboresToolStripMenuItem_Click;
            // 
            // ingredientesToolStripMenuItem
            // 
            ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            ingredientesToolStripMenuItem.Size = new Size(180, 22);
            ingredientesToolStripMenuItem.Text = "Ingredientes";
            ingredientesToolStripMenuItem.Click += ingredientesToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(61, 20);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // panelAcoes
            // 
            panelAcoes.Controls.Add(toolStripAcoes);
            panelAcoes.Dock = DockStyle.Top;
            panelAcoes.Location = new Point(0, 24);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(800, 48);
            panelAcoes.TabIndex = 1;
            // 
            // toolStripAcoes
            // 
            toolStripAcoes.Dock = DockStyle.Fill;
            toolStripAcoes.Items.AddRange(new ToolStripItem[] { BtnInserir, btnEditar, btnExcluir, btnFiltrar });
            toolStripAcoes.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStripAcoes.Location = new Point(0, 0);
            toolStripAcoes.Name = "toolStripAcoes";
            toolStripAcoes.Size = new Size(800, 48);
            toolStripAcoes.TabIndex = 0;
            toolStripAcoes.Text = "toolStrip1";
            // 
            // BtnInserir
            // 
            BtnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnInserir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnInserir.Image = Properties.Resources.add;
            BtnInserir.ImageScaling = ToolStripItemImageScaling.None;
            BtnInserir.ImageTransparentColor = Color.Magenta;
            BtnInserir.Name = "BtnInserir";
            BtnInserir.Padding = new Padding(10);
            BtnInserir.Size = new Size(48, 45);
            BtnInserir.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnInserir.Click += BtnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.edit_button;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(10);
            btnEditar.Size = new Size(48, 45);
            btnEditar.Text = "toolStripButton1";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.trash;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(10);
            btnExcluir.Size = new Size(48, 45);
            btnExcluir.Text = "toolStripButton2";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltrar.Image = Properties.Resources.filter;
            btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(10);
            btnFiltrar.Size = new Size(48, 45);
            btnFiltrar.Text = "toolStripButton3";
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // panelConteudo
            // 
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(0, 72);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(800, 378);
            panelConteudo.TabIndex = 2;
            // 
            // panelInformacoes
            // 
            panelInformacoes.Controls.Add(lbRodape);
            panelInformacoes.Dock = DockStyle.Bottom;
            panelInformacoes.Location = new Point(0, 411);
            panelInformacoes.Name = "panelInformacoes";
            panelInformacoes.Size = new Size(800, 39);
            panelInformacoes.TabIndex = 3;
            // 
            // lbRodape
            // 
            lbRodape.AutoSize = true;
            lbRodape.Location = new Point(16, 11);
            lbRodape.Name = "lbRodape";
            lbRodape.Size = new Size(0, 15);
            lbRodape.TabIndex = 0;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(180, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // valoresToolStripMenuItem
            // 
            valoresToolStripMenuItem.Name = "valoresToolStripMenuItem";
            valoresToolStripMenuItem.Size = new Size(180, 22);
            valoresToolStripMenuItem.Text = "Valores";
            valoresToolStripMenuItem.Click += valoresToolStripMenuItem_Click;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(panelInformacoes);
            Controls.Add(panelConteudo);
            Controls.Add(panelAcoes);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelAcoes.ResumeLayout(false);
            panelAcoes.PerformLayout();
            toolStripAcoes.ResumeLayout(false);
            toolStripAcoes.PerformLayout();
            panelInformacoes.ResumeLayout(false);
            panelInformacoes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem valoresToolStripMenuItem;
    }
}