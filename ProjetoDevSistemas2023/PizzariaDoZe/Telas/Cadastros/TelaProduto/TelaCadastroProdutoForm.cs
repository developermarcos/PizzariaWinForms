using FluentResults;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Compartilhado.UserControlComponentes;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Domain.FeatureProduto;

namespace PizzariaDoZe.TelaProduto
{
    public partial class TelaCadastroProdutoForm : Form
    {
        private UserControlSalvarCancelar AcoesUserControl = new UserControlSalvarCancelar();
        private Produto _produtoSelecionado;
        public TelaCadastroProdutoForm(string nomeTela, string mensagemDejesaSalvar, string mensagemDesejaCancelar)
        {
            InitializeComponent();
            Text = nomeTela;
            ConfigurarTela();
        }

        public Func<Produto, Result<Produto>> Gravar { get; internal set; }

        public Produto ProdutoSelecionado
        {
            set
            {
                _produtoSelecionado = value;
                PopularTela();
            }
            private get
            {
                var produto = new Produto()
                {
                    descricao_produto = nome.Text,
                    medida_unitaria = ML.Text,
                    tipo = Enum.Parse<TipoProduto>(tipo.Text),
                    valor = Convert.ToDecimal(valor.Text)
                };

                if (id.Text != string.Empty && id.Text != "0")
                    produto.id_produto = Convert.ToInt32(id.Text);

                return produto;
            }
        }

        #region métodos privados
        private string ValidarCamposPreenchidos()
        {
            if (nome.Text.Length < 2)
                return "Nome invalido";

            if (ML.Text.Length < 2)
                return "Unidade de medida invalida";

            if (tipo.Text.Length < 2)
                return "Tipo invalido";

            if (valor.Text.Length < 2)
                return "Valor invalido";

            return string.Empty;
        }

        private void PopularTela()
        {
            id.Text = Convert.ToString(_produtoSelecionado.id_produto);
            nome.Text = _produtoSelecionado.descricao_produto;
            ML.Text = _produtoSelecionado.medida_unitaria;
            tipo.SelectedItem = _produtoSelecionado.tipo.ToString();
            valor.Text = _produtoSelecionado.valor.ToString();
        }

        private void ConfigurarTela()
        {
            panelAcoes.Controls.Add(AcoesUserControl);

            AcoesUserControl.btnSalvar.Click += (object? sender, EventArgs e) =>
            {
                SalvarProduto();
            };

            new AjustarIdioma(this);

            Helpers.FocusTextBox(this);


            Array values = Enum.GetValues(typeof(TipoProduto));

            tipo.Items.Clear();
            foreach (var i in values)
            {
                tipo.Items.Add(i.ToString());
            }
        }

        private void SalvarProduto()
        {
            string resultado = ValidarCamposPreenchidos();

            if (resultado != string.Empty)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(resultado);

                DialogResult = DialogResult.None;

                return;
            }

            var result = Gravar(ProdutoSelecionado);

            TelaPrincipalForm.Instancia.AtualizarRodape(Properties.Resources.ResourceManager.GetString("mensagemSucessoCadastro"));
        }
        #endregion
    }
}
