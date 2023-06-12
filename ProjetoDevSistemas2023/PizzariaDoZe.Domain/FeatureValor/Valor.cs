namespace PizzariaDoZe.Domain.FeatureValor
{
    public class Valor
    {
        public int id { get; set; }
        public TamanhoPizza tamanho { get; set; }
        public decimal tradicional { get; set; }
        public decimal especial { get; set; }
        public decimal bordaTradicional { get; set; }
        public decimal bordaEspecial { get; set; }
    }
    public enum TamanhoPizza
    {
        p = 1, m = 2, g = 3
    }
}
