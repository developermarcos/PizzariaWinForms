using PizzariaDoZe.Domain.Compartilhado;

namespace PizzariaDoZe.Domain.FeatureValor
{
    public interface IRepositorioValor : IRepositorioBase<Valor>
    {
        Valor SelecionarPorTamanho(TamanhoPizza tamano);
    }
}
