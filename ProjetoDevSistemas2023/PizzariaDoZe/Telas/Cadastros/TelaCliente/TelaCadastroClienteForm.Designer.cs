namespace PizzariaDoZe.TelaCliente
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
            panelEndereco = new Panel();
            panelDadosPesooais = new Panel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            panelEndereco.Location = new Point(12, 181);
            panelEndereco.Name = "panelEndereco";
            panelEndereco.Size = new Size(360, 377);
            panelEndereco.TabIndex = 0;
            // 
            // panelDadosPesooais
            // 
            panelDadosPesooais.Controls.Add(textBox4);
            panelDadosPesooais.Controls.Add(textBox3);
            panelDadosPesooais.Controls.Add(textBox2);
            panelDadosPesooais.Controls.Add(textBox1);
            panelDadosPesooais.Controls.Add(lbTelefone);
            panelDadosPesooais.Controls.Add(lbCpf);
            panelDadosPesooais.Controls.Add(lbEmail);
            panelDadosPesooais.Controls.Add(lbNome);
            panelDadosPesooais.Controls.Add(lbId);
            panelDadosPesooais.Location = new Point(12, 12);
            panelDadosPesooais.Name = "panelDadosPesooais";
            panelDadosPesooais.Size = new Size(360, 163);
            panelDadosPesooais.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(137, 128);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(210, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(128, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(344, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 23);
            textBox1.TabIndex = 5;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new Point(137, 110);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(61, 15);
            lbTelefone.TabIndex = 4;
            lbTelefone.Text = "Telefone--";
            // 
            // lbCpf
            // 
            lbCpf.AutoSize = true;
            lbCpf.Location = new Point(3, 110);
            lbCpf.Name = "lbCpf";
            lbCpf.Size = new Size(38, 15);
            lbCpf.TabIndex = 3;
            lbCpf.Text = "CPF--";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(3, 66);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 15);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email--";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(3, 22);
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
            panelAcoes.Location = new Point(0, 565);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(385, 59);
            panelAcoes.TabIndex = 2;
            // 
            // TelaCadastroClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 624);
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
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}