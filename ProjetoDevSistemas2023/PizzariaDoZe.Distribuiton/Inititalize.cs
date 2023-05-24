using Microsoft.Extensions.DependencyInjection;
using PizzariaDoZe.Distribuiton.FeatureIngrediente;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Infra.FeatureIngrediente;
using System.Data.Common;

namespace PizzariaDoZe.Distribuiton
{
    public static class Inititalize
    {
        public static void InitializeServices(this ServiceCollection services)
        {
            services.AddSingleton<IngredienteService>();
        }
    }
}