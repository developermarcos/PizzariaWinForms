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
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.nome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.panelAcoes = new System.Windows.Forms.Panel();
            this.panelConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConteudo
            // 
            this.panelConteudo.Controls.Add(this.nome);
            this.panelConteudo.Controls.Add(this.lbNome);
            this.panelConteudo.Controls.Add(this.lbId);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(0, 0);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(311, 177);
            this.panelConteudo.TabIndex = 0;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(19, 59);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(280, 23);
            this.nome.TabIndex = 2;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(19, 41);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(40, 15);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(19, 13);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 15);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "ID";
            // 
            // panelAcoes
            // 
            this.panelAcoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAcoes.Location = new System.Drawing.Point(0, 105);
            this.panelAcoes.Name = "panelAcoes";
            this.panelAcoes.Size = new System.Drawing.Size(311, 72);
            this.panelAcoes.TabIndex = 1;
            // 
            // TelaCadastroIngredienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 177);
            this.Controls.Add(this.panelAcoes);
            this.Controls.Add(this.panelConteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroIngredienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroIngredienteForm";
            this.panelConteudo.ResumeLayout(false);
            this.panelConteudo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelConteudo;
        private Panel panelAcoes;
        private Label lbId;
        private TextBox nome;
        private Label lbNome;
    }
}