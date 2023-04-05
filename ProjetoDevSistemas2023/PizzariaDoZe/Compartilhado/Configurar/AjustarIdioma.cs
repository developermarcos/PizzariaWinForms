using System.ComponentModel;

namespace PizzariaDoZe.Compartilhado.Configurar
{
    public class AjustarIdioma
    {
        public AjustarIdioma(Control Formulario)
        {
            foreach (Control c in Formulario.Controls)
            {
                new AjustarIdioma(c);
                ComponentResourceManager resources = new(typeof(Properties.Resources));
                var teste = resources.BaseName;
                resources.ApplyResources(c, c.Name);
            }
        }
    }
}
