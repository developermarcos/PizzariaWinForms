namespace PizzariaDoZe.TelaValor
{
    partial class TelaCadastroValorForm
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
            lbId = new Label();
            lbTamanho = new Label();
            lbValorEspecial = new Label();
            ID = new TextBox();
            tamanho = new ComboBox();
            lbValorTradicional = new Label();
            lbValorBordaNormal = new Label();
            valorTradicional = new TextBox();
            valorEspecial = new TextBox();
            valorBordaTradicional = new TextBox();
            valorBordaEspecial = new TextBox();
            lbValorBordaEspecial = new Label();
            panelConteudo = new Panel();
            panelAcoes = new Panel();
            panelConteudo.SuspendLayout();
            SuspendLayout();
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(12, 12);
            lbId.Name = "lbId";
            lbId.Size = new Size(18, 15);
            lbId.TabIndex = 0;
            lbId.Text = "ID";
            // 
            // lbTamanho
            // 
            lbTamanho.AutoSize = true;
            lbTamanho.Location = new Point(78, 9);
            lbTamanho.Name = "lbTamanho";
            lbTamanho.Size = new Size(56, 15);
            lbTamanho.TabIndex = 1;
            lbTamanho.Text = "Tamanho";
            // 
            // lbValorEspecial
            // 
            lbValorEspecial.AutoSize = true;
            lbValorEspecial.Location = new Point(158, 71);
            lbValorEspecial.Name = "lbValorEspecial";
            lbValorEspecial.Size = new Size(107, 15);
            lbValorEspecial.TabIndex = 2;
            lbValorEspecial.Text = "Valor Pizza Especial";
            // 
            // ID
            // 
            ID.Enabled = false;
            ID.Location = new Point(12, 30);
            ID.Name = "ID";
            ID.Size = new Size(56, 23);
            ID.TabIndex = 4;
            ID.Text = "0";
            // 
            // tamanho
            // 
            tamanho.DropDownStyle = ComboBoxStyle.DropDownList;
            tamanho.FormattingEnabled = true;
            tamanho.Items.AddRange(new object[] { "P", "M", "G", "F" });
            tamanho.Location = new Point(78, 30);
            tamanho.Name = "tamanho";
            tamanho.Size = new Size(66, 23);
            tamanho.TabIndex = 5;
            // 
            // lbValorTradicional
            // 
            lbValorTradicional.AutoSize = true;
            lbValorTradicional.Location = new Point(12, 71);
            lbValorTradicional.Name = "lbValorTradicional";
            lbValorTradicional.Size = new Size(122, 15);
            lbValorTradicional.TabIndex = 6;
            lbValorTradicional.Text = "Valor Pizza Tradicional";
            // 
            // lbValorBordaNormal
            // 
            lbValorBordaNormal.AutoSize = true;
            lbValorBordaNormal.Location = new Point(12, 115);
            lbValorBordaNormal.Name = "lbValorBordaNormal";
            lbValorBordaNormal.Size = new Size(110, 15);
            lbValorBordaNormal.TabIndex = 7;
            lbValorBordaNormal.Text = "Valor Borda Normal";
            // 
            // valorTradicional
            // 
            valorTradicional.Location = new Point(12, 89);
            valorTradicional.Name = "valorTradicional";
            valorTradicional.Size = new Size(107, 23);
            valorTradicional.TabIndex = 8;
            // 
            // valorEspecial
            // 
            valorEspecial.Location = new Point(158, 89);
            valorEspecial.Name = "valorEspecial";
            valorEspecial.Size = new Size(107, 23);
            valorEspecial.TabIndex = 9;
            // 
            // valorBordaTradicional
            // 
            valorBordaTradicional.Location = new Point(12, 133);
            valorBordaTradicional.Name = "valorBordaTradicional";
            valorBordaTradicional.Size = new Size(107, 23);
            valorBordaTradicional.TabIndex = 10;
            // 
            // valorBordaEspecial
            // 
            valorBordaEspecial.Location = new Point(158, 133);
            valorBordaEspecial.Name = "valorBordaEspecial";
            valorBordaEspecial.Size = new Size(107, 23);
            valorBordaEspecial.TabIndex = 11;
            // 
            // lbValorBordaEspecial
            // 
            lbValorBordaEspecial.AutoSize = true;
            lbValorBordaEspecial.Location = new Point(158, 115);
            lbValorBordaEspecial.Name = "lbValorBordaEspecial";
            lbValorBordaEspecial.Size = new Size(112, 15);
            lbValorBordaEspecial.TabIndex = 12;
            lbValorBordaEspecial.Text = "Valor Borda Especial";
            // 
            // panelConteudo
            // 
            panelConteudo.Controls.Add(lbId);
            panelConteudo.Controls.Add(valorBordaEspecial);
            panelConteudo.Controls.Add(lbValorBordaEspecial);
            panelConteudo.Controls.Add(valorBordaTradicional);
            panelConteudo.Controls.Add(ID);
            panelConteudo.Controls.Add(valorEspecial);
            panelConteudo.Controls.Add(lbTamanho);
            panelConteudo.Controls.Add(valorTradicional);
            panelConteudo.Controls.Add(tamanho);
            panelConteudo.Controls.Add(lbValorTradicional);
            panelConteudo.Controls.Add(lbValorEspecial);
            panelConteudo.Controls.Add(lbValorBordaNormal);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(0, 0);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(281, 250);
            panelConteudo.TabIndex = 13;
            // 
            // panelAcoes
            // 
            panelAcoes.Dock = DockStyle.Bottom;
            panelAcoes.Location = new Point(0, 174);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(281, 76);
            panelAcoes.TabIndex = 14;
            // 
            // TelaCadastroValorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 250);
            Controls.Add(panelAcoes);
            Controls.Add(panelConteudo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroValorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroValorForm";
            panelConteudo.ResumeLayout(false);
            panelConteudo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbId;
        private Label lbTamanho;
        private Label lbValorEspecial;
        private TextBox ID;
        private ComboBox tamanho;
        private Label lbValorTradicional;
        private Label lbValorBordaNormal;
        private TextBox valorTradicional;
        private TextBox valorEspecial;
        private TextBox valorBordaTradicional;
        private TextBox valorBordaEspecial;
        private Label lbValorBordaEspecial;
        private Panel panelConteudo;
        private Panel panelAcoes;
    }
}