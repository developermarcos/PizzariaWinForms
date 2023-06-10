using PizzariaDoZe.Domain.FeatureSabor;

namespace PizzariaDoZe.Distribuiton.FeatureSabor
{
    public class SaborService
    {
        private IRepositorioSabor repositorioSabor;

        public SaborService(IRepositorioSabor repositorioSabor)
        {
            this.repositorioSabor = repositorioSabor;
        }
    }
}
