using PizzariaDoZe.Compartilhado.UserControlComponentes;
using PizzariaDoZe.Domain.FeatureSabor;
using PizzariaDoZe.Compartilhado.ExtensionMethods;
using PizzariaDoZe.Domain.FeaturePedido;
using PizzariaDoZe.Domain.FeatureValor;

namespace PizzariaDoZe.Telas.TelaPedido
{
    public partial class TelaPedidoPizzaForm : Form
    {
        private UserControlSalvarCancelar botoes = new UserControlSalvarCancelar();
        private List<Sabor> sabores;

        public TelaPedidoPizzaForm(List<Sabor> sabores)
        {
            InitializeComponent();

            panelBotoes.Controls.Add(botoes);

            this.sabores = sabores;

            PreencherTela();
        }
        public Pizza Pizza { get { return MontarPizza(); } }

        #region métodos privados
        private void PreencherTela()
        {
            tipo.PopularComboBoxComEnum<TipoSabor>();
            borda.PopularComboBoxComEnum<TipoBorda>();
            tamanho.PopularComboBoxComEnum<TamanhoPizza>();

            saboresListaCheckBox.Items.AddRange(sabores.ToArray());

            botoes.btnSalvar.Click += (object? sender, EventArgs e) =>
            {
                string resultado = ValidarCamposPreenchidos();

                if (resultado != string.Empty)
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape(resultado);

                    DialogResult = DialogResult.None;

                    return;
                }

                TelaPrincipalForm.Instancia.AtualizarRodape(Properties.Resources.ResourceManager.GetString("mensagemSucessoCadastro"));
            };
        }
        private string ValidarCamposPreenchidos()
        {
            try
            {
                var pizzaMontada = MontarPizza();

                if (pizzaMontada.sabores.Count == 0 || pizzaMontada.sabores.Count > 4)
                    return "Selecione pelo menos um sabor";

                if (pizzaMontada.TamanhoPizza == TamanhoPizza.p && pizzaMontada.sabores.Count != 1)
                    return "Pizza com tamanho p só pode conter 1 sabor";

                if (pizzaMontada.TamanhoPizza == TamanhoPizza.m && pizzaMontada.sabores.Count > 2)
                    return "Pizza com tamanho m pode conter até 2 sabor";

                if (pizzaMontada.TamanhoPizza == TamanhoPizza.g && pizzaMontada.sabores.Count > 4)
                    return "Pizza com tamanho g pode conter até 4 sabor";
            }
            catch (Exception ex)
            {
                return "Falha ao montar pizza";
            }

            return string.Empty;
        }
        private Pizza MontarPizza()
        {
            var pizza = new Pizza();

            pizza.TipoBorda = Enum.Parse<TipoBorda>(borda.Text);//Enum.TryParse<TipoBorda>(borda.Items[borda.SelectedIndex]);
            pizza.TamanhoPizza = Enum.Parse<TamanhoPizza>(tamanho.Text);//(TamanhoPizza)tamanho.Items[tamanho.SelectedIndex];
            pizza.sabores = saboresListaCheckBox.ObterListObjetosSelecionados<Sabor>();

            return pizza;
        }
        #endregion
    }
}
