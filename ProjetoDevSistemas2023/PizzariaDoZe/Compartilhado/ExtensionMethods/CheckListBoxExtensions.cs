using PizzariaDoZe.Domain.FeatureSabor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Compartilhado.ExtensionMethods
{
    public static class CheckListBoxExtensions
    {
        public static List<T> ObterListObjetosSelecionados<T>(this CheckedListBox checkBox) where T : class, new()
        {
            var list = new List<T>();

            foreach (int indexChecked in checkBox.CheckedIndices)
                list.Add((T)checkBox.Items[indexChecked]);

            return list;
        }
    }
}
