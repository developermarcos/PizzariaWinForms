using PizzariaDoZe.Domain.Compartilhado;
using PizzariaDoZe.Domain.FeatureFuncionario;

namespace PizzariaDoZe.Domain.FeaturePedido
{
    public interface IRepositorioPedido : IRepositorioBase<Pedido>
    {
        List<Pizza> SelecionarPizzarPorPedido(int id);
    }
}
