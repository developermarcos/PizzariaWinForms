using FluentResults;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Compartilhado.UserControlComponentes;
using PizzariaDoZe.Domain.FeatureProduto;

namespace PizzariaDoZe.TelaProduto
{
    public partial class TelaCadastroProdutoForm : Form
    {
        private UserControlSalvarCancelar AcoesUserControl = new UserControlSalvarCancelar();
        private List<Tuple<string, string>> Mensagens;

        public TelaCadastroProdutoForm(string nomeTela, string mensagemDejesaSalvar, string mensagemDesejaCancelar)
        {
            InitializeComponent();
            Text = nomeTela;
            Configurar();
            Mensagens = new List<Tuple<string, string>>()
            {
                new Tuple<string, string>("mensagemSalvar", mensagemDejesaSalvar),
                new Tuple<string, string>("mensagemCancelar", mensagemDesejaCancelar)
            };
        }

        public Func<Produto, Result<Produto>> Gravar { get; internal set; }

        private void Configurar()
        {
            ConfigurarTela();
            //PreencherTela();
        }

        private void ConfigurarTela()
        {
            panelAcoes.Controls.Add(AcoesUserControl);

            AcoesUserControl.btnSalvar.Click += (object? sender, EventArgs e) =>
            {
                if (MessageBox.Show(Mensagens.FirstOrDefault(t => t.Item1 == "mensagemSalvar").Item2, Text, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    DialogResult = DialogResult.None;
            };

            AcoesUserControl.btnCancelar.Click += (object? sender, EventArgs e) =>
            {
                if (MessageBox.Show(Mensagens.FirstOrDefault(t => t.Item1 == "mensagemCancelar").Item2, Text, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    DialogResult = DialogResult.None;
            };

            new AjustarIdioma(this);

            Helpers.FocusTextBox(this);
        }
    }
}
