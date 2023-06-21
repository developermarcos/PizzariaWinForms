using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Distribuiton.FeatureCliente;
using PizzariaDoZe.Domain.FeatureCliente;
using PizzariaDoZe.Domain.FeaturePedido;
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

        protected override string _featureSingular => "Pedido";

        protected override string _featurePlural => "Pedidos";

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObtemListagem()
        {
            tabelaPedido = new TabelaPedidoControl();

            CarregarClientes();

            return tabelaPedido;
        }
        private void CarregarClientes()
        {
            //List<Pedido> pedidos = pedidoService.SelecionarTodos().Value;

            //tabelaPedido.AtualizarRegistros(pedidos);

            //TelaPrincipalForm.Instancia.AtualizarRodape($"{_listando} {clientes.Count} {_featurePlural}");
            TelaPrincipalForm.Instancia.AtualizarRodape($"Listando pedidos");

        }
        private Cliente ObtemClienteSelecionado()
        {
            var numero = tabelaPedido.ObtemNumeroContatoSelecionado();

            //return pedidoService.SelecionarPorId(numero).Value;
            return new Cliente();
        }

        public void Filtrar()
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("Nenhum filtro desponível no momento");
        }
    }
}
