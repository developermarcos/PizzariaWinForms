using PizzariaDoZe.Domain.FeatureIngrediente;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra
{
    public class Startup
    {
        public static void InicializarInfra()
        {
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
        }
    }
}
