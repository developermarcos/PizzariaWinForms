using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Distribuiton.FeatureProduto;
using PizzariaDoZe.Domain.FeatureProduto;
using PizzariaDoZe.TelaProduto;

namespace PizzariaDoZe.Telas.Cadastros.TelaProduto
{
    internal class ControladorProduto : ControladorBase, ITelaTipoFiltrarDados
    {
        private ProdutoService _produtoService;

        public override ToolStripProduto ToolTripConfiguracao => new ToolStripProduto();
        protected override string _featureSingular => Properties.Resources.ResourceManager.GetString("FeatureProduto");
        protected override string _featurePlural => Properties.Resources.ResourceManager.GetString("produtosToolStripMenuItem.Text");

        private TabelaProdutoControl tabelaProduto;

        public ControladorProduto(ProdutoService produtoService)
        {
            this._produtoService = produtoService;
        }

        public override void Inserir()
        {
            TelaCadastroProdutoForm telaCadastroIngrediente =
                new TelaCadastroProdutoForm($"{_inserir} {_novo} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            telaCadastroIngrediente.Gravar = _produtoService.Inserir;

            if (telaCadastroIngrediente.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoInserido}");
                return;
            }

            CarregarIngredientes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroInserido}");

        }
        public override void Editar()
        {
            Produto produtoSelecionado = this.ObtemCompromissoSelecionado();

            if (produtoSelecionado is null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Selecione um registro primeiro");

                return;
            }

            TelaCadastroProdutoForm telaCadastroProduto = new TelaCadastroProdutoForm($"{_editar} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            telaCadastroProduto.ProdutoSelecionado = produtoSelecionado;

            telaCadastroProduto.Gravar = _produtoService.Editar;

            if (telaCadastroProduto.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoEditado}");
                return;
            }
            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroEditado}");

            CarregarIngredientes();
        }

        public override void Excluir()
        {
            Produto produtoSelecionado = this.ObtemCompromissoSelecionado();

            if (produtoSelecionado is null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Selecione um registro primeiro");

                return;
            }

            if (MessageBox.Show($"{_mensagemConfirmacaoExclusao}", $"{_excluir} {_featureSingular}", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoExcluido}");
                return;
            }

            _produtoService.Excluir(produtoSelecionado);

            CarregarIngredientes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroExcluido}");
        }

        public override UserControl ObtemListagem()
        {
            tabelaProduto = new TabelaProdutoControl();

            CarregarIngredientes();

            return tabelaProduto;
        }
        private void CarregarIngredientes()
        {
            List<Produto> produtos = _produtoService.SelecionarTodos().Value;

            tabelaProduto.AtualizarRegistros(produtos);

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_listando} {produtos.Count} {_featurePlural}");

        }
        private Produto ObtemCompromissoSelecionado()
        {
            var numero = tabelaProduto.ObtemNumeroContatoSelecionado();

            return _produtoService.SelecionarPorId(numero).Value;
        }

        public void Filtrar()
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("Nenhum filtro desponível no momento");
        }
    }
}
