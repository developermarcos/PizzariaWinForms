using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Distribuiton.FeatureCliente;
using PizzariaDoZe.Distribuiton.FeaturePedido;
using PizzariaDoZe.Distribuiton.FeatureProduto;
using PizzariaDoZe.Distribuiton.FeatureSabor;
using PizzariaDoZe.Distribuiton.FeatureValor;
using PizzariaDoZe.Domain.FeatureCliente;
using PizzariaDoZe.Domain.FeaturePedido;
using PizzariaDoZe.Infra.FeaturePedido;
using PizzariaDoZe.Infra.GerarPDF;
using PizzariaDoZe.TelaCliente;
using PizzariaDoZe.Telas.Cadastros.TelaCliente;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.Telas.TelaPedido
{
    public class ControladorPedido : ControladorBase, ITelaTipoVisualizarDados
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
        public void Visualizar()
        {
            var telaFiltro = new TelaPedidoFiltroForm();

            if (telaFiltro.ShowDialog() == DialogResult.Cancel) return;
            
            List<Pedido> pedidoSelecionado = new List<Pedido>();

            if(telaFiltro.TipoSelecionado == TipoFiltro.ApenasSelecionado)
                pedidoSelecionado.Add(this.ObtemClienteSelecionado(true));
            else
                pedidoSelecionado = pedidoService.SelecionarTodos(true).Value;

            if (pedidoSelecionado.Exists(x => x.Id != 0) == false)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Selecione um item primeiro");

                return;
            }

            using (SaveFileDialog SaveFileDialog = new SaveFileDialog())
            {
                SaveFileDialog.InitialDirectory = "C:";
                //SaveFileDialog.InitialDirectory = "c:\\";
                SaveFileDialog.Filter = "txt files (*.pdf)|*.pdf";
                SaveFileDialog.FilterIndex = 2;
                SaveFileDialog.RestoreDirectory = true;

                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    new GerarPDFPedido(SaveFileDialog.FileName, pedidoSelecionado).GerarPDF();

                    if (MessageBox.Show("Deseja abrir o arquivo?", "Abrir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        AbrirDocumentoPDF(SaveFileDialog.FileName);
                }
            }
        }

        #region métodos privados
        private void CarergarPedidos()
        {
            List<Pedido> pedidos = pedidoService.SelecionarTodos(true).Value;

            tabelaPedido.AtualizarRegistros(pedidos);

            TelaPrincipalForm.Instancia.AtualizarRodape($"{_listando} {pedidos.Count} {_featurePlural}");
        }
        private Pedido ObtemClienteSelecionado(bool incluirDependencas = false)
        {
            var numero = tabelaPedido.ObtemNumeroContatoSelecionado();

            return pedidoService.SelecionarPorId(numero, incluirDependencas).Value;
        }
        private void AbrirDocumentoPDF(string caminhoArquivo)
        {
            try
            {
                //Process.Start("C:/Users/marco/OneDrive/Área de Trabalho/teste.pdf");
                Process.Start(new ProcessStartInfo
                {
                    FileName = caminhoArquivo,
                    UseShellExecute = true
                });
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao abrir o documento PDF: " + e.Message);
            }
        }
        #endregion
    }
}
