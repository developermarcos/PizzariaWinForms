using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Distribuiton.FeatureIngrediente;
using PizzariaDoZe.Distribuiton.FeatureProduto;
using PizzariaDoZe.Distribuiton.FeatureSabor;
using PizzariaDoZe.Domain.FeatureProduto;
using PizzariaDoZe.Domain.FeatureSabor;
using PizzariaDoZe.Telas.Cadastros.TelaProduto;
using PizzariaDoZe.TelaSabores;

namespace PizzariaDoZe.Telas.Cadastros.TelaSabores
{
    internal class ControladorSabor : ControladorBase, ITelaTipoFiltrarDados
    {
        private SaborService saborService;
        private IngredienteService ingredienteService;

        public override ToolStripSabores ToolTripConfiguracao => new ToolStripSabores();
        protected override string _featureSingular => Properties.Resources.ResourceManager.GetString("FeatureSabor");
        protected override string _featurePlural => Properties.Resources.ResourceManager.GetString("saboresToolStripMenuItem.Text");

        private TabelaSaborControl tabelaSabor;

        public ControladorSabor(SaborService saborService, IngredienteService ingredienteService)
        {
            this.saborService = saborService;
            this.ingredienteService = ingredienteService;
        }

        public override void Inserir()
        {
            TelaCadastroFuncionarioForm telaCadastroSabor =
            new TelaCadastroFuncionarioForm($"{_inserir} {_novo} {_featureSingular}", ingredienteService.SelecionarTodos().Value);
            
            telaCadastroSabor.Ingredientes = ingredienteService.SelecionarTodos().Value;

            telaCadastroSabor.Gravar = saborService.Inserir;
            
            if (telaCadastroSabor.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoInserido}");
                return;
            }

            CarregarSabores();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroInserido}");

        }
        public override void Editar()
        {
            Sabor saborSelecionado = this.ObtemCompromissoSelecionado();

            if (saborSelecionado is null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Selecione um registro primeiro");

                return;
            }

            TelaCadastroFuncionarioForm telaCadastroSabor = new TelaCadastroFuncionarioForm($"{_editar} {_featureSingular}", ingredienteService.SelecionarTodos().Value);

            telaCadastroSabor.Gravar = saborService.Editar;

            telaCadastroSabor.SaborSelecionado = saborSelecionado;

            if (telaCadastroSabor.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoEditado}");
                return;
            }

            CarregarSabores();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroEditado}");
        }

        public override void Excluir()
        {
            Sabor saborSelecionado = this.ObtemCompromissoSelecionado();

            if (saborSelecionado is null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Selecione um registro primeiro");

                return;
            }

            if (MessageBox.Show($"{_mensagemConfirmacaoExclusao}", $"{_excluir} {_featureSingular}", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoExcluido}");
                return;
            }

            saborService.Excluir(saborSelecionado);

            CarregarSabores();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroExcluido}");
        }

        public override UserControl ObtemListagem()
        {
            tabelaSabor = new TabelaSaborControl();

            CarregarSabores();

            return tabelaSabor;
        }
        private void CarregarSabores()
        {
            List<Sabor> sabores = saborService.SelecionarTodos().Value;

            tabelaSabor.AtualizarRegistros(sabores);

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_listando} {sabores.Count} {_featurePlural}");

        }
        private Sabor ObtemCompromissoSelecionado()
        {
            var numero = tabelaSabor.ObtemNumeroContatoSelecionado();

            return saborService.SelecionarPorId(numero, true).Value;
        }

        public void Filtrar()
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("Nenhum filtro desponível no momento");
        }
    }
}
