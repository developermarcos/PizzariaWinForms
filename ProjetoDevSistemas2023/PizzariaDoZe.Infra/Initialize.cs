using Microsoft.Extensions.DependencyInjection;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Infra.FeatureIngrediente;
using System.Data.Common;

namespace PizzariaDoZe.Infra
{
    public static class Initialize
    {
        public static void InitializeInfra(this ServiceCollection services)
        {
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);

            services.AddTransient<IRepositorioIngrediente, RepositorioIngrediente>();
        }
    }
}
