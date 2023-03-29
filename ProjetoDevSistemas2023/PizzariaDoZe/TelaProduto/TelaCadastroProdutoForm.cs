using PizzariaDoZe.Compartilhado.UserControlComponentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.TelaProduto
{
    public partial class TelaCadastroProdutoForm : Form
    {
        private UserControlSalvarCancelar AcoesUserControl = new UserControlSalvarCancelar();
        public TelaCadastroProdutoForm(string nomeTela)
        {
            InitializeComponent();
            Text = nomeTela;
            ConfigurarBotoe();
        }
        #region Configurações Tela
        private void ConfigurarBotoe()
        {
            panelAcoes.Controls.Add(AcoesUserControl);
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
        #endregion
    }
}
