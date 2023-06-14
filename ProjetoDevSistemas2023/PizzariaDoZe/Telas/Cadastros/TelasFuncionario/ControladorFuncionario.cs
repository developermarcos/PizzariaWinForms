using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Distribuiton.FeatureFuncionario;
using PizzariaDoZe.Domain.FeatureFuncionario;
using PizzariaDoZe.TelasFuncionario;
using System.ComponentModel.DataAnnotations;

namespace PizzariaDoZe.Telas.Cadastros.TelasFuncionario
{
    [Display(Name = "funcionario")]
    public class ControladorFuncionario : ControladorBase, ITelaTipoFiltrarDados
    {
        private FuncionarioService serviceFuncionario;

        public override ToolStripBase ToolTripConfiguracao => new ToolStripFuncionario();
        protected override string _featureSingular => Properties.Resources.ResourceManager.GetString("FeatureFuncionario");
        protected override string _featurePlural => Properties.Resources.ResourceManager.GetString("funcionariosToolStripMenuItem.Text");

        private TabelaFuncionarioControl tabelaFuncionario;
        public ControladorFuncionario()
        {

        }

        public ControladorFuncionario(FuncionarioService serviceFuncionario)
        {
            this.serviceFuncionario = serviceFuncionario;
        }

        public override void Inserir()
        {
            TelaCadastroFuncionarioForm telaCadastroFuncionario =
            new TelaCadastroFuncionarioForm($"{_inserir} {_novo} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            telaCadastroFuncionario.Gravar = serviceFuncionario.Inserir;

            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoInserido}");
                return;
            }

            CarregarFuncionarios();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroInserido}");

        }
        public override void Editar()
        {
            Funcionario funcionarioSelecionado = this.ObtemFuncionarioSelecionado();

            if (funcionarioSelecionado is null || funcionarioSelecionado.id == 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Selecione um registro primeiro");

                return;
            }

            TelaCadastroFuncionarioForm telaCadastroFuncionario = new TelaCadastroFuncionarioForm($"{_editar} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            telaCadastroFuncionario.Gravar = serviceFuncionario.Editar;

            telaCadastroFuncionario.FuncionarioSelecionado = funcionarioSelecionado;

            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoEditado}");
                return;
            }

            CarregarFuncionarios();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroEditado}");
        }

        public override void Excluir()
        {
            Funcionario funcionarioSelecionado = this.ObtemFuncionarioSelecionado();

            if (funcionarioSelecionado is null || funcionarioSelecionado.id == 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Selecione um registro primeiro");

                return;
            }

            if (MessageBox.Show($"{_mensagemConfirmacaoExclusao}", $"{_excluir} {_featureSingular}", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoExcluido}");
                return;
            }

            serviceFuncionario.Excluir(funcionarioSelecionado);

            CarregarFuncionarios();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroExcluido}");
        }

        public override UserControl ObtemListagem()
        {
            tabelaFuncionario = new TabelaFuncionarioControl();

            CarregarFuncionarios();

            return tabelaFuncionario;
        }
        private void CarregarFuncionarios()
        {
            List<Funcionario> Funcionarios = serviceFuncionario.SelecionarTodos().Value;

            tabelaFuncionario.AtualizarRegistros(Funcionarios);

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_listando} {Funcionarios.Count} {_featurePlural}");

        }
        private Funcionario ObtemFuncionarioSelecionado()
        {
            var numero = tabelaFuncionario.ObtemNumeroContatoSelecionado();

            return serviceFuncionario.SelecionarPorId(numero).Value;
        }

        public void Filtrar()
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("Nenhum filtro desponível no momento");
        }
    }
}
