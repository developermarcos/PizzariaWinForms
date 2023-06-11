using PizzariaDoZe.Domain.FeatureIngrediente;

namespace PizzariaDoZe.Domain.FeatureSabor
{
    public class Sabor
    {
        public int id { get; set; }
        public string nome { get; set; }
        public byte[] foto { get; set; }
        public CategoriaSabor categoria { get; set; }
        public TipoSabor tipo { get; set; }

        public List<Ingrediente> ingredientes { get; set; }
        public Sabor()
        {
            ingredientes = new List<Ingrediente>();
        }
    }
    public enum TipoSabor
    {
        Salgada = 1,
        Doce = 2,
    }
    public enum CategoriaSabor
    {
        Tradicional = 1,
        Especial = 2,
    }
}
