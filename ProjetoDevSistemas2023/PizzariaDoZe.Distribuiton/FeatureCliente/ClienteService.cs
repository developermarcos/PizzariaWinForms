using PizzariaDoZe.Domain.FeatureCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
