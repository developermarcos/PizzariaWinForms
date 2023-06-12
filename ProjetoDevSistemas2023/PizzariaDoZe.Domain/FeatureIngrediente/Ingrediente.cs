namespace PizzariaDoZe.Domain.FeatureIngrediente
{
    public class Ingrediente
    {
        public int id { get; set; }
        public string nome { get; set; }

        public override string ToString()
        {
            return nome;
        }
        public bool Igual(Ingrediente ingrediente)
        {
            return ingrediente.id == id && ingrediente.nome == nome;
        }
    }
}