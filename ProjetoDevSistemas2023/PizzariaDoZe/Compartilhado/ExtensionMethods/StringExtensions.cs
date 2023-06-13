using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

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
            //StringBuilder sbReturn = new StringBuilder();
            //var arrayText = texto.Normalize(NormalizationForm.FormD).ToCharArray();
            //foreach (char letter in arrayText)
            //{
            //    if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
            //        sbReturn.Append(letter);
            //}
            //return sbReturn.ToString().Trim().ToLower().Replace(" ", "");

            return Regex.Replace(texto, "[^0-9a-zA-Z]+", "").Trim();
        }

        public static string RetornaApenasNumeros(this string texto)
        {
            return Regex.Replace(texto, @"[^\d]", "");
        }

        public static bool ValidaCampoEstaVazioOuNuloOuTamanhoInvalido(this string text, int tamanhoMaximo, int tamanhoMinimo = 0)
        {
            if (text == null)
                return true;

            if (text == string.Empty)
                return true;

            if (text.Length > tamanhoMaximo)
                return true;

            if(tamanhoMinimo > 0 && text.Length < tamanhoMinimo)
                return true;

            return false;
        }

        public static string CampoVazioOuNuloOuTamanhoInvalido(this string text, string nomeCampo, int tamanhoMaximo, int tamanhoMinimo = 0)
        {
            if (text == null)
                return $"Campo {nomeCampo} vazio";

            if (text == string.Empty)
                return $"Campo {nomeCampo} vazio";

            if(text.Length > tamanhoMaximo)
                return $"Campo {nomeCampo} deve conter no máximo {tamanhoMaximo} caracteres";

            if (tamanhoMinimo > 0 && text.Length < tamanhoMinimo)
                return $"Campo {nomeCampo} deve conter no mínimo {tamanhoMinimo} caracteres";

            return string.Empty;
        }
    }
}
