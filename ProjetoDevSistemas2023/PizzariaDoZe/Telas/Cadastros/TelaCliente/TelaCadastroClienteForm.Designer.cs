namespace PizzariaDoZe.TelaCliente
{
    partial class TelaCadastroClienteForm
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
            panelEndereco = new Panel();
            panelDadosPesooais = new Panel();
            telefone = new MaskedTextBox();
            cpf = new MaskedTextBox();
            email = new MaskedTextBox();
            id = new TextBox();
            nome = new TextBox();
            lbTelefone = new Label();
            lbCpf = new Label();
            lbEmail = new Label();
            lbNome = new Label();
            lbId = new Label();
            panelAcoes = new Panel();
            panelDadosPesooais.SuspendLayout();
            SuspendLayout();
            // 
            // panelEndereco
            // 
            panelEndereco.Location = new Point(12, 197);
            panelEndereco.Name = "panelEndereco";
            panelEndereco.Size = new Size(360, 397);
            panelEndereco.TabIndex = 2;
            // 
            // panelDadosPesooais
            // 
            panelDadosPesooais.Controls.Add(telefone);
            panelDadosPesooais.Controls.Add(cpf);
            panelDadosPesooais.Controls.Add(email);
            panelDadosPesooais.Controls.Add(id);
            panelDadosPesooais.Controls.Add(nome);
            panelDadosPesooais.Controls.Add(lbTelefone);
            panelDadosPesooais.Controls.Add(lbCpf);
            panelDadosPesooais.Controls.Add(lbEmail);
            panelDadosPesooais.Controls.Add(lbNome);
            panelDadosPesooais.Controls.Add(lbId);
            panelDadosPesooais.Location = new Point(12, 12);
            panelDadosPesooais.Name = "panelDadosPesooais";
            panelDadosPesooais.Size = new Size(360, 179);
            panelDadosPesooais.TabIndex = 1;
            // 
            // telefone
            // 
            telefone.Location = new Point(137, 151);
            telefone.Mask = "(99) 09999-9999";
            telefone.Name = "telefone";
            telefone.Size = new Size(210, 23);
            telefone.TabIndex = 4;
            // 
            // cpf
            // 
            cpf.Location = new Point(4, 151);
            cpf.Mask = "999.999.999-99";
            cpf.Name = "cpf";
            cpf.Size = new Size(128, 23);
            cpf.TabIndex = 3;
            // 
            // email
            // 
            email.Location = new Point(3, 107);
            email.Name = "email";
            email.Size = new Size(344, 23);
            email.TabIndex = 2;
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(4, 20);
            id.Name = "id";
            id.Size = new Size(84, 23);
            id.TabIndex = 9;
            id.TabStop = false;
            // 
            // nome
            // 
            nome.Location = new Point(3, 63);
            nome.Name = "nome";
            nome.Size = new Size(344, 23);
            nome.TabIndex = 1;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new Point(137, 133);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(61, 15);
            lbTelefone.TabIndex = 4;
            lbTelefone.Text = "Telefone--";
            // 
            // lbCpf
            // 
            lbCpf.AutoSize = true;
            lbCpf.Location = new Point(3, 133);
            lbCpf.Name = "lbCpf";
            lbCpf.Size = new Size(38, 15);
            lbCpf.TabIndex = 3;
            lbCpf.Text = "CPF--";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(3, 89);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 15);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email--";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(3, 45);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(50, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome--";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(3, 5);
            lbId.Name = "lbId";
            lbId.Size = new Size(28, 15);
            lbId.TabIndex = 0;
            lbId.Text = "ID--";
            // 
            // panelAcoes
            // 
            panelAcoes.Dock = DockStyle.Bottom;
            panelAcoes.Location = new Point(0, 600);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(385, 59);
            panelAcoes.TabIndex = 3;
            // 
            // TelaCadastroClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 659);
            Controls.Add(panelAcoes);
            Controls.Add(panelDadosPesooais);
            Controls.Add(panelEndereco);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroClienteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroClienteForm--";
            panelDadosPesooais.ResumeLayout(false);
            panelDadosPesooais.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEndereco;
        private Panel panelDadosPesooais;
        private Panel panelAcoes;
        private Label lbId;
        private Label lbTelefone;
        private Label lbCpf;
        private Label lbEmail;
        private Label lbNome;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox nome;
        private TextBox id;
        private MaskedTextBox email;
        private MaskedTextBox cpf;
        private MaskedTextBox telefone;
    }
}