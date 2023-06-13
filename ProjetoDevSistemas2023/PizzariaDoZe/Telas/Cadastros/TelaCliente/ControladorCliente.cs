using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Distribuiton.FeatureCliente;
using PizzariaDoZe.Distribuiton.FeatureProduto;
using PizzariaDoZe.Domain.FeatureCliente;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Domain.FeatureProduto;
using PizzariaDoZe.TelaCliente;


namespace PizzariaDoZe.Telas.Cadastros.TelaCliente
{
    internal class ControladorCliente : ControladorBase, ITelaTipoFiltrarDados
    {
        private ClienteService clienteService;

        public override ToolStripBase ToolTripConfiguracao => new ToolStripCliente();

        protected override string _featureSingular => Properties.Resources.ResourceManager.GetString("FeatureCliente");

        protected override string _featurePlural => Properties.Resources.ResourceManager.GetString("clientesToolStripMenuItem.Text");

        public TabelaClienteControl tabelaCliente;

        public ControladorCliente()
        {

        }

        public ControladorCliente(ClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        public override void Inserir()
        {
            TelaCadastroClienteForm telaCadastroCliente =
                    new TelaCadastroClienteForm($"{_inserir} {_novo} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            telaCadastroCliente.Gravar = clienteService.Inserir;

            if (telaCadastroCliente.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoInserido}");
                return;
            }
            CarregarClientes();
            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroInserido}");

        }
        public override void Editar()
        {
            Cliente clienteSelecionado = this.ObtemClienteSelecionado();

            if (clienteSelecionado is null || clienteSelecionado.id == 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Selecione um registro primeiro");

                return;
            }

            TelaCadastroClienteForm telaCadastroCliente = new TelaCadastroClienteForm($"{_editar} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            telaCadastroCliente.Gravar = clienteService.Editar;

            telaCadastroCliente.ClienteSelecionado = clienteSelecionado;

            if (telaCadastroCliente.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoEditado}");
                return;
            }

            CarregarClientes();
            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroEditado}");
        }

        public override void Excluir()
        {
            Cliente clienteSelecionado = this.ObtemClienteSelecionado();

            if (clienteSelecionado is null || clienteSelecionado.id == 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Selecione um registro primeiro");

                return;
            }

            if (MessageBox.Show($"{_mensagemConfirmacaoExclusao}", $"{_excluir} {_featureSingular}", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoExcluido}");
                return;
            }

            clienteService.Excluir(clienteSelecionado);

            CarregarClientes();
            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroExcluido}");
        }

        public override UserControl ObtemListagem()
        {
            tabelaCliente = new TabelaClienteControl();

            CarregarClientes();

            return tabelaCliente;
        }
        private void CarregarClientes()
        {
            List<Cliente> clientes = clienteService.SelecionarTodos().Value;

            tabelaCliente.AtualizarRegistros(clientes);

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_listando} {clientes.Count} {_featurePlural}");

        }
        private Cliente ObtemClienteSelecionado()
        {
            var numero = tabelaCliente.ObtemNumeroContatoSelecionado();

            return clienteService.SelecionarPorId(numero).Value;
        }

        public void Filtrar()
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("Nenhum filtro desponível no momento");
        }
    }
}
