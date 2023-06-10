using PizzariaDoZe.Domain.FeatureFuncionario;

namespace PizzariaDoZe.Distribuiton.FeatureFuncionario
{
    public class FuncionarioService
    {
        private IRepositorioFuncionario repositorioFuncionario;

        public FuncionarioService(IRepositorioFuncionario repositorioFuncionario)
        {
            this.repositorioFuncionario = repositorioFuncionario;
        }
    }
}
