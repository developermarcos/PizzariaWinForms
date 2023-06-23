using PizzariaDoZe.Domain.Compartilhado;
using PizzariaDoZe.Domain.FeatureFuncionario;
using PizzariaDoZe.Domain.FeatureProduto;

namespace PizzariaDoZe.Domain.FeaturePedido
{
    public interface IRepositorioPedido : IRepositorioBase<Pedido>
    {
        List<Pizza> SelecionarPizzarPorPedido(int id);
        List<Produto> SelecionarProdutosPorPedido(int id);
    }
}
