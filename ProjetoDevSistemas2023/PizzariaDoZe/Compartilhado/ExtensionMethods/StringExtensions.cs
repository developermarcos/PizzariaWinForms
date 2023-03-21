using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PizzariaDoZe.Compartilhado.ExtensionMethods
{
    public static class StringExtensions
    {
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
