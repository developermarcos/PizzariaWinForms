
using PizzariaDoZe.Domain.FeatureCliente;

namespace PizzariaDoZe.Compartilhado.ExtensionMethods
{
    public static class ComboBoxExtensions
    {
        public static void PopularComboBoxComEnum<T>(this ComboBox campo) where T : Enum
        {
            Array values = Enum.GetValues(typeof(T));

            campo.Items.Clear();
            foreach (var i in values)
            {
                campo.Items.Add(i.ToString());
            }
        }
        public static T ObterItemSelecionado<T>(this ComboBox campo) where T : class
        {
            if (campo.SelectedIndex < 0)
                return null;

            return (T)campo.Items[campo.SelectedIndex];
        }

        //public static T ObterEnumSelecionado<T>(this ComboBox campo) where T : Enum
        //{
        //    Array values = Enum.GetValues(typeof(T));

        //    if (campo.SelectedIndex < 0)
        //        return default;

        //    return (T)campo.Items[campo.SelectedIndex];
        //}
    }
}
