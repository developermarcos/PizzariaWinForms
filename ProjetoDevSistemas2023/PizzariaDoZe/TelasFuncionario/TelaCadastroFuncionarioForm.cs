﻿using PizzariaDoZe.Compartilhado.UserControlComponentes;

namespace PizzariaDoZe.TelasFuncionario
{
    public partial class TelaCadastroFuncionarioForm : Form
    {
        private UserControlSalvarCancelar AcoesUserControl = new UserControlSalvarCancelar();
        private UserControlEndereco EnderecoUserControl = new UserControlEndereco();
        public TelaCadastroFuncionarioForm(string telaNome)
        {
            InitializeComponent();
            Text = telaNome;
            panelAcoes.Controls.Add(AcoesUserControl);
            panelEndereco.Controls.Add(EnderecoUserControl);

            PreencherTela();
            Salvar();
            Cancelar();
        }
        private void Salvar()
        {
            AcoesUserControl.btnSalvar.Click += (object? sender, EventArgs e) =>
            {
                if (MessageBox.Show("Deseja realmente salvar as informações?", Text, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    DialogResult = DialogResult.None;
            };

        }
        private void Cancelar()
        {
            AcoesUserControl.btnCancelar.Click += (object? sender, EventArgs e) =>
            {
                if (MessageBox.Show("Deseja realmente cancelar?", Text, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    DialogResult = DialogResult.None;
            };

        }
        private void PreencherTela()
        {
            id.Text = "ID: --";
        }
    }
}
