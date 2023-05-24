using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.TelaSabores;

namespace PizzariaDoZe.Telas.Cadastros.TelaSabores
{
    internal class ControladorSabores : ControladorBase, ITelaTipoFiltrarDados
    {
        public override ToolStripSabores ToolTripConfiguracao => new ToolStripSabores();
        protected override string _featureSingular => Properties.Resources.ResourceManager.GetString("FeatureSabor");
        protected override string _featurePlural => Properties.Resources.ResourceManager.GetString("saboresToolStripMenuItem.Text");

        public ControladorSabores()
        {

        }

        public override void Inserir()
        {
            TelaCadastroFuncionarioForm telaCadastroSabor =
            new TelaCadastroFuncionarioForm($"{_inserir} {_novo} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            if (telaCadastroSabor.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoInserido}");
                return;
            }

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroInserido}");

        }
        public override void Editar()
        {
            TelaCadastroFuncionarioForm telaCadastroProduto = new TelaCadastroFuncionarioForm($"{_editar} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

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
