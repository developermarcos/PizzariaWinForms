using PizzariaDoZe.Domain.FeatureCliente;

namespace PizzariaDoZe.Distribuiton.FeatureCliente
{
    public class ClienteService
    {
        private IRepositorioCliente repositorioCliente;

        public ClienteService(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }
    }
}
