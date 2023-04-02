using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.TelasFuncionario;
using System.ComponentModel.DataAnnotations;

namespace PizzariaDoZe.TelasCadastro.TelasFuncionario
{
    [Display(Name = "funcionario")]
    public class ControladorFuncionario : ControladorBase, ITelaTipoFiltrarDados
    {
        public override ToolStripBase ToolTripConfiguracao => new ToolStripFuncionario();
        protected override string _featureSingular => Properties.Resources.ResourceManager.GetString("FeatureFuncionario");
        protected override string _featurePlural => Properties.Resources.ResourceManager.GetString("funcionariosToolStripMenuItem.Text");

        public ControladorFuncionario(TelaPrincipalForm telaPrincipalForm) : base(telaPrincipalForm)
        {

        }

        public override void Inserir()
        {
            TelaCadastroFuncionarioForm telaCadastroFuncionario =
            new TelaCadastroFuncionarioForm($"{_inserir} {_novo} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape($"{_mensagemRegistroNaoInserido}");
                return;
            }

            TelaPrincipalForm.AtualizarRodape($"{_mensagemRegistroInserido}");

        }
        public override void Editar()
        {
            TelaCadastroFuncionarioForm telaCadastroProduto = new TelaCadastroFuncionarioForm($"{_editar} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            if (telaCadastroProduto.ShowDialog() == DialogResult.Cancel)
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

        public override void Listar()
        {
            TelaPrincipalForm.AtualizarRodape($"{_listando} 0 {_featurePlural}");
        }

        public void Filtrar()
        {
            TelaPrincipalForm.AtualizarRodape("Nenhum filtro desponível no momento");
        }
    }
}
