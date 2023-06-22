using PizzariaDoZe.Domain.Compartilhado;

namespace PizzariaDoZe.Domain.FeatureCliente
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public bool excluido { get; set; }
        public Endereco endereco { get; set; }

        public override string ToString()
        {
            return $"{nome} | {cpf}";
        }
    }
}
