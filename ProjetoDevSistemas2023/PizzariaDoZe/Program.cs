using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.ExtensionMethods;

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

            ApplicationConfiguration.Initialize();
            Application.Run(new TelaPrincipalForm(new Dependencias()));
        }
    }
}