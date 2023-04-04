using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.TelaCliente;

namespace PizzariaDoZe.TelasCadastro.TelaCliente
{
    internal class ControladorCliente : ControladorBase, ITelaTipoFiltrarDados
    {
        public override ToolStripBase ToolTripConfiguracao => new ToolStripCliente();

        protected override string _featureSingular => Properties.Resources.ResourceManager.GetString("FeatureCliente");

        protected override string _featurePlural => Properties.Resources.ResourceManager.GetString("clientesToolStripMenuItem.Text");

        public ControladorCliente(TelaPrincipalForm telaPrincipalForm) : base(telaPrincipalForm)
        {

        }

        public override void Inserir()
        {
            TelaCadastroProdutoForm telaCadastroFuncionario =
                new TelaCadastroProdutoForm($"{_inserir} {_novo} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape($"{_mensagemRegistroNaoInserido}");
                return;
            }

            TelaPrincipalForm.AtualizarRodape($"{_mensagemRegistroInserido}");

        }
        public override void Editar()
        {
            TelaCadastroProdutoForm telaCadastroFuncionario = new TelaCadastroProdutoForm($"{_editar} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
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
