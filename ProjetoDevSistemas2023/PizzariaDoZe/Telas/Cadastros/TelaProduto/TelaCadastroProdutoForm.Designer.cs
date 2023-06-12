namespace PizzariaDoZe.TelaProduto
{
    partial class TelaCadastroProdutoForm
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
            panelConteudo = new Panel();
            ML = new ComboBox();
            tipo = new ComboBox();
            valor = new TextBox();
            nome = new TextBox();
            id = new TextBox();
            lbMl = new Label();
            lbTipo = new Label();
            lbValor = new Label();
            lbNome = new Label();
            lbId = new Label();
            panelAcoes = new Panel();
            panelConteudo.SuspendLayout();
            SuspendLayout();
            // 
            // panelConteudo
            // 
            panelConteudo.Controls.Add(ML);
            panelConteudo.Controls.Add(tipo);
            panelConteudo.Controls.Add(valor);
            panelConteudo.Controls.Add(nome);
            panelConteudo.Controls.Add(id);
            panelConteudo.Controls.Add(lbMl);
            panelConteudo.Controls.Add(lbTipo);
            panelConteudo.Controls.Add(lbValor);
            panelConteudo.Controls.Add(lbNome);
            panelConteudo.Controls.Add(lbId);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(0, 0);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(266, 331);
            panelConteudo.TabIndex = 0;
            // 
            // ML
            // 
            ML.DropDownStyle = ComboBoxStyle.DropDownList;
            ML.FormattingEnabled = true;
            ML.Items.AddRange(new object[] { "150", "300", "600", "1000", "1500", "2000" });
            ML.Location = new Point(22, 214);
            ML.Name = "ML";
            ML.Size = new Size(121, 23);
            ML.TabIndex = 4;
            // 
            // tipo
            // 
            tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            tipo.FormattingEnabled = true;
            tipo.Location = new Point(22, 170);
            tipo.Name = "tipo";
            tipo.Size = new Size(121, 23);
            tipo.TabIndex = 3;
            // 
            // valor
            // 
            valor.Location = new Point(22, 126);
            valor.Name = "valor";
            valor.Size = new Size(100, 23);
            valor.TabIndex = 2;
            // 
            // nome
            // 
            nome.Location = new Point(22, 82);
            nome.Name = "nome";
            nome.Size = new Size(170, 23);
            nome.TabIndex = 1;
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(22, 38);
            id.Name = "id";
            id.Size = new Size(83, 23);
            id.TabIndex = 5;
            // 
            // lbMl
            // 
            lbMl.AutoSize = true;
            lbMl.Location = new Point(22, 196);
            lbMl.Name = "lbMl";
            lbMl.Size = new Size(34, 15);
            lbMl.TabIndex = 4;
            lbMl.Text = "ML--";
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Location = new Point(22, 152);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(40, 15);
            lbTipo.TabIndex = 3;
            lbTipo.Text = "Tipo--";
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(22, 108);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(43, 15);
            lbValor.TabIndex = 2;
            lbValor.Text = "Valor--";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(22, 64);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(50, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome--";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(22, 20);
            lbId.Name = "lbId";
            lbId.Size = new Size(28, 15);
            lbId.TabIndex = 0;
            lbId.Text = "ID--";
            // 
            // panelAcoes
            // 
            panelAcoes.Dock = DockStyle.Bottom;
            panelAcoes.Location = new Point(0, 255);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(266, 76);
            panelAcoes.TabIndex = 1;
            // 
            // TelaCadastroProdutoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 331);
            Controls.Add(panelAcoes);
            Controls.Add(panelConteudo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroProdutoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaProduto--";
            panelConteudo.ResumeLayout(false);
            panelConteudo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelConteudo;
        private Panel panelAcoes;
        private ComboBox ML;
        private ComboBox tipo;
        private TextBox valor;
        private TextBox nome;
        private TextBox id;
        private Label lbMl;
        private Label lbTipo;
        private Label lbValor;
        private Label lbNome;
        private Label lbId;
    }
}