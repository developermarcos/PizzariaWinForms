using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Distribuiton.FeatureValor;
using PizzariaDoZe.TelaValor;

namespace PizzariaDoZe.Telas.Cadastros.TelaValor
{
    internal class ControladorValor : ControladorBase, ITelaTipoFiltrarDados
    {
        private ValorService valorService;

        public override ToolStripValor ToolTripConfiguracao => new ToolStripValor();
        protected override string _featureSingular => Properties.Resources.ResourceManager.GetString("FeatureValor");
        protected override string _featurePlural => Properties.Resources.ResourceManager.GetString("valoresToolStripMenuItem.Text");

        public ControladorValor()
        {

        }

        public ControladorValor(ValorService valorService)
        {
            this.valorService = valorService;
        }

        public override void Inserir()
        {
            TelaCadastroValorForm telaCadastroFuncionario =
            new TelaCadastroValorForm($"{_inserir} {_novo} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoInserido}");
                return;
            }

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroInserido}");

        }
        public override void Editar()
        {
            TelaCadastroValorForm telaCadastroValor = new TelaCadastroValorForm($"{_editar} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            if (telaCadastroValor.ShowDialog() == DialogResult.Cancel)
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
