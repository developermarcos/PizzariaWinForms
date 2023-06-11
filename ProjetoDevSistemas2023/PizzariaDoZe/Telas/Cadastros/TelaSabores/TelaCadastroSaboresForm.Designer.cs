namespace PizzariaDoZe.TelaSabores
{
    partial class TelaCadastroFuncionarioForm
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
            lbNome = new Label();
            lbIngredientes = new Label();
            lbCategorias = new Label();
            lbTipo = new Label();
            lbFoto = new Label();
            nome = new TextBox();
            categorias = new ComboBox();
            tipo = new ComboBox();
            imagemPK = new PictureBox();
            lbId = new Label();
            panelConteudo = new Panel();
            id = new TextBox();
            ingredientes = new CheckedListBox();
            btnSelecionarImagem = new Button();
            panelAcoes = new Panel();
            selecionarImagem = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)imagemPK).BeginInit();
            panelConteudo.SuspendLayout();
            SuspendLayout();
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(6, 48);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 0;
            lbNome.Text = "Nome";
            // 
            // lbIngredientes
            // 
            lbIngredientes.AutoSize = true;
            lbIngredientes.Location = new Point(6, 180);
            lbIngredientes.Name = "lbIngredientes";
            lbIngredientes.Size = new Size(72, 15);
            lbIngredientes.TabIndex = 1;
            lbIngredientes.Text = "Ingredientes";
            // 
            // lbCategorias
            // 
            lbCategorias.AutoSize = true;
            lbCategorias.Location = new Point(6, 92);
            lbCategorias.Name = "lbCategorias";
            lbCategorias.Size = new Size(63, 15);
            lbCategorias.TabIndex = 2;
            lbCategorias.Text = "Categorias";
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Location = new Point(6, 136);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(30, 15);
            lbTipo.TabIndex = 3;
            lbTipo.Text = "Tipo";
            // 
            // lbFoto
            // 
            lbFoto.AutoSize = true;
            lbFoto.Location = new Point(162, 9);
            lbFoto.Name = "lbFoto";
            lbFoto.Size = new Size(31, 15);
            lbFoto.TabIndex = 4;
            lbFoto.Text = "Foto";
            // 
            // nome
            // 
            nome.Location = new Point(6, 66);
            nome.Name = "nome";
            nome.Size = new Size(141, 23);
            nome.TabIndex = 1;
            // 
            // categorias
            // 
            categorias.DropDownStyle = ComboBoxStyle.DropDownList;
            categorias.FormattingEnabled = true;
            categorias.Items.AddRange(new object[] { "Tradicional", "Especial" });
            categorias.Location = new Point(6, 110);
            categorias.Name = "categorias";
            categorias.Size = new Size(141, 23);
            categorias.TabIndex = 2;
            // 
            // tipo
            // 
            tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            tipo.FormattingEnabled = true;
            tipo.Items.AddRange(new object[] { "Salgada", "Doce" });
            tipo.Location = new Point(6, 154);
            tipo.Name = "tipo";
            tipo.Size = new Size(141, 23);
            tipo.TabIndex = 3;
            // 
            // imagemPK
            // 
            imagemPK.Location = new Point(162, 71);
            imagemPK.Name = "imagemPK";
            imagemPK.Size = new Size(229, 197);
            imagemPK.TabIndex = 9;
            imagemPK.TabStop = false;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(6, 7);
            lbId.Name = "lbId";
            lbId.Size = new Size(34, 15);
            lbId.TabIndex = 10;
            lbId.Text = "ID: --";
            // 
            // panelConteudo
            // 
            panelConteudo.Controls.Add(id);
            panelConteudo.Controls.Add(ingredientes);
            panelConteudo.Controls.Add(btnSelecionarImagem);
            panelConteudo.Controls.Add(lbId);
            panelConteudo.Controls.Add(lbNome);
            panelConteudo.Controls.Add(imagemPK);
            panelConteudo.Controls.Add(nome);
            panelConteudo.Controls.Add(lbFoto);
            panelConteudo.Controls.Add(tipo);
            panelConteudo.Controls.Add(lbTipo);
            panelConteudo.Controls.Add(lbIngredientes);
            panelConteudo.Controls.Add(categorias);
            panelConteudo.Controls.Add(lbCategorias);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(0, 0);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(406, 379);
            panelConteudo.TabIndex = 11;
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(6, 23);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 13;
            // 
            // ingredientes
            // 
            ingredientes.FormattingEnabled = true;
            ingredientes.Items.AddRange(new object[] { "Queijo", "Carne", "Calabresa" });
            ingredientes.Location = new Point(6, 198);
            ingredientes.Name = "ingredientes";
            ingredientes.Size = new Size(141, 112);
            ingredientes.TabIndex = 4;
            // 
            // btnSelecionarImagem
            // 
            btnSelecionarImagem.Location = new Point(162, 27);
            btnSelecionarImagem.Name = "btnSelecionarImagem";
            btnSelecionarImagem.Size = new Size(121, 35);
            btnSelecionarImagem.TabIndex = 5;
            btnSelecionarImagem.Text = "SelecionarImagem";
            btnSelecionarImagem.UseVisualStyleBackColor = true;
            btnSelecionarImagem.Click += btnSelecionarImagem_Click;
            // 
            // panelAcoes
            // 
            panelAcoes.Dock = DockStyle.Bottom;
            panelAcoes.Location = new Point(0, 318);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(406, 61);
            panelAcoes.TabIndex = 12;
            // 
            // selecionarImagem
            // 
            selecionarImagem.FileName = "selecionarImagem";
            // 
            // TelaCadastroFuncionarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 379);
            Controls.Add(panelAcoes);
            Controls.Add(panelConteudo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroFuncionarioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroSaboresForm";
            ((System.ComponentModel.ISupportInitialize)imagemPK).EndInit();
            panelConteudo.ResumeLayout(false);
            panelConteudo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbNome;
        private Label lbIngredientes;
        private Label lbCategorias;
        private Label lbTipo;
        private Label lbFoto;
        private TextBox nome;
        private ComboBox categorias;
        private ComboBox tipo;
        private PictureBox imagemPK;
        private Label lbId;
        private Panel panelConteudo;
        private Panel panelAcoes;
        private OpenFileDialog selecionarImagem;
        private Button btnSelecionarImagem;
        private CheckedListBox ingredientes;
        private TextBox id;
    }
}