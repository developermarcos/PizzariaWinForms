﻿namespace PizzariaDoZe.TelasFuncionario
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
            dateTimePicker1 = new DateTimePicker();
            nao = new RadioButton();
            sim = new RadioButton();
            lbNumero = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            lbFuncao = new Label();
            telefone = new TextBox();
            lbTelefone = new Label();
            matricula = new TextBox();
            lbMatricula = new Label();
            CPF = new TextBox();
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
            lbNomeCompleto.Location = new Point(20, 17);
            lbNomeCompleto.Name = "lbNomeCompleto";
            lbNomeCompleto.Size = new Size(106, 15);
            lbNomeCompleto.TabIndex = 1;
            lbNomeCompleto.Text = "Nome Completo--";
            // 
            // panelConteudo
            // 
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
            panelConteudo.Controls.Add(comboBox1);
            panelConteudo.Controls.Add(lbFuncao);
            panelConteudo.Controls.Add(telefone);
            panelConteudo.Controls.Add(lbTelefone);
            panelConteudo.Controls.Add(matricula);
            panelConteudo.Controls.Add(lbMatricula);
            panelConteudo.Controls.Add(CPF);
            panelConteudo.Controls.Add(lbCpf);
            panelConteudo.Controls.Add(nomeCompleto);
            panelConteudo.Controls.Add(lbNomeCompleto);
            panelConteudo.Dock = DockStyle.Top;
            panelConteudo.Location = new Point(0, 0);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Padding = new Padding(30);
            panelConteudo.Size = new Size(728, 491);
            panelConteudo.TabIndex = 2;
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
            email.Location = new Point(20, 166);
            email.Name = "email";
            email.Size = new Size(336, 23);
            email.TabIndex = 18;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(20, 148);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 15);
            lbEmail.TabIndex = 19;
            lbEmail.Text = "Email--";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(270, 17);
            lbId.Name = "lbId";
            lbId.Size = new Size(28, 15);
            lbId.TabIndex = 17;
            lbId.Text = "ID--";
            // 
            // lbObservacoes
            // 
            lbObservacoes.AutoSize = true;
            lbObservacoes.Location = new Point(20, 244);
            lbObservacoes.Name = "lbObservacoes";
            lbObservacoes.Size = new Size(84, 15);
            lbObservacoes.TabIndex = 16;
            lbObservacoes.Text = "Observações--";
            // 
            // observacoes
            // 
            observacoes.Location = new Point(20, 262);
            observacoes.Multiline = true;
            observacoes.Name = "observacoes";
            observacoes.Size = new Size(336, 112);
            observacoes.TabIndex = 15;
            // 
            // senhaConfirmar
            // 
            senhaConfirmar.Location = new Point(191, 209);
            senhaConfirmar.Name = "senhaConfirmar";
            senhaConfirmar.Size = new Size(165, 23);
            senhaConfirmar.TabIndex = 12;
            // 
            // senha
            // 
            senha.Location = new Point(20, 209);
            senha.Name = "senha";
            senha.Size = new Size(165, 23);
            senha.TabIndex = 11;
            // 
            // lbComfirmaSenha
            // 
            lbComfirmaSenha.AutoSize = true;
            lbComfirmaSenha.Location = new Point(191, 191);
            lbComfirmaSenha.Name = "lbComfirmaSenha";
            lbComfirmaSenha.Size = new Size(110, 15);
            lbComfirmaSenha.TabIndex = 14;
            lbComfirmaSenha.Text = "Comfirmar Senha--";
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(20, 191);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(49, 15);
            lbSenha.TabIndex = 13;
            lbSenha.Text = "Senha--";
            // 
            // grupoHabilitacao
            // 
            grupoHabilitacao.Controls.Add(lbDataVencimento);
            grupoHabilitacao.Controls.Add(dateTimePicker1);
            grupoHabilitacao.Controls.Add(nao);
            grupoHabilitacao.Controls.Add(sim);
            grupoHabilitacao.Controls.Add(lbNumero);
            grupoHabilitacao.Controls.Add(textBox1);
            grupoHabilitacao.Location = new Point(20, 380);
            grupoHabilitacao.Name = "grupoHabilitacao";
            grupoHabilitacao.Size = new Size(336, 100);
            grupoHabilitacao.TabIndex = 6;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(171, 64);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(142, 23);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.Value = new DateTime(2023, 3, 8, 0, 0, 0, 0);
            // 
            // nao
            // 
            nao.AutoSize = true;
            nao.Location = new Point(78, 20);
            nao.Name = "nao";
            nao.Size = new Size(57, 19);
            nao.TabIndex = 8;
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
            sim.TabIndex = 7;
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
            // textBox1
            // 
            textBox1.Location = new Point(6, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Atendente", "Entregador", "Gerente" });
            comboBox1.Location = new Point(177, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 23);
            comboBox1.TabIndex = 5;
            // 
            // lbFuncao
            // 
            lbFuncao.AutoSize = true;
            lbFuncao.Location = new Point(177, 104);
            lbFuncao.Name = "lbFuncao";
            lbFuncao.Size = new Size(56, 15);
            lbFuncao.TabIndex = 9;
            lbFuncao.Text = "Função--";
            // 
            // telefone
            // 
            telefone.Location = new Point(177, 78);
            telefone.Name = "telefone";
            telefone.Size = new Size(179, 23);
            telefone.TabIndex = 3;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new Point(177, 60);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(61, 15);
            lbTelefone.TabIndex = 7;
            lbTelefone.Text = "Telefone--";
            // 
            // matricula
            // 
            matricula.Location = new Point(20, 122);
            matricula.Name = "matricula";
            matricula.Size = new Size(147, 23);
            matricula.TabIndex = 4;
            // 
            // lbMatricula
            // 
            lbMatricula.AutoSize = true;
            lbMatricula.Location = new Point(20, 104);
            lbMatricula.Name = "lbMatricula";
            lbMatricula.Size = new Size(67, 15);
            lbMatricula.TabIndex = 5;
            lbMatricula.Text = "Matrícula--";
            // 
            // CPF
            // 
            CPF.Location = new Point(20, 78);
            CPF.Name = "CPF";
            CPF.Size = new Size(147, 23);
            CPF.TabIndex = 2;
            // 
            // lbCpf
            // 
            lbCpf.AutoSize = true;
            lbCpf.Location = new Point(20, 61);
            lbCpf.Name = "lbCpf";
            lbCpf.Size = new Size(38, 15);
            lbCpf.TabIndex = 3;
            lbCpf.Text = "CPF--";
            // 
            // nomeCompleto
            // 
            nomeCompleto.Location = new Point(20, 35);
            nomeCompleto.Name = "nomeCompleto";
            nomeCompleto.Size = new Size(336, 23);
            nomeCompleto.TabIndex = 1;
            // 
            // panelAcoes
            // 
            panelAcoes.Dock = DockStyle.Bottom;
            panelAcoes.Location = new Point(0, 493);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(728, 56);
            panelAcoes.TabIndex = 3;
            // 
            // TelaCadastroFuncionarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 549);
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
        private TextBox CPF;
        private Label lbCpf;
        private TextBox nomeCompleto;
        private Panel panelAcoes;
        private TextBox matricula;
        private Label lbMatricula;
        private Label lbFuncao;
        private TextBox telefone;
        private Label lbTelefone;
        private GroupBox grupoHabilitacao;
        private ComboBox comboBox1;
        private Label lbNumero;
        private TextBox textBox1;
        private Label lbDataVencimento;
        private DateTimePicker dateTimePicker1;
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
    }
}