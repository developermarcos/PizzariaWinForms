namespace PizzariaDoZe.Telas.TelaPedido
{
    partial class TelaPedidoPizzaForm
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
            lbTamanho = new Label();
            lbTipo = new Label();
            tamanho = new ComboBox();
            tipo = new ComboBox();
            label3 = new Label();
            saboresListaCheckBox = new CheckedListBox();
            borda = new ComboBox();
            lbBorda = new Label();
            panelBotoes = new Panel();
            lbInformacoes = new Label();
            informacoes = new Label();
            SuspendLayout();
            // 
            // lbTamanho
            // 
            lbTamanho.AutoSize = true;
            lbTamanho.Location = new Point(12, 9);
            lbTamanho.Name = "lbTamanho";
            lbTamanho.Size = new Size(56, 15);
            lbTamanho.TabIndex = 0;
            lbTamanho.Text = "Tamanho";
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Location = new Point(12, 53);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(30, 15);
            lbTipo.TabIndex = 1;
            lbTipo.Text = "Tipo";
            // 
            // tamanho
            // 
            tamanho.DropDownStyle = ComboBoxStyle.DropDownList;
            tamanho.FormattingEnabled = true;
            tamanho.Location = new Point(12, 27);
            tamanho.Name = "tamanho";
            tamanho.Size = new Size(202, 23);
            tamanho.TabIndex = 2;
            // 
            // tipo
            // 
            tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            tipo.FormattingEnabled = true;
            tipo.Location = new Point(12, 71);
            tipo.Name = "tipo";
            tipo.Size = new Size(202, 23);
            tipo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Sabores";
            // 
            // saboresListaCheckBox
            // 
            saboresListaCheckBox.FormattingEnabled = true;
            saboresListaCheckBox.Location = new Point(12, 159);
            saboresListaCheckBox.Name = "saboresListaCheckBox";
            saboresListaCheckBox.Size = new Size(202, 94);
            saboresListaCheckBox.TabIndex = 5;
            // 
            // borda
            // 
            borda.DropDownStyle = ComboBoxStyle.DropDownList;
            borda.FormattingEnabled = true;
            borda.Location = new Point(12, 115);
            borda.Name = "borda";
            borda.Size = new Size(202, 23);
            borda.TabIndex = 7;
            // 
            // lbBorda
            // 
            lbBorda.AutoSize = true;
            lbBorda.Location = new Point(12, 97);
            lbBorda.Name = "lbBorda";
            lbBorda.Size = new Size(38, 15);
            lbBorda.TabIndex = 6;
            lbBorda.Text = "Borda";
            // 
            // panelBotoes
            // 
            panelBotoes.Dock = DockStyle.Bottom;
            panelBotoes.Location = new Point(0, 317);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(228, 67);
            panelBotoes.TabIndex = 8;
            // 
            // lbInformacoes
            // 
            lbInformacoes.AutoSize = true;
            lbInformacoes.Location = new Point(12, 260);
            lbInformacoes.Name = "lbInformacoes";
            lbInformacoes.Size = new Size(73, 15);
            lbInformacoes.TabIndex = 9;
            lbInformacoes.Text = "Informações";
            // 
            // informacoes
            // 
            informacoes.AutoSize = true;
            informacoes.Location = new Point(12, 275);
            informacoes.Name = "informacoes";
            informacoes.Size = new Size(0, 15);
            informacoes.TabIndex = 10;
            // 
            // TelaPedidoPizzaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 384);
            Controls.Add(informacoes);
            Controls.Add(lbInformacoes);
            Controls.Add(panelBotoes);
            Controls.Add(borda);
            Controls.Add(lbBorda);
            Controls.Add(saboresListaCheckBox);
            Controls.Add(label3);
            Controls.Add(tipo);
            Controls.Add(tamanho);
            Controls.Add(lbTipo);
            Controls.Add(lbTamanho);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPedidoPizzaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPedidoPizzaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTamanho;
        private Label lbTipo;
        private ComboBox tamanho;
        private ComboBox tipo;
        private Label label3;
        private CheckedListBox saboresListaCheckBox;
        private ComboBox borda;
        private Label lbBorda;
        private Panel panelBotoes;
        private Label lbInformacoes;
        private Label informacoes;
    }
}