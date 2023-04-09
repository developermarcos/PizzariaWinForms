using System.Globalization;
using System.Text;

namespace PizzariaDoZe.Compartilhado.ExtensionMethods
{
    public static class StringExtensions
    {
        /// <summary>
        /// Remove os caracters especiais e os espacoes da string, transformando todos os dados para lowercase
        /// </summary>
        /// <param name="texto">string</param>
        /// <returns>string</returns>
        public static string RemoverCaracterEspeciaisEhEspacoesEh(this string texto)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = texto.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString().Trim().ToLower();
        }
    }
}
