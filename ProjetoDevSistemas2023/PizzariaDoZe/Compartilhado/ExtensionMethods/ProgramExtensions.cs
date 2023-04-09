using PizzariaDoZe.Telas.Configuracoes.TelaIdioma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaDoZe.Compartilhado.ExtensionMethods
{
    public static class ProgramExtensions
    {
        private static void AtualizarIdiomaAppSettings(Idioma idioma)
        {
            var teste = EnumExtensions.GetDescription<Idioma>(idioma);
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", EnumExtensions.GetDescription<Idioma>(idioma));
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        /// <summary>
        /// Atualiza o idioma da aplicação
        /// </summary>
        /// <param name="idioma"></param>
        public static void AtualizarIdiomaAplicacao(Idioma idioma)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(idioma.GetDescription());
            Thread.CurrentThread.CurrentCulture = new CultureInfo(idioma.GetDescription());

            ProgramExtensions.AtualizarIdiomaAppSettings(idioma);
        }
        /// <summary>
        /// Busca idioma no arquivo de configuração e seta na aplicação
        /// </summary>
        public static void SelecionarIdiomaAplicacao()
        {
            string auxIdiomaRegiao = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
            //ajusta o idioma/região
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao);
        }
    }
}
