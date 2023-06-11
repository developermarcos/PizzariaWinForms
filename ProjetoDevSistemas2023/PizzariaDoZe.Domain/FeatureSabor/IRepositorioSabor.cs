using PizzariaDoZe.Domain.Compartilhado;

namespace PizzariaDoZe.Domain.FeatureSabor
{
    public interface IRepositorioSabor : IRepositorioBase<Sabor>
    {
        Sabor SelecionarPorId(int id, bool incluirIngredientes);
    }
}
