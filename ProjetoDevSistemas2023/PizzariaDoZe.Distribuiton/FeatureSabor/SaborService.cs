using PizzariaDoZe.Domain.FeatureSabor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
