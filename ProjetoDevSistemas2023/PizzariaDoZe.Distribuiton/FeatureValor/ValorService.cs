using PizzariaDoZe.Domain.FeatureValor;

namespace PizzariaDoZe.Distribuiton.FeatureValor
{
    public class ValorService
    {
        private IRepositorioValor repositorioValor;

        public ValorService(IRepositorioValor repositorioValor)
        {
            this.repositorioValor = repositorioValor;
        }
    }
}
