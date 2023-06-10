using FluentResults;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Compartilhado.UserControlComponentes;
using PizzariaDoZe.Domain.FeatureIngrediente;

namespace PizzariaDoZe.TelaIngrediente
{
    public partial class TelaCadastroIngredienteForm : Form
    {
        private UserControlSalvarCancelar AcoesUserControl = new UserControlSalvarCancelar();
        private Ingrediente _ingredienteSelecionado;
        public TelaCadastroIngredienteForm(string telaNome, string mensagemDejesaSalvar, string mensagemDesejaCancelar)
        {
            InitializeComponent();
            Text = telaNome;
            ConfigurarTela();
        }

        public Func<Ingrediente, Result<Ingrediente>> Gravar { get; internal set; }
        
        public Ingrediente IngredienteSelecionado
        {
            set
            {
                _ingredienteSelecionado = value;
                PopularTela();
            }
            private get
            {
                var ingrediente = new Ingrediente()
                {
                    Nome = nome.Text
                };

                if (id.Text != string.Empty && id.Text != "0")
                    ingrediente.Id = Convert.ToUInt32(id.Text);

                return ingrediente;
            }
        }

        #region métodos privados
        private string ValidarCamposPreenchidos()
        {
            if (nome.Text.Length < 2)
                return "Nome invalido";

            return string.Empty;
        }

        private void PopularTela()
        {
            id.Text = Convert.ToString(_ingredienteSelecionado.Id);
            nome.Text = _ingredienteSelecionado.Nome;
        }

        private void ConfigurarTela()
        {
            panelAcoes.Controls.Add(AcoesUserControl);

            AcoesUserControl.btnSalvar.Click += (object? sender, EventArgs e) =>
            {
                string resultado = ValidarCamposPreenchidos();

                if (resultado != string.Empty)
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape(resultado);

                    DialogResult = DialogResult.None;

                    return;
                }

                var result = Gravar(IngredienteSelecionado);

                TelaPrincipalForm.Instancia.AtualizarRodape(Properties.Resources.ResourceManager.GetString("mensagemSucessoCadastro"));
            };

            new AjustarIdioma(this);

            Helpers.FocusTextBox(this);
        }
        #endregion
    }
}
