using FluentResults;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Compartilhado.UserControlComponentes;
using PizzariaDoZe.Domain.FeatureIngrediente;

namespace PizzariaDoZe.TelaIngrediente
{
    public partial class TelaCadastroIngredienteForm : Form
    {
        private UserControlSalvarCancelar AcoesUserControl = new UserControlSalvarCancelar();
        private List<Tuple<string, string>> Mensagens;
        public TelaCadastroIngredienteForm(string telaNome, string mensagemDejesaSalvar, string mensagemDesejaCancelar)
        {
            InitializeComponent();
            Text = telaNome;
            Configurar();
            Mensagens = new List<Tuple<string, string>>()
            {
                new Tuple<string, string>("mensagemSalvar", mensagemDejesaSalvar),
                new Tuple<string, string>("mensagemCancelar", mensagemDesejaCancelar)
            };
        }

        public Func<Ingrediente, Result<Ingrediente>> Gravar { get; internal set; }

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

                var ingrediente = ObterObjeto();

                var result = Gravar(ingrediente);

                if (result.IsFailed)
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape(Properties.Resources.ResourceManager.GetString("mensagemFalhaCadastro"));

                    DialogResult = DialogResult.None;

                    return;
                }

                TelaPrincipalForm.Instancia.AtualizarRodape(Properties.Resources.ResourceManager.GetString("mensagemSucessoCadastro"));
            };

            AcoesUserControl.btnCancelar.Click += (object? sender, EventArgs e) =>
            {
                if (MessageBox.Show(Mensagens.FirstOrDefault(t => t.Item1 == "mensagemCancelar").Item2, Text, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    DialogResult = DialogResult.None;
            };

            new AjustarIdioma(this);

            Helpers.FocusTextBox(this);
        }

        private Ingrediente ObterObjeto()
        {
            return new Ingrediente()
            {
                Nome = nome.Text
            };
        }
    }
}
