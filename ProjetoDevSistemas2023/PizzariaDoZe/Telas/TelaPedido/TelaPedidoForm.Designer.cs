namespace PizzariaDoZe.Telas.TelaPedido
{
    partial class TelaPedidoForm
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
            grupoCliente = new GroupBox();
            btnLimpar = new Button();
            lbClienteTelefone = new Label();
            lbClienteEndereco = new Label();
            lbClienteLista = new Label();
            lbClientePesquisar = new Label();
            clienteLista = new ComboBox();
            clienteEndereco = new TextBox();
            clienteTelefone = new TextBox();
            clientePesquisa = new TextBox();
            grupoPizzas = new GroupBox();
            btnExcluirPizza = new Button();
            btnMontarPizza = new Button();
            pizzasMontadas = new ListBox();
            lbPizzasMontadas = new Label();
            panelBotoes = new Panel();
            panel1 = new Panel();
            lbProdutosAdionados = new Label();
            lbProdutos = new Label();
            btnExcluirProduto = new Button();
            produtosListaAdicionados = new ListBox();
            btnAdicionarProduto = new Button();
            produtoLista = new ComboBox();
            grupoCliente.SuspendLayout();
            grupoPizzas.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grupoCliente
            // 
            grupoCliente.Controls.Add(btnLimpar);
            grupoCliente.Controls.Add(lbClienteTelefone);
            grupoCliente.Controls.Add(lbClienteEndereco);
            grupoCliente.Controls.Add(lbClienteLista);
            grupoCliente.Controls.Add(lbClientePesquisar);
            grupoCliente.Controls.Add(clienteLista);
            grupoCliente.Controls.Add(clienteEndereco);
            grupoCliente.Controls.Add(clienteTelefone);
            grupoCliente.Controls.Add(clientePesquisa);
            grupoCliente.Location = new Point(12, 0);
            grupoCliente.Name = "grupoCliente";
            grupoCliente.Size = new Size(388, 153);
            grupoCliente.TabIndex = 0;
            grupoCliente.TabStop = false;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(6, 110);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 30);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lbClienteTelefone
            // 
            lbClienteTelefone.AutoSize = true;
            lbClienteTelefone.Location = new Point(206, 63);
            lbClienteTelefone.Name = "lbClienteTelefone";
            lbClienteTelefone.Size = new Size(51, 15);
            lbClienteTelefone.TabIndex = 7;
            lbClienteTelefone.Text = "Telefone";
            // 
            // lbClienteEndereco
            // 
            lbClienteEndereco.AutoSize = true;
            lbClienteEndereco.Location = new Point(206, 19);
            lbClienteEndereco.Name = "lbClienteEndereco";
            lbClienteEndereco.Size = new Size(56, 15);
            lbClienteEndereco.TabIndex = 6;
            lbClienteEndereco.Text = "Endereço";
            // 
            // lbClienteLista
            // 
            lbClienteLista.AutoSize = true;
            lbClienteLista.Location = new Point(6, 63);
            lbClienteLista.Name = "lbClienteLista";
            lbClienteLista.Size = new Size(94, 15);
            lbClienteLista.TabIndex = 5;
            lbClienteLista.Text = "Selecinar Cliente";
            // 
            // lbClientePesquisar
            // 
            lbClientePesquisar.AutoSize = true;
            lbClientePesquisar.Location = new Point(6, 19);
            lbClientePesquisar.Name = "lbClientePesquisar";
            lbClientePesquisar.Size = new Size(97, 15);
            lbClientePesquisar.TabIndex = 4;
            lbClientePesquisar.Text = "Pesquisar Cliente";
            // 
            // clienteLista
            // 
            clienteLista.DropDownStyle = ComboBoxStyle.DropDownList;
            clienteLista.FormattingEnabled = true;
            clienteLista.Location = new Point(6, 81);
            clienteLista.Name = "clienteLista";
            clienteLista.Size = new Size(192, 23);
            clienteLista.TabIndex = 3;
            clienteLista.SelectedIndexChanged += clienteLista_SelectedIndexChanged;
            // 
            // clienteEndereco
            // 
            clienteEndereco.Enabled = false;
            clienteEndereco.Location = new Point(206, 37);
            clienteEndereco.Name = "clienteEndereco";
            clienteEndereco.Size = new Size(176, 23);
            clienteEndereco.TabIndex = 2;
            clienteEndereco.TabStop = false;
            // 
            // clienteTelefone
            // 
            clienteTelefone.Enabled = false;
            clienteTelefone.Location = new Point(206, 81);
            clienteTelefone.Name = "clienteTelefone";
            clienteTelefone.Size = new Size(176, 23);
            clienteTelefone.TabIndex = 1;
            clienteTelefone.TabStop = false;
            // 
            // clientePesquisa
            // 
            clientePesquisa.Location = new Point(6, 37);
            clientePesquisa.Name = "clientePesquisa";
            clientePesquisa.Size = new Size(192, 23);
            clientePesquisa.TabIndex = 0;
            // 
            // grupoPizzas
            // 
            grupoPizzas.Controls.Add(btnExcluirPizza);
            grupoPizzas.Controls.Add(btnMontarPizza);
            grupoPizzas.Controls.Add(pizzasMontadas);
            grupoPizzas.Controls.Add(lbPizzasMontadas);
            grupoPizzas.Location = new Point(12, 159);
            grupoPizzas.Name = "grupoPizzas";
            grupoPizzas.Size = new Size(388, 207);
            grupoPizzas.TabIndex = 1;
            grupoPizzas.TabStop = false;
            // 
            // btnExcluirPizza
            // 
            btnExcluirPizza.Location = new Point(307, 161);
            btnExcluirPizza.Name = "btnExcluirPizza";
            btnExcluirPizza.Size = new Size(75, 30);
            btnExcluirPizza.TabIndex = 3;
            btnExcluirPizza.Text = "Excluir";
            btnExcluirPizza.UseVisualStyleBackColor = true;
            btnExcluirPizza.Click += btnExcluirPizza_Click;
            // 
            // btnMontarPizza
            // 
            btnMontarPizza.Location = new Point(307, 125);
            btnMontarPizza.Name = "btnMontarPizza";
            btnMontarPizza.Size = new Size(75, 30);
            btnMontarPizza.TabIndex = 2;
            btnMontarPizza.Text = "Montar";
            btnMontarPizza.UseVisualStyleBackColor = true;
            btnMontarPizza.Click += btnMontarPizza_Click;
            // 
            // pizzasMontadas
            // 
            pizzasMontadas.FormattingEnabled = true;
            pizzasMontadas.ItemHeight = 15;
            pizzasMontadas.Location = new Point(6, 37);
            pizzasMontadas.Name = "pizzasMontadas";
            pizzasMontadas.Size = new Size(295, 154);
            pizzasMontadas.TabIndex = 1;
            // 
            // lbPizzasMontadas
            // 
            lbPizzasMontadas.AutoSize = true;
            lbPizzasMontadas.Location = new Point(6, 19);
            lbPizzasMontadas.Name = "lbPizzasMontadas";
            lbPizzasMontadas.Size = new Size(94, 15);
            lbPizzasMontadas.TabIndex = 0;
            lbPizzasMontadas.Text = "Pizzas Montadas";
            // 
            // panelBotoes
            // 
            panelBotoes.Dock = DockStyle.Bottom;
            panelBotoes.Location = new Point(0, 584);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(411, 78);
            panelBotoes.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbProdutosAdionados);
            panel1.Controls.Add(lbProdutos);
            panel1.Controls.Add(btnExcluirProduto);
            panel1.Controls.Add(produtosListaAdicionados);
            panel1.Controls.Add(btnAdicionarProduto);
            panel1.Controls.Add(produtoLista);
            panel1.Location = new Point(12, 372);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 206);
            panel1.TabIndex = 3;
            // 
            // lbProdutosAdionados
            // 
            lbProdutosAdionados.AutoSize = true;
            lbProdutosAdionados.Location = new Point(6, 53);
            lbProdutosAdionados.Name = "lbProdutosAdionados";
            lbProdutosAdionados.Size = new Size(124, 15);
            lbProdutosAdionados.TabIndex = 6;
            lbProdutosAdionados.Text = "Produtos Adicionados";
            // 
            // lbProdutos
            // 
            lbProdutos.AutoSize = true;
            lbProdutos.Location = new Point(6, 9);
            lbProdutos.Name = "lbProdutos";
            lbProdutos.Size = new Size(55, 15);
            lbProdutos.TabIndex = 5;
            lbProdutos.Text = "Produtos";
            // 
            // btnExcluirProduto
            // 
            btnExcluirProduto.Location = new Point(307, 165);
            btnExcluirProduto.Name = "btnExcluirProduto";
            btnExcluirProduto.Size = new Size(75, 30);
            btnExcluirProduto.TabIndex = 4;
            btnExcluirProduto.Text = "Excluir";
            btnExcluirProduto.UseVisualStyleBackColor = true;
            btnExcluirProduto.Click += btnExcluirProduto_Click;
            // 
            // produtosListaAdicionados
            // 
            produtosListaAdicionados.FormattingEnabled = true;
            produtosListaAdicionados.ItemHeight = 15;
            produtosListaAdicionados.Location = new Point(6, 71);
            produtosListaAdicionados.Name = "produtosListaAdicionados";
            produtosListaAdicionados.Size = new Size(295, 124);
            produtosListaAdicionados.TabIndex = 3;
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.Location = new Point(307, 22);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(75, 30);
            btnAdicionarProduto.TabIndex = 2;
            btnAdicionarProduto.Text = "Adicionar";
            btnAdicionarProduto.UseVisualStyleBackColor = true;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // produtoLista
            // 
            produtoLista.DropDownStyle = ComboBoxStyle.DropDownList;
            produtoLista.FormattingEnabled = true;
            produtoLista.Location = new Point(6, 27);
            produtoLista.Name = "produtoLista";
            produtoLista.Size = new Size(295, 23);
            produtoLista.TabIndex = 0;
            // 
            // TelaPedidoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 662);
            Controls.Add(panel1);
            Controls.Add(panelBotoes);
            Controls.Add(grupoPizzas);
            Controls.Add(grupoCliente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPedidoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroPedido";
            grupoCliente.ResumeLayout(false);
            grupoCliente.PerformLayout();
            grupoPizzas.ResumeLayout(false);
            grupoPizzas.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grupoCliente;
        private Label lbClienteLista;
        private Label lbClientePesquisar;
        private ComboBox clienteLista;
        private TextBox clienteEndereco;
        private TextBox clienteTelefone;
        private TextBox clientePesquisa;
        private Label lbClienteTelefone;
        private Label lbClienteEndereco;
        private GroupBox grupoPizzas;
        private Label lbPizzasMontadas;
        private ListBox pizzasMontadas;
        private Button btnLimpar;
        private Button btnExcluirPizza;
        private Button btnMontarPizza;
        private Panel panelBotoes;
        private Panel panel1;
        private Label quantidade;
        private Label lbProdutos;
        private Button btnExcluirProduto;
        private ListBox produtosListaAdicionados;
        private Button btnAdicionarProduto;
        private TextBox textBox1;
        private ComboBox produtoLista;
        private Label lbProdutosAdionados;
    }
}