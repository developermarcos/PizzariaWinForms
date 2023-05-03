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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            menuPricipal = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            funcionariosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            saboresToolStripMenuItem = new ToolStripMenuItem();
            ingredientesToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            valoresToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            relatoriosToolStripMenuItem = new ToolStripMenuItem();
            configuracoesToolStripMenuItem = new ToolStripMenuItem();
            idiomasToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            panelAcoes = new Panel();
            toolStripAcoes = new ToolStrip();
            BtnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            btnFiltrar = new ToolStripButton();
            panelConteudo = new Panel();
            panelInformacoes = new Panel();
            lbRodape = new Label();
            notifyBandeja = new NotifyIcon(components);
            menuContextoPrincipal = new ContextMenuStrip(components);
            abrirToolStripMenuItem = new ToolStripMenuItem();
            encerarToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            menuPricipal.SuspendLayout();
            panelAcoes.SuspendLayout();
            toolStripAcoes.SuspendLayout();
            panelInformacoes.SuspendLayout();
            menuContextoPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuPricipal
            // 
            menuPricipal.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, pedidosToolStripMenuItem, relatoriosToolStripMenuItem, configuracoesToolStripMenuItem, sairToolStripMenuItem });
            menuPricipal.Location = new Point(0, 0);
            menuPricipal.Name = "menuPricipal";
            menuPricipal.Size = new Size(800, 24);
            menuPricipal.TabIndex = 0;
            menuPricipal.Text = "menuPricipal";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { funcionariosToolStripMenuItem, clientesToolStripMenuItem, saboresToolStripMenuItem, ingredientesToolStripMenuItem, produtosToolStripMenuItem, valoresToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(81, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros--";
            // 
            // funcionariosToolStripMenuItem
            // 
            funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            funcionariosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F1;
            funcionariosToolStripMenuItem.Size = new Size(198, 22);
            funcionariosToolStripMenuItem.Text = "Funcionários--";
            funcionariosToolStripMenuItem.Click += funcionáriosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F2;
            clientesToolStripMenuItem.Size = new Size(198, 22);
            clientesToolStripMenuItem.Text = "Clientes--";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // saboresToolStripMenuItem
            // 
            saboresToolStripMenuItem.Name = "saboresToolStripMenuItem";
            saboresToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F3;
            saboresToolStripMenuItem.Size = new Size(198, 22);
            saboresToolStripMenuItem.Text = "Sabores--";
            saboresToolStripMenuItem.Click += saboresToolStripMenuItem_Click;
            // 
            // ingredientesToolStripMenuItem
            // 
            ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            ingredientesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F4;
            ingredientesToolStripMenuItem.Size = new Size(198, 22);
            ingredientesToolStripMenuItem.Text = "Ingredientes--";
            ingredientesToolStripMenuItem.Click += ingredientesToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F5;
            produtosToolStripMenuItem.Size = new Size(198, 22);
            produtosToolStripMenuItem.Text = "Produtos--";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // valoresToolStripMenuItem
            // 
            valoresToolStripMenuItem.Name = "valoresToolStripMenuItem";
            valoresToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F6;
            valoresToolStripMenuItem.Size = new Size(198, 22);
            valoresToolStripMenuItem.Text = "Valores--";
            valoresToolStripMenuItem.Click += valoresToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(71, 20);
            pedidosToolStripMenuItem.Text = "Pedidos--";
            // 
            // relatoriosToolStripMenuItem
            // 
            relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            relatoriosToolStripMenuItem.Size = new Size(81, 20);
            relatoriosToolStripMenuItem.Text = "Relatórios--";
            // 
            // configuracoesToolStripMenuItem
            // 
            configuracoesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { idiomasToolStripMenuItem });
            configuracoesToolStripMenuItem.Name = "configuracoesToolStripMenuItem";
            configuracoesToolStripMenuItem.Size = new Size(106, 20);
            configuracoesToolStripMenuItem.Text = "Configurações--";
            // 
            // idiomasToolStripMenuItem
            // 
            idiomasToolStripMenuItem.Name = "idiomasToolStripMenuItem";
            idiomasToolStripMenuItem.Size = new Size(126, 22);
            idiomasToolStripMenuItem.Text = "Idiomas--";
            idiomasToolStripMenuItem.Click += idiomasToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 20);
            sairToolStripMenuItem.Text = "Sair--";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
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
            // notifyBandeja
            // 
            notifyBandeja.BalloonTipIcon = ToolTipIcon.Info;
            notifyBandeja.BalloonTipText = "Solução rodando na bandeja";
            notifyBandeja.BalloonTipTitle = "Pizzaria do Zé";
            notifyBandeja.ContextMenuStrip = menuContextoPrincipal;
            notifyBandeja.Icon = (Icon)resources.GetObject("notifyBandeja.Icon");
            notifyBandeja.Text = "Pizzaria do Zé";
            notifyBandeja.DoubleClick += notifyBandeja_DoubleClick;
            // 
            // menuContextoPrincipal
            // 
            menuContextoPrincipal.Items.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, encerarToolStripMenuItem, sobreToolStripMenuItem });
            menuContextoPrincipal.Name = "menuContextoPrincipal";
            menuContextoPrincipal.Size = new Size(124, 70);
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(123, 22);
            abrirToolStripMenuItem.Text = "Abrir--";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // encerarToolStripMenuItem
            // 
            encerarToolStripMenuItem.Name = "encerarToolStripMenuItem";
            encerarToolStripMenuItem.Size = new Size(123, 22);
            encerarToolStripMenuItem.Text = "Encerar--";
            encerarToolStripMenuItem.Click += encerarToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(123, 22);
            sobreToolStripMenuItem.Text = "Sobre--";
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
            Controls.Add(menuPricipal);
            MainMenuStrip = menuPricipal;
            Name = "TelaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal----";
            WindowState = FormWindowState.Maximized;
            menuPricipal.ResumeLayout(false);
            menuPricipal.PerformLayout();
            panelAcoes.ResumeLayout(false);
            panelAcoes.PerformLayout();
            toolStripAcoes.ResumeLayout(false);
            toolStripAcoes.PerformLayout();
            panelInformacoes.ResumeLayout(false);
            panelInformacoes.PerformLayout();
            menuContextoPrincipal.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPricipal;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem funcionariosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem saboresToolStripMenuItem;
        private ToolStripMenuItem ingredientesToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
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
        private ToolStripMenuItem configuracoesToolStripMenuItem;
        private ToolStripMenuItem idiomasToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private NotifyIcon notifyBandeja;
        private ContextMenuStrip menuContextoPrincipal;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem encerarToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}