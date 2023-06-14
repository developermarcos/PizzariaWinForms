using FluentResults;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Compartilhado.UserControlComponentes;
using PizzariaDoZe.Domain.FeatureValor;


namespace PizzariaDoZe.TelaValor
{
    public partial class TelaCadastroValorForm : Form
    {
        private UserControlSalvarCancelar AcoesUserControl = new UserControlSalvarCancelar();
        private Valor _valorSelecionado;
        public TelaCadastroValorForm(string nomeTela, string mensagemDejesaSalvar, string mensagemDesejaCancelar)
        {
            InitializeComponent();
            Text = nomeTela;
            ConfigurarTela();
        }
        public Func<Valor, Result<Valor>> Gravar { get; internal set; }

        public Func<TamanhoPizza, Result<Valor>> BuscarValorPorTamanho { get; internal set; }

        public Valor ValorSelecinado
        {
            get
            {
                return new Valor()
                {
                    id = string.IsNullOrEmpty(ID.Text) ? 0 : Convert.ToInt32(ID.Text),
                    tamanho = Enum.Parse<TamanhoPizza>(tamanho.Text),
                    tradicional = Convert.ToDecimal(tradicional.Text),
                    especial = Convert.ToDecimal(especial.Text),
                    bordaTradicional = Convert.ToDecimal(bordaTradicional.Text),
                    bordaEspecial = Convert.ToDecimal(bordaEspecial.Text),
                };
            }
            set
            {
                _valorSelecionado = value;
                PopularTela();
            }
        }

        #region métodos privado
        private void PopularTela()
        {
            ID.Text = _valorSelecionado.id.ToString();
            tamanho.SelectedItem = _valorSelecionado.tamanho.ToString();
            tradicional.Text = _valorSelecionado.tradicional.ToString();
            especial.Text = _valorSelecionado.especial.ToString();
            bordaTradicional.Text = _valorSelecionado.bordaTradicional.ToString();
            bordaEspecial.Text = _valorSelecionado.bordaEspecial.ToString();

            tamanho.Enabled = false;
        }
        private string ValidarCampos()
        {
            try
            {
                var valor = ValorSelecinado;

                if (ValorSelecinado.tamanho == 0)
                    return "Selecione um tamanho";

                if (valor.tradicional == 0)
                    return "Informe um valor para a pizza tradicional";

                if (valor.especial == 0)
                    return "Informe um valor para a pizza especial";

                if (valor.bordaTradicional == 0)
                    return "Informe um valor para a pizza borda tradicional";

                if (valor.bordaEspecial == 0)
                    return "Informe um valor para a pizza borda especial";

                if (valor.id == 0)
                {
                    var tamanhoSelecionadoJaExiste = BuscarValorPorTamanho(valor.tamanho).Value;

                    if (tamanhoSelecionadoJaExiste != null)
                        return "Tamanho não pode ser cadastrado novamente";
                }

            }
            catch (Exception ex)
            {
                return "Informe todos os dados antes de salvar";
            }

            return string.Empty;
        }
        private void ConfigurarTela()
        {
            panelAcoes.Controls.Add(AcoesUserControl);

            AcoesUserControl.btnSalvar.Click += (object? sender, EventArgs e) =>
            {
                SalvarRegistro();
            };

            new AjustarIdioma(this);

            Helpers.FocusTextBox(this);

            PreencherEnum(Enum.GetValues(typeof(TamanhoPizza)), tamanho);
        }

        private void SalvarRegistro()
        {
            var validarResult = ValidarCampos();

            if (validarResult != string.Empty)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(validarResult);
                DialogResult = DialogResult.None;
                return;
            }

            var gravarResult = Gravar(ValorSelecinado);

            TelaPrincipalForm.Instancia.AtualizarRodape(Properties.Resources.ResourceManager.GetString("mensagemSucessoCadastro"));
        }
        private void PreencherEnum(Array valores, ComboBox comboBox)
        {
            comboBox.Items.Clear();

            comboBox.Items.Clear();
            foreach (var i in valores)
            {
                comboBox.Items.Add(i.ToString());
            }
        }
        #endregion
    }
}
