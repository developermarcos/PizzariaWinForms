namespace PizzariaDoZe.TelaIngrediente
{
    partial class TelaCadastroIngredienteForm
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
            nome = new TextBox();
            lbNome = new Label();
            lbId = new Label();
            panelAcoes = new Panel();
            panelConteudo.SuspendLayout();
            SuspendLayout();
            // 
            // panelConteudo
            // 
            panelConteudo.Controls.Add(nome);
            panelConteudo.Controls.Add(lbNome);
            panelConteudo.Controls.Add(lbId);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(0, 0);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(311, 177);
            panelConteudo.TabIndex = 0;
            // 
            // nome
            // 
            nome.Location = new Point(19, 59);
            nome.Name = "nome";
            nome.Size = new Size(280, 23);
            nome.TabIndex = 2;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(19, 41);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(50, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome--";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(19, 13);
            lbId.Name = "lbId";
            lbId.Size = new Size(28, 15);
            lbId.TabIndex = 0;
            lbId.Text = "ID--";
            // 
            // panelAcoes
            // 
            panelAcoes.Dock = DockStyle.Bottom;
            panelAcoes.Location = new Point(0, 105);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(311, 72);
            panelAcoes.TabIndex = 1;
            // 
            // TelaCadastroIngredienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 177);
            Controls.Add(panelAcoes);
            Controls.Add(panelConteudo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroIngredienteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroIngredienteForm--";
            panelConteudo.ResumeLayout(false);
            panelConteudo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelConteudo;
        private Panel panelAcoes;
        private Label lbId;
        private TextBox nome;
        private Label lbNome;
    }
}