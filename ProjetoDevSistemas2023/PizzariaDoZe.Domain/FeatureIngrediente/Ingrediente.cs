namespace PizzariaDoZe.Domain.FeatureIngrediente
{
    public class Ingrediente
    {
        public int id_ingrediente { get; set; }
        public string descricao_ingrediente { get; set; }

        public override string ToString()
        {
            return descricao_ingrediente;
        }
    }
}