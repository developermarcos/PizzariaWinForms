using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Distribuiton.FeatureProduto;
using PizzariaDoZe.TelaProduto;

namespace PizzariaDoZe.Telas.Cadastros.TelaProduto
{
    internal class ControladorProduto : ControladorBase, ITelaTipoFiltrarDados
    {
        private ProdutoService produtoService;

        public override ToolStripProduto ToolTripConfiguracao => new ToolStripProduto();
        protected override string _featureSingular => Properties.Resources.ResourceManager.GetString("FeatureProduto");
        protected override string _featurePlural => Properties.Resources.ResourceManager.GetString("produtosToolStripMenuItem.Text");

        public ControladorProduto()
        {

        }

        public ControladorProduto(ProdutoService produtoService)
        {
            this.produtoService = produtoService;
        }

        public override void Inserir()
        {
            TelaCadastroProdutoForm telaCadastroIngrediente =
                new TelaCadastroProdutoForm($"{_inserir} {_novo} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            if (telaCadastroIngrediente.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoInserido}");
                return;
            }

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroInserido}");

        }
        public override void Editar()
        {
            TelaCadastroProdutoForm telaCadastroProduto = new TelaCadastroProdutoForm($"{_editar} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            if (telaCadastroProduto.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoEditado}");
                return;
            }
            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroEditado}");
        }

        public override void Excluir()
        {
            if (MessageBox.Show($"{_mensagemConfirmacaoExclusao}", $"{_excluir} {_featureSingular}", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoExcluido}");
                return;
            }
            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroExcluido}");
        }

        public override UserControl ObtemListagem()
        {
            TelaPrincipalForm.Instancia.AtualizarRodape($"{_listando} 0 {_featurePlural}");
            return new UserControl();

        }

        public void Filtrar()
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("Nenhum filtro desponível no momento");
        }
    }
}
