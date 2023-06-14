namespace PizzariaDoZe.TelasFuncionario
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
            lbNomeCompleto = new Label();
            panelConteudo = new Panel();
            telefone = new MaskedTextBox();
            cpf = new MaskedTextBox();
            id = new TextBox();
            panelEndereco = new Panel();
            email = new TextBox();
            lbEmail = new Label();
            lbId = new Label();
            lbObservacoes = new Label();
            observacoes = new TextBox();
            senhaConfirmar = new TextBox();
            senha = new TextBox();
            lbComfirmaSenha = new Label();
            lbSenha = new Label();
            grupoHabilitacao = new GroupBox();
            lbDataVencimento = new Label();
            dataVencimentoHabilitacao = new DateTimePicker();
            nao = new RadioButton();
            sim = new RadioButton();
            lbNumero = new Label();
            cnh = new TextBox();
            grupoFuncionario = new ComboBox();
            lbGrupoFuncionario = new Label();
            lbTelefone = new Label();
            matricula = new TextBox();
            lbMatricula = new Label();
            lbCpf = new Label();
            nomeCompleto = new TextBox();
            panelAcoes = new Panel();
            panelConteudo.SuspendLayout();
            grupoHabilitacao.SuspendLayout();
            SuspendLayout();
            // 
            // lbNomeCompleto
            // 
            lbNomeCompleto.AutoSize = true;
            lbNomeCompleto.Location = new Point(20, 53);
            lbNomeCompleto.Name = "lbNomeCompleto";
            lbNomeCompleto.Size = new Size(106, 15);
            lbNomeCompleto.TabIndex = 1;
            lbNomeCompleto.Text = "Nome Completo--";
            // 
            // panelConteudo
            // 
            panelConteudo.Controls.Add(telefone);
            panelConteudo.Controls.Add(cpf);
            panelConteudo.Controls.Add(id);
            panelConteudo.Controls.Add(panelEndereco);
            panelConteudo.Controls.Add(email);
            panelConteudo.Controls.Add(lbEmail);
            panelConteudo.Controls.Add(lbId);
            panelConteudo.Controls.Add(lbObservacoes);
            panelConteudo.Controls.Add(observacoes);
            panelConteudo.Controls.Add(senhaConfirmar);
            panelConteudo.Controls.Add(senha);
            panelConteudo.Controls.Add(lbComfirmaSenha);
            panelConteudo.Controls.Add(lbSenha);
            panelConteudo.Controls.Add(grupoHabilitacao);
            panelConteudo.Controls.Add(grupoFuncionario);
            panelConteudo.Controls.Add(lbGrupoFuncionario);
            panelConteudo.Controls.Add(lbTelefone);
            panelConteudo.Controls.Add(matricula);
            panelConteudo.Controls.Add(lbMatricula);
            panelConteudo.Controls.Add(lbCpf);
            panelConteudo.Controls.Add(nomeCompleto);
            panelConteudo.Controls.Add(lbNomeCompleto);
            panelConteudo.Dock = DockStyle.Top;
            panelConteudo.Location = new Point(0, 0);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Padding = new Padding(30);
            panelConteudo.Size = new Size(728, 557);
            panelConteudo.TabIndex = 2;
            // 
            // telefone
            // 
            telefone.Location = new Point(173, 114);
            telefone.Name = "telefone";
            telefone.Size = new Size(179, 23);
            telefone.TabIndex = 3;
            // 
            // cpf
            // 
            cpf.Location = new Point(20, 115);
            cpf.Name = "cpf";
            cpf.Size = new Size(147, 23);
            cpf.TabIndex = 2;
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(20, 27);
            id.Name = "id";
            id.Size = new Size(67, 23);
            id.TabIndex = 21;
            id.TabStop = false;
            // 
            // panelEndereco
            // 
            panelEndereco.Location = new Point(362, 13);
            panelEndereco.Name = "panelEndereco";
            panelEndereco.Size = new Size(356, 370);
            panelEndereco.TabIndex = 20;
            // 
            // email
            // 
            email.Location = new Point(20, 202);
            email.Name = "email";
            email.Size = new Size(336, 23);
            email.TabIndex = 6;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(20, 184);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 15);
            lbEmail.TabIndex = 19;
            lbEmail.Text = "Email--";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(20, 13);
            lbId.Name = "lbId";
            lbId.Size = new Size(28, 15);
            lbId.TabIndex = 17;
            lbId.Text = "ID--";
            // 
            // lbObservacoes
            // 
            lbObservacoes.AutoSize = true;
            lbObservacoes.Location = new Point(20, 280);
            lbObservacoes.Name = "lbObservacoes";
            lbObservacoes.Size = new Size(84, 15);
            lbObservacoes.TabIndex = 16;
            lbObservacoes.Text = "Observações--";
            // 
            // observacoes
            // 
            observacoes.Location = new Point(20, 298);
            observacoes.Multiline = true;
            observacoes.Name = "observacoes";
            observacoes.Size = new Size(336, 112);
            observacoes.TabIndex = 9;
            // 
            // senhaConfirmar
            // 
            senhaConfirmar.Location = new Point(191, 245);
            senhaConfirmar.Name = "senhaConfirmar";
            senhaConfirmar.Size = new Size(165, 23);
            senhaConfirmar.TabIndex = 8;
            // 
            // senha
            // 
            senha.Location = new Point(20, 245);
            senha.Name = "senha";
            senha.Size = new Size(165, 23);
            senha.TabIndex = 7;
            // 
            // lbComfirmaSenha
            // 
            lbComfirmaSenha.AutoSize = true;
            lbComfirmaSenha.Location = new Point(191, 227);
            lbComfirmaSenha.Name = "lbComfirmaSenha";
            lbComfirmaSenha.Size = new Size(110, 15);
            lbComfirmaSenha.TabIndex = 14;
            lbComfirmaSenha.Text = "Comfirmar Senha--";
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(20, 227);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(49, 15);
            lbSenha.TabIndex = 13;
            lbSenha.Text = "Senha--";
            // 
            // grupoHabilitacao
            // 
            grupoHabilitacao.Controls.Add(lbDataVencimento);
            grupoHabilitacao.Controls.Add(dataVencimentoHabilitacao);
            grupoHabilitacao.Controls.Add(nao);
            grupoHabilitacao.Controls.Add(sim);
            grupoHabilitacao.Controls.Add(lbNumero);
            grupoHabilitacao.Controls.Add(cnh);
            grupoHabilitacao.Location = new Point(20, 426);
            grupoHabilitacao.Name = "grupoHabilitacao";
            grupoHabilitacao.Size = new Size(336, 100);
            grupoHabilitacao.TabIndex = 10;
            grupoHabilitacao.TabStop = false;
            grupoHabilitacao.Text = "Possui Habilitação?--";
            // 
            // lbDataVencimento
            // 
            lbDataVencimento.AutoSize = true;
            lbDataVencimento.Location = new Point(171, 46);
            lbDataVencimento.Name = "lbDataVencimento";
            lbDataVencimento.Size = new Size(107, 15);
            lbDataVencimento.TabIndex = 5;
            lbDataVencimento.Text = "Data Vencimento--";
            // 
            // dataVencimentoHabilitacao
            // 
            dataVencimentoHabilitacao.Location = new Point(171, 64);
            dataVencimentoHabilitacao.Name = "dataVencimentoHabilitacao";
            dataVencimentoHabilitacao.Size = new Size(142, 23);
            dataVencimentoHabilitacao.TabIndex = 13;
            dataVencimentoHabilitacao.Value = new DateTime(2023, 3, 8, 0, 0, 0, 0);
            // 
            // nao
            // 
            nao.AutoSize = true;
            nao.Location = new Point(78, 20);
            nao.Name = "nao";
            nao.Size = new Size(57, 19);
            nao.TabIndex = 11;
            nao.TabStop = true;
            nao.Text = "Não--";
            nao.UseVisualStyleBackColor = true;
            // 
            // sim
            // 
            sim.AutoSize = true;
            sim.Location = new Point(19, 19);
            sim.Name = "sim";
            sim.Size = new Size(55, 19);
            sim.TabIndex = 10;
            sim.TabStop = true;
            sim.Text = "Sim--";
            sim.UseVisualStyleBackColor = true;
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.Location = new Point(6, 46);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(61, 15);
            lbNumero.TabIndex = 1;
            lbNumero.Text = "Numero--";
            // 
            // cnh
            // 
            cnh.Location = new Point(6, 64);
            cnh.Name = "cnh";
            cnh.Size = new Size(141, 23);
            cnh.TabIndex = 12;
            // 
            // grupoFuncionario
            // 
            grupoFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            grupoFuncionario.FormattingEnabled = true;
            grupoFuncionario.Items.AddRange(new object[] { "Atendente", "Entregador", "Gerente" });
            grupoFuncionario.Location = new Point(177, 158);
            grupoFuncionario.Name = "grupoFuncionario";
            grupoFuncionario.Size = new Size(179, 23);
            grupoFuncionario.TabIndex = 5;
            // 
            // lbGrupoFuncionario
            // 
            lbGrupoFuncionario.AutoSize = true;
            lbGrupoFuncionario.Location = new Point(177, 140);
            lbGrupoFuncionario.Name = "lbGrupoFuncionario";
            lbGrupoFuncionario.Size = new Size(56, 15);
            lbGrupoFuncionario.TabIndex = 9;
            lbGrupoFuncionario.Text = "Função--";
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new Point(177, 96);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(61, 15);
            lbTelefone.TabIndex = 7;
            lbTelefone.Text = "Telefone--";
            // 
            // matricula
            // 
            matricula.Location = new Point(20, 158);
            matricula.Name = "matricula";
            matricula.Size = new Size(147, 23);
            matricula.TabIndex = 4;
            // 
            // lbMatricula
            // 
            lbMatricula.AutoSize = true;
            lbMatricula.Location = new Point(20, 140);
            lbMatricula.Name = "lbMatricula";
            lbMatricula.Size = new Size(67, 15);
            lbMatricula.TabIndex = 5;
            lbMatricula.Text = "Matrícula--";
            // 
            // lbCpf
            // 
            lbCpf.AutoSize = true;
            lbCpf.Location = new Point(20, 97);
            lbCpf.Name = "lbCpf";
            lbCpf.Size = new Size(38, 15);
            lbCpf.TabIndex = 3;
            lbCpf.Text = "CPF--";
            // 
            // nomeCompleto
            // 
            nomeCompleto.Location = new Point(20, 71);
            nomeCompleto.Name = "nomeCompleto";
            nomeCompleto.Size = new Size(336, 23);
            nomeCompleto.TabIndex = 1;
            // 
            // panelAcoes
            // 
            panelAcoes.Dock = DockStyle.Bottom;
            panelAcoes.Location = new Point(0, 563);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(728, 56);
            panelAcoes.TabIndex = 3;
            // 
            // TelaCadastroFuncionarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 619);
            Controls.Add(panelAcoes);
            Controls.Add(panelConteudo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroFuncionarioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastroFuncionarioForm--";
            panelConteudo.ResumeLayout(false);
            panelConteudo.PerformLayout();
            grupoHabilitacao.ResumeLayout(false);
            grupoHabilitacao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbNomeCompleto;
        private Panel panelConteudo;
        private Label lbCpf;
        private TextBox nomeCompleto;
        private Panel panelAcoes;
        private TextBox matricula;
        private Label lbMatricula;
        private Label lbGrupoFuncionario;
        private Label lbTelefone;
        private GroupBox grupoHabilitacao;
        private ComboBox grupoFuncionario;
        private Label lbNumero;
        private TextBox cnh;
        private Label lbDataVencimento;
        private DateTimePicker dataVencimentoHabilitacao;
        private RadioButton nao;
        private RadioButton sim;
        private Label lbObservacoes;
        private TextBox observacoes;
        private TextBox senhaConfirmar;
        private TextBox senha;
        private Label lbComfirmaSenha;
        private Label lbSenha;
        private Label lbId;
        private TextBox email;
        private Label lbEmail;
        private Panel panelEndereco;
        private TextBox id;
        private MaskedTextBox cpf;
        private MaskedTextBox telefone;
    }
}