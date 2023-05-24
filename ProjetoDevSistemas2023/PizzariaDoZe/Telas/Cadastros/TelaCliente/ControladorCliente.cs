using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.TelaCliente;


namespace PizzariaDoZe.Telas.Cadastros.TelaCliente
{
    internal class ControladorCliente : ControladorBase, ITelaTipoFiltrarDados
    {
        public override ToolStripBase ToolTripConfiguracao => new ToolStripCliente();

        protected override string _featureSingular => Properties.Resources.ResourceManager.GetString("FeatureCliente");

        protected override string _featurePlural => Properties.Resources.ResourceManager.GetString("clientesToolStripMenuItem.Text");

        public ControladorCliente()
        {

        }

        public override void Inserir()
        {
            TelaCadastroProdutoForm telaCadastroFuncionario =
                new TelaCadastroProdutoForm($"{_inserir} {_novo} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoInserido}");
                return;
            }

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroInserido}");

        }
        public override void Editar()
        {
            TelaCadastroProdutoForm telaCadastroFuncionario = new TelaCadastroProdutoForm($"{_editar} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
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
