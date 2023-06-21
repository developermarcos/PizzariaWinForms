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
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            grupoPizzas = new GroupBox();
            btnExcluirPizza = new Button();
            btnMontarPizza = new Button();
            pizzasMontadas = new ListBox();
            lbPizzasMontadas = new Label();
            panelBotoes = new Panel();
            grupoCliente.SuspendLayout();
            grupoPizzas.SuspendLayout();
            SuspendLayout();
            // 
            // grupoCliente
            // 
            grupoCliente.Controls.Add(btnLimpar);
            grupoCliente.Controls.Add(lbClienteTelefone);
            grupoCliente.Controls.Add(lbClienteEndereco);
            grupoCliente.Controls.Add(lbClienteLista);
            grupoCliente.Controls.Add(lbClientePesquisar);
            grupoCliente.Controls.Add(comboBox1);
            grupoCliente.Controls.Add(textBox3);
            grupoCliente.Controls.Add(textBox2);
            grupoCliente.Controls.Add(textBox1);
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 23);
            comboBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(206, 37);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(176, 23);
            textBox3.TabIndex = 2;
            textBox3.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(206, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 23);
            textBox2.TabIndex = 1;
            textBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 0;
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
            // 
            // btnMontarPizza
            // 
            btnMontarPizza.Location = new Point(307, 125);
            btnMontarPizza.Name = "btnMontarPizza";
            btnMontarPizza.Size = new Size(75, 30);
            btnMontarPizza.TabIndex = 2;
            btnMontarPizza.Text = "Montar";
            btnMontarPizza.UseVisualStyleBackColor = true;
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
            panelBotoes.Location = new Point(0, 372);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(411, 78);
            panelBotoes.TabIndex = 2;
            // 
            // TelaPedidoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 450);
            Controls.Add(panelBotoes);
            Controls.Add(grupoPizzas);
            Controls.Add(grupoCliente);
            Name = "TelaPedidoForm";
            Text = "TelaCadastroPedido";
            grupoCliente.ResumeLayout(false);
            grupoCliente.PerformLayout();
            grupoPizzas.ResumeLayout(false);
            grupoPizzas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grupoCliente;
        private Label lbClienteLista;
        private Label lbClientePesquisar;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lbClienteTelefone;
        private Label lbClienteEndereco;
        private GroupBox grupoPizzas;
        private Label lbPizzasMontadas;
        private ListBox pizzasMontadas;
        private Button btnLimpar;
        private Button btnExcluirPizza;
        private Button btnMontarPizza;
        private Panel panelBotoes;
    }
}