using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Distribuiton.FeatureSabor;
using PizzariaDoZe.Distribuiton.FeatureValor;
using PizzariaDoZe.Domain.FeatureSabor;
using PizzariaDoZe.Domain.FeatureValor;
using PizzariaDoZe.Telas.Cadastros.TelaSabores;
using PizzariaDoZe.TelaValor;

namespace PizzariaDoZe.Telas.Cadastros.TelaValor
{
    internal class ControladorValor : ControladorBase, ITelaTipoFiltrarDados
    {
        private ValorService valorService;

        public override ToolStripValor ToolTripConfiguracao => new ToolStripValor();
        protected override string _featureSingular => Properties.Resources.ResourceManager.GetString("FeatureValor");
        protected override string _featurePlural => Properties.Resources.ResourceManager.GetString("valoresToolStripMenuItem.Text");

        private TabelaValorControl tabelaValor;

        public ControladorValor(ValorService valorService)
        {
            this.valorService = valorService;
        }

        public override void Inserir()
        {
            TelaCadastroValorForm telaCadastroValor =
            new TelaCadastroValorForm($"{_inserir} {_novo} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            telaCadastroValor.Gravar = valorService.Inserir;

            telaCadastroValor.BuscarValorPorTamanho = valorService.SelecionarPorTamanho;

            if (telaCadastroValor.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoInserido}");
                return;
            }

            CarregarValores();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroInserido}");

        }
        public override void Editar()
        {
            Valor valorSelecionado = this.ObtemCompromissoSelecionado();

            if (valorSelecionado is null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Selecione um registro primeiro");

                return;
            }

            TelaCadastroValorForm telaCadastroValor = new TelaCadastroValorForm($"{_editar} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            telaCadastroValor.Gravar = valorService.Editar;

            telaCadastroValor.ValorSelecinado = valorSelecionado;

            if (telaCadastroValor.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoEditado}");
                return;
            }
            
            CarregarValores();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroEditado}");
        }

        public override void Excluir()
        {
            Valor valorSelecionado = this.ObtemCompromissoSelecionado();

            if (valorSelecionado is null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Selecione um registro primeiro");

                return;
            }

            if (MessageBox.Show($"{_mensagemConfirmacaoExclusao}", $"{_excluir} {_featureSingular}", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoExcluido}");
                return;
            }

            valorService.Excluir(valorSelecionado);

            CarregarValores();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroExcluido}");
        }

        public override UserControl ObtemListagem()
        {
            tabelaValor = new TabelaValorControl();
            
            CarregarValores();

            return tabelaValor;
        }
        private void CarregarValores()
        {
            List<Valor> valores = valorService.SelecionarTodos().Value;

            tabelaValor.AtualizarRegistros(valores);

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_listando} {valores.Count} {_featurePlural}");

        }
        private Valor ObtemCompromissoSelecionado()
        {
            var numero = tabelaValor.ObtemNumeroContatoSelecionado();

            return valorService.SelecionarPorId(numero).Value;
        }

        public void Filtrar()
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("Nenhum filtro desponível no momento");
        }
    }
}
