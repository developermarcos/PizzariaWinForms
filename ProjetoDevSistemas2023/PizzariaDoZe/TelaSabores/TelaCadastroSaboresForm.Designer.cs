namespace PizzariaDoZe.TelaSabores
{
    partial class TelaCadastroSaboresForm
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbIngredientes = new System.Windows.Forms.Label();
            this.lbCategorias = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbFoto = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.categorias = new System.Windows.Forms.ComboBox();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.imagemPK = new System.Windows.Forms.PictureBox();
            this.lbId = new System.Windows.Forms.Label();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.ingredientes = new System.Windows.Forms.CheckedListBox();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.panelAcoes = new System.Windows.Forms.Panel();
            this.selecionarImagem = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPK)).BeginInit();
            this.panelConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(6, 25);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(40, 15);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // lbIngredientes
            // 
            this.lbIngredientes.AutoSize = true;
            this.lbIngredientes.Location = new System.Drawing.Point(6, 157);
            this.lbIngredientes.Name = "lbIngredientes";
            this.lbIngredientes.Size = new System.Drawing.Size(72, 15);
            this.lbIngredientes.TabIndex = 1;
            this.lbIngredientes.Text = "Ingredientes";
            // 
            // lbCategorias
            // 
            this.lbCategorias.AutoSize = true;
            this.lbCategorias.Location = new System.Drawing.Point(6, 69);
            this.lbCategorias.Name = "lbCategorias";
            this.lbCategorias.Size = new System.Drawing.Size(63, 15);
            this.lbCategorias.TabIndex = 2;
            this.lbCategorias.Text = "Categorias";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(6, 113);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(30, 15);
            this.lbTipo.TabIndex = 3;
            this.lbTipo.Text = "Tipo";
            // 
            // lbFoto
            // 
            this.lbFoto.AutoSize = true;
            this.lbFoto.Location = new System.Drawing.Point(162, 25);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(31, 15);
            this.lbFoto.TabIndex = 4;
            this.lbFoto.Text = "Foto";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(6, 43);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(141, 23);
            this.nome.TabIndex = 5;
            // 
            // categorias
            // 
            this.categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorias.FormattingEnabled = true;
            this.categorias.Items.AddRange(new object[] {
            "Tradicional",
            "Especial"});
            this.categorias.Location = new System.Drawing.Point(6, 87);
            this.categorias.Name = "categorias";
            this.categorias.Size = new System.Drawing.Size(141, 23);
            this.categorias.TabIndex = 7;
            // 
            // tipo
            // 
            this.tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "Salgada",
            "Doce"});
            this.tipo.Location = new System.Drawing.Point(6, 131);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(141, 23);
            this.tipo.TabIndex = 8;
            // 
            // imagemPK
            // 
            this.imagemPK.Location = new System.Drawing.Point(162, 87);
            this.imagemPK.Name = "imagemPK";
            this.imagemPK.Size = new System.Drawing.Size(229, 197);
            this.imagemPK.TabIndex = 9;
            this.imagemPK.TabStop = false;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(6, 6);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(34, 15);
            this.lbId.TabIndex = 10;
            this.lbId.Text = "ID: --";
            // 
            // panelConteudo
            // 
            this.panelConteudo.Controls.Add(this.ingredientes);
            this.panelConteudo.Controls.Add(this.btnSelecionarImagem);
            this.panelConteudo.Controls.Add(this.lbId);
            this.panelConteudo.Controls.Add(this.lbNome);
            this.panelConteudo.Controls.Add(this.imagemPK);
            this.panelConteudo.Controls.Add(this.nome);
            this.panelConteudo.Controls.Add(this.lbFoto);
            this.panelConteudo.Controls.Add(this.tipo);
            this.panelConteudo.Controls.Add(this.lbTipo);
            this.panelConteudo.Controls.Add(this.lbIngredientes);
            this.panelConteudo.Controls.Add(this.categorias);
            this.panelConteudo.Controls.Add(this.lbCategorias);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(0, 0);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(406, 353);
            this.panelConteudo.TabIndex = 11;
            // 
            // ingredientes
            // 
            this.ingredientes.FormattingEnabled = true;
            this.ingredientes.Items.AddRange(new object[] {
            "Queijo",
            "Carne",
            "Calabresa"});
            this.ingredientes.Location = new System.Drawing.Point(6, 175);
            this.ingredientes.Name = "ingredientes";
            this.ingredientes.Size = new System.Drawing.Size(141, 112);
            this.ingredientes.TabIndex = 12;
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.Location = new System.Drawing.Point(162, 43);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(121, 35);
            this.btnSelecionarImagem.TabIndex = 11;
            this.btnSelecionarImagem.Text = "SelecionarImagem";
            this.btnSelecionarImagem.UseVisualStyleBackColor = true;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.btnSelecionarImagem_Click);
            // 
            // panelAcoes
            // 
            this.panelAcoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAcoes.Location = new System.Drawing.Point(0, 292);
            this.panelAcoes.Name = "panelAcoes";
            this.panelAcoes.Size = new System.Drawing.Size(406, 61);
            this.panelAcoes.TabIndex = 12;
            // 
            // selecionarImagem
            // 
            this.selecionarImagem.FileName = "selecionarImagem";
            // 
            // TelaCadastroSaboresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 353);
            this.Controls.Add(this.panelAcoes);
            this.Controls.Add(this.panelConteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroSaboresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroSaboresForm";
            ((System.ComponentModel.ISupportInitialize)(this.imagemPK)).EndInit();
            this.panelConteudo.ResumeLayout(false);
            this.panelConteudo.PerformLayout();
            this.ResumeLayout(false);

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
    }
}