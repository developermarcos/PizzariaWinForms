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
            lbValorPizzaEspecial = new Label();
            ID = new TextBox();
            tamanho = new ComboBox();
            lbValorPizzaTradicional = new Label();
            lbValorBordaNormal = new Label();
            tradicional = new TextBox();
            especial = new TextBox();
            bordaTradicional = new TextBox();
            bordaEspecial = new TextBox();
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
            lbId.Size = new Size(28, 15);
            lbId.TabIndex = 0;
            lbId.Text = "ID--";
            // 
            // lbTamanho
            // 
            lbTamanho.AutoSize = true;
            lbTamanho.Location = new Point(78, 9);
            lbTamanho.Name = "lbTamanho";
            lbTamanho.Size = new Size(66, 15);
            lbTamanho.TabIndex = 1;
            lbTamanho.Text = "Tamanho--";
            // 
            // lbValorPizzaEspecial
            // 
            lbValorPizzaEspecial.AutoSize = true;
            lbValorPizzaEspecial.Location = new Point(158, 71);
            lbValorPizzaEspecial.Name = "lbValorPizzaEspecial";
            lbValorPizzaEspecial.Size = new Size(117, 15);
            lbValorPizzaEspecial.TabIndex = 2;
            lbValorPizzaEspecial.Text = "Valor Pizza Especial--";
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
            tamanho.TabIndex = 1;
            // 
            // lbValorPizzaTradicional
            // 
            lbValorPizzaTradicional.AutoSize = true;
            lbValorPizzaTradicional.Location = new Point(12, 71);
            lbValorPizzaTradicional.Name = "lbValorPizzaTradicional";
            lbValorPizzaTradicional.Size = new Size(132, 15);
            lbValorPizzaTradicional.TabIndex = 6;
            lbValorPizzaTradicional.Text = "Valor Pizza Tradicional--";
            // 
            // lbValorBordaNormal
            // 
            lbValorBordaNormal.AutoSize = true;
            lbValorBordaNormal.Location = new Point(12, 115);
            lbValorBordaNormal.Name = "lbValorBordaNormal";
            lbValorBordaNormal.Size = new Size(120, 15);
            lbValorBordaNormal.TabIndex = 7;
            lbValorBordaNormal.Text = "Valor Borda Normal--";
            // 
            // tradicional
            // 
            tradicional.Location = new Point(12, 89);
            tradicional.Name = "tradicional";
            tradicional.Size = new Size(107, 23);
            tradicional.TabIndex = 2;
            // 
            // especial
            // 
            especial.Location = new Point(158, 89);
            especial.Name = "especial";
            especial.Size = new Size(107, 23);
            especial.TabIndex = 3;
            // 
            // bordaTradicional
            // 
            bordaTradicional.Location = new Point(12, 133);
            bordaTradicional.Name = "bordaTradicional";
            bordaTradicional.Size = new Size(107, 23);
            bordaTradicional.TabIndex = 4;
            // 
            // bordaEspecial
            // 
            bordaEspecial.Location = new Point(158, 133);
            bordaEspecial.Name = "bordaEspecial";
            bordaEspecial.Size = new Size(107, 23);
            bordaEspecial.TabIndex = 5;
            // 
            // lbValorBordaEspecial
            // 
            lbValorBordaEspecial.AutoSize = true;
            lbValorBordaEspecial.Location = new Point(158, 115);
            lbValorBordaEspecial.Name = "lbValorBordaEspecial";
            lbValorBordaEspecial.Size = new Size(122, 15);
            lbValorBordaEspecial.TabIndex = 12;
            lbValorBordaEspecial.Text = "Valor Borda Especial--";
            // 
            // panelConteudo
            // 
            panelConteudo.Controls.Add(lbId);
            panelConteudo.Controls.Add(bordaEspecial);
            panelConteudo.Controls.Add(lbValorBordaEspecial);
            panelConteudo.Controls.Add(bordaTradicional);
            panelConteudo.Controls.Add(ID);
            panelConteudo.Controls.Add(especial);
            panelConteudo.Controls.Add(lbTamanho);
            panelConteudo.Controls.Add(tradicional);
            panelConteudo.Controls.Add(tamanho);
            panelConteudo.Controls.Add(lbValorPizzaTradicional);
            panelConteudo.Controls.Add(lbValorPizzaEspecial);
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
            Text = "TelaCadastroValorForm--";
            panelConteudo.ResumeLayout(false);
            panelConteudo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbId;
        private Label lbTamanho;
        private Label lbValorPizzaEspecial;
        private TextBox ID;
        private ComboBox tamanho;
        private Label lbValorPizzaTradicional;
        private Label lbValorBordaNormal;
        private TextBox tradicional;
        private TextBox especial;
        private TextBox bordaTradicional;
        private TextBox bordaEspecial;
        private Label lbValorBordaEspecial;
        private Panel panelConteudo;
        private Panel panelAcoes;
    }
}