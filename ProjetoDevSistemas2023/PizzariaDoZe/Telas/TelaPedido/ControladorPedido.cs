using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Distribuiton.FeatureCliente;
using PizzariaDoZe.Distribuiton.FeaturePedido;
using PizzariaDoZe.Distribuiton.FeatureProduto;
using PizzariaDoZe.Distribuiton.FeatureSabor;
using PizzariaDoZe.Distribuiton.FeatureValor;
using PizzariaDoZe.Domain.FeatureCliente;
using PizzariaDoZe.Domain.FeaturePedido;
using PizzariaDoZe.TelaCliente;
using PizzariaDoZe.Telas.Cadastros.TelaCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Telas.TelaPedido
{
    public class ControladorPedido : ControladorBase, ITelaTipoFiltrarDados
    {
        public override ToolStripBase ToolTripConfiguracao => new ToolStripPedido();
        
        public TabelaPedidoControl tabelaPedido;
        private PedidoService pedidoService;
        private ProdutoService produtoService;
        private ClienteService clienteService;
        private SaborService saborService;
        private ValorService valorService;

        public ControladorPedido(PedidoService pedidoService, ProdutoService produtoService, ClienteService clienteService, SaborService saborService, ValorService valorService)
        {
            this.pedidoService = pedidoService;
            this.produtoService = produtoService;
            this.clienteService = clienteService;
            this.saborService = saborService;
            this.valorService = valorService;
        }

        protected override string _featureSingular => "Pedido";

        protected override string _featurePlural => "Pedidos";

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            Pedido pedidoSelecionado = this.ObtemClienteSelecionado();

            if (pedidoSelecionado is null || pedidoSelecionado.Id == 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Selecione um registro primeiro");

                return;
            }

            if (MessageBox.Show($"{_mensagemConfirmacaoExclusao}", $"{_excluir} {_featureSingular}", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoExcluido}");
                return;
            }

            pedidoService.Excluir(pedidoSelecionado);

            CarergarPedidos();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroExcluido}");
        }

        public override void Inserir()
        {

            TelaPedidoForm telaPedido =
                    new TelaPedidoForm($"{_inserir} {_novo} {_featureSingular}", saborService.SelecionarTodos().Value, valorService.SelecionarTodos().Value);

            telaPedido.Gravar = pedidoService.Inserir;

            telaPedido.Clientes = clienteService.SelecionarTodos().Value;

            telaPedido.Produtos = produtoService.SelecionarTodos().Value;

            if (telaPedido.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroNaoInserido}");
                return;
            }

            pedidoService.Inserir(telaPedido.Pedido);

            CarergarPedidos();

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_mensagemRegistroInserido}");
        }

        public override UserControl ObtemListagem()
        {
            tabelaPedido = new TabelaPedidoControl();

            CarergarPedidos();

            return tabelaPedido;
        }
        private void CarergarPedidos()
        {
            List<Pedido> pedidos = pedidoService.SelecionarTodos(true, true, true, true).Value;

            tabelaPedido.AtualizarRegistros(pedidos);

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_listando} {pedidos.Count} {_featurePlural}");
        }
        private Pedido ObtemClienteSelecionado()
        {
            var numero = tabelaPedido.ObtemNumeroContatoSelecionado();

            return pedidoService.SelecionarPorId(numero).Value;
        }

        public void Filtrar()
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("Nenhum filtro desponível no momento");
        }
    }
}
