using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Domain.Compartilhado.ExtensionMethods
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Recebe uma variavel do tipo Enum e retorno a descrição da opção recebida
        /// </summary>
        /// <typeparam name="T">Tipo T deve ser do tipo Enum</typeparam>
        /// <param name="enumValue">Enum</param>
        /// <returns>Enum</returns>
        public static string GetDescription<T>(this T enumValue)
            where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                return null;

            var description = enumValue.ToString();
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            if (fieldInfo != null)
            {
                var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (attrs != null && attrs.Length > 0)
                {
                    description = ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return description;
        }
    }
}
