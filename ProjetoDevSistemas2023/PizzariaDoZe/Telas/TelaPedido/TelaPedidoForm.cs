using FluentResults;
using PizzariaDoZe.Compartilhado.ExtensionMethods;
using PizzariaDoZe.Compartilhado.UserControlComponentes;
using PizzariaDoZe.Distribuiton.FeaturePedido;
using PizzariaDoZe.Distribuiton.FeatureValor;
using PizzariaDoZe.Domain.FeatureCliente;
using PizzariaDoZe.Domain.FeaturePedido;
using PizzariaDoZe.Domain.FeatureProduto;
using PizzariaDoZe.Domain.FeatureSabor;
using PizzariaDoZe.Domain.FeatureValor;

namespace PizzariaDoZe.Telas.TelaPedido
{
    public partial class TelaPedidoForm : Form
    {
        private UserControlSalvarCancelar botoesControl = new UserControlSalvarCancelar();
        private List<Cliente> _clientes { get; set; }

        private Cliente clienteSelecionado = new Cliente();
        private List<Sabor> _sabores { get; set; }
        private List<Produto> _produtos { get; set; }
        private List<Valor> _valores { get; set; }

        private List<Pizza> _pizzas = new List<Pizza>();
        public TelaPedidoForm(string titulo, List<Sabor> sabores, List<Valor> valores)
        {
            InitializeComponent();

            Text = titulo;

            _sabores = sabores;

            _valores = valores;

            ConfigurarTela();
        }

        #region pré-requisitos para tela
        public Func<Pedido, Result<Pedido>> Gravar { get; internal set; }
        public List<Cliente> Clientes { set { _clientes = value; PopularClientes(_clientes); } }
        public List<Produto> Produtos { set { _produtos = value; PopularProdutos(_produtos); } }
        public Pedido Pedido { get { return ObterPedido(); } }

        #endregion

        #region métodos Preencher/popular tela
        private void PopularClientes(List<Cliente> clientes)
        {
            clienteLista.Items.Clear();

            clienteLista.Items.AddRange(clientes.ToArray());
        }

        private void PopularProdutos(List<Produto> produtos)
        {
            produtoLista.Items.Clear();

            produtoLista.Items.AddRange(produtos.ToArray());
        }

        private void ConfigurarTela()
        {
            panelBotoes.Controls.Add(botoesControl);

            botoesControl.btnSalvar.Click += (object? sender, EventArgs e) =>
            {
                SalvarRegistro();
            };
        }


        private void PreencherCamposCliente()
        {
            clienteEndereco.Text = clienteSelecionado.endereco.ToString();
            clienteTelefone.Text = clienteSelecionado.telefone;
        }
        private void clienteLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            clienteSelecionado = clienteLista.ObterItemSelecionado<Cliente>();

            PreencherCamposCliente();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clienteEndereco.Text = string.Empty;
            clienteTelefone.Text = string.Empty;
            clienteLista.SelectedIndex = -1;
        }

        #endregion

        #region pizzas
        private void btnMontarPizza_Click(object sender, EventArgs e)
        {
            TelaPedidoPizzaForm telaPizza = new TelaPedidoPizzaForm(_sabores);

            if (telaPizza.ShowDialog() == DialogResult.Cancel)
                return;

            _pizzas.Add(telaPizza.Pizza);

            pizzasMontadas.Items.Add(telaPizza.Pizza);
        }
        private void btnExcluirPizza_Click(object sender, EventArgs e)
        {
            pizzasMontadas.Items.Remove(pizzasMontadas.Items[pizzasMontadas.SelectedIndex]);
        }
        #endregion

        #region produtos
        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            Produto produtoSelecionado = produtoLista.ObterItemSelecionado<Produto>();

            if (produtoSelecionado == null)
                return;

            produtosListaAdicionados.Items.Add(produtoSelecionado);
        }
        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            produtosListaAdicionados.Items.Remove(produtosListaAdicionados.Items[produtosListaAdicionados.SelectedIndex]);
        }
        #endregion

        #region métodos salvar pedido
        private void SalvarRegistro()
        {
            string resultado = ValidarCamposPreenchidos();

            if (resultado != string.Empty)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(resultado);

                DialogResult = DialogResult.None;

                return;
            }
        }

        private string ValidarCamposPreenchidos()
        {
            try
            {
                var pedido = ObterPedido();

                if (pedido.ClienteId == 0)
                    return "Pedido deve conter um cliente";

                if (pedido.Pizzas.Count == 0)
                    return "Pedido deve conter uma pizza";
            }
            catch (Exception ex)
            {
                return "Falha ao montar pedido, contate o administrador do sistema";
            }
            return string.Empty;
        }

        private Pedido ObterPedido()
        {
            return new Pedido() {
                Produtos = produtosListaAdicionados.ObterListObjetosSelecionados<Produto>(),
                dataPedido = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy")),
                ClienteId = clienteSelecionado.id,
                FuncionarioId = 1,
                Pizzas = ObterPizzasComValor(),
            };
        }

        private List<Pizza> ObterPizzasComValor()
        {
            var pizzas = pizzasMontadas.ObterListObjetosSelecionados<Pizza>();

            pizzas.ForEach(pizza => pizza.CalcularValor(_valores));

            return pizzas;
        }
        #endregion
    }
}
