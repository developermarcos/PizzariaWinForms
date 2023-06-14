using PizzariaDoZe.Domain.Compartilhado;

namespace PizzariaDoZe.Domain.FeatureFuncionario
{
    public class Funcionario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string matricula { get; set; }
        public string senha { get; set; }
        public GrupoFuncionario grupo { get; set; }
        public bool possuiHabilitacao { get; set; }
        public string cnh { get; set; }
        public DateTime validade_motorista { get; set; }
        public string observacao { get; set; }
        public bool excluido { get; set; }
        public Endereco endereco { get; set; }
    }
    public enum GrupoFuncionario
    {
        Administrador = 1,
        Atendente = 2,
        Motoboy = 3,
        Financeiro = 4
    }
}
