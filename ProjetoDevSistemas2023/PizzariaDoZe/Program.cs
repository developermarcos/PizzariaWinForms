using PizzariaDoZe.Compartilhado.ExtensionMethods;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Infra;
using PizzariaDoZe.Infra.FeatureIngrediente;
using System.Configuration;
using System.Globalization;

namespace PizzariaDoZe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Idioma aplicação
            ProgramExtensions.SelecionarIdiomaAplicacao();
            #endregion

            Startup.InicializarInfra();

            var repositorio = new RepositorioIngrediente();

            var ingrediente = new IngredienteVO() {
                Nome = "Calabresa"
            };

            repositorio.Inserir(ingrediente);

            ApplicationConfiguration.Initialize();
            Application.Run(new TelaPrincipalForm());
        }
    }
}