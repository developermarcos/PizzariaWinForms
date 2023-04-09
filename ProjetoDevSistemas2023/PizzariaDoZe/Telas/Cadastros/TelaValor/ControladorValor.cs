using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.TelaValor;

namespace PizzariaDoZe.Telas.Cadastros.TelaValor
{
    internal class ControladorValor : ControladorBase, ITelaTipoFiltrarDados
    {
        public override ToolStripValor ToolTripConfiguracao => new ToolStripValor();
        protected override string _featureSingular => Properties.Resources.ResourceManager.GetString("FeatureValor");
        protected override string _featurePlural => Properties.Resources.ResourceManager.GetString("valoresToolStripMenuItem.Text");

        public ControladorValor(TelaPrincipalForm telaPrincipalForm) : base(telaPrincipalForm)
        {

        }

        public override void Inserir()
        {
            TelaCadastroValorForm telaCadastroFuncionario =
            new TelaCadastroValorForm($"{_inserir} {_novo} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape($"{_mensagemRegistroNaoInserido}");
                return;
            }

            TelaPrincipalForm.AtualizarRodape($"{_mensagemRegistroInserido}");

        }
        public override void Editar()
        {
            TelaCadastroValorForm telaCadastroValor = new TelaCadastroValorForm($"{_editar} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            if (telaCadastroValor.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape($"{_mensagemRegistroNaoEditado}");
                return;
            }
            TelaPrincipalForm.AtualizarRodape($"{_mensagemRegistroEditado}");
        }

        public override void Excluir()
        {
            if (MessageBox.Show($"{_mensagemConfirmacaoExclusao}", $"{_excluir} {_featureSingular}", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape($"{_mensagemRegistroNaoExcluido}");
                return;
            }
            TelaPrincipalForm.AtualizarRodape($"{_mensagemRegistroExcluido}");
        }

        public override void Listar(TelaPrincipalForm telaPrincipalForm)
        {
            telaPrincipalForm.AtualizarListagem(new Control());
            TelaPrincipalForm.AtualizarRodape($"{_listando} 0 {_featurePlural}");
        }

        public void Filtrar()
        {
            TelaPrincipalForm.AtualizarRodape("Nenhum filtro desponível no momento");
        }
    }
}
