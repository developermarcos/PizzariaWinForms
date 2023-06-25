using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Distribuiton.FeatureIngrediente;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.TelaIngrediente;
using PizzariaDoZe.Telas.Cadastros.TelaCliente;

namespace PizzariaDoZe.Telas.Cadastros.TelaIngrediente
{
    internal class ControladorIngrediente : ControladorBase, ITelaTipoVisualizarDados
    {
        public override ToolStripBase ToolTripConfiguracao => new ToolStripCliente();
        protected override string _featureSingular => Properties.Resources.ResourceManager.GetString("FeatureIngrediente");
        protected override string _featurePlural => Properties.Resources.ResourceManager.GetString("ingredientesToolStripMenuItem.Text");

        private IngredienteService _ingredienteService;

        private TabelaingredientesControl tabelaingredientes;

        public ControladorIngrediente(IngredienteService serviceCliente)
        {
            _ingredienteService = serviceCliente;
        }

        public override void Inserir()
        {
            TelaCadastroIngredienteForm telaCadastroIngrediente =
                new TelaCadastroIngredienteForm($"{_inserir} {_novo} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            telaCadastroIngrediente.Gravar = _ingredienteService.Inserir;

            if (telaCadastroIngrediente.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoInserido}");
                return;
            }

            CarregarIngredientes();

        }
        public override void Editar()
        {

            Ingrediente ingredienteSelecionado = this.ObtemCompromissoSelecionado();

            if (ingredienteSelecionado is null || ingredienteSelecionado.id == 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Selecione um registro primeiro");

                return;
            }
            TelaCadastroIngredienteForm telaCadastroIngrediente = new TelaCadastroIngredienteForm($"{_editar} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            telaCadastroIngrediente.IngredienteSelecionado = ingredienteSelecionado;

            telaCadastroIngrediente.Gravar = _ingredienteService.Editar;

            if (telaCadastroIngrediente.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoEditado}");
                return;
            }

            CarregarIngredientes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroEditado}");
        }

        public override void Excluir()
        {
            Ingrediente IngredienteSelecionado = this.ObtemCompromissoSelecionado();

            if (IngredienteSelecionado == null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Selecione um registro caso deseje excluir");

                return;
            }
            if (MessageBox.Show($"{_mensagemConfirmacaoExclusao}", $"{_excluir} {_featureSingular}", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoExcluido}");
                return;
            }

            _ingredienteService.Excluir(IngredienteSelecionado);

            CarregarIngredientes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroExcluido}");
        }

        public override UserControl ObtemListagem()
        {
            tabelaingredientes = new TabelaingredientesControl();

            CarregarIngredientes();

            return tabelaingredientes;
        }

        public void Visualizar()
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("Nenhum filtro desponível no momento");
        }

        private void CarregarIngredientes()
        {
            List<Ingrediente> contatos = _ingredienteService.SelecionarTodos().Value;

            tabelaingredientes.AtualizarRegistros(contatos);

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_listando} {contatos.Count} {_featurePlural}");

        }

        private Ingrediente ObtemCompromissoSelecionado()
        {
            var numero = tabelaingredientes.ObtemNumeroContatoSelecionado();

            return _ingredienteService.SelecionarPorId(numero).Value;
        }
    }
}
