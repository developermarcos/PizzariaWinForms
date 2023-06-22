using PizzariaDoZe.Domain.FeatureProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Compartilhado.ExtensionMethods
{
    public static class ListBoxExtendions
    {
        public static List<T> ObterListObjetosSelecionados<T>(this ListBox checkBox) where T : class, new()
        {
            var list = new List<T>();

            foreach (T indexChecked in checkBox.Items)
                list.Add(indexChecked);

            return list;
        }
    }
}
