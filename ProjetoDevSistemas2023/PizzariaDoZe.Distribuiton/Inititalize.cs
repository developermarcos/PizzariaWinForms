using Microsoft.Extensions.DependencyInjection;
using PizzariaDoZe.Distribuiton.FeatureIngrediente;

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