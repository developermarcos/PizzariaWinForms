using PizzariaDoZe.Domain.FeatureValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
