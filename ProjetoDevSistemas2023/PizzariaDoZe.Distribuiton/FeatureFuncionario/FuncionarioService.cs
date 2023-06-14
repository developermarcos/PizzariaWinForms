using FluentResults;
using PizzariaDoZe.Distribuiton.Compartilhado;
using PizzariaDoZe.Domain.FeatureFuncionario;

namespace PizzariaDoZe.Distribuiton.FeatureFuncionario
{
    public class FuncionarioService : ServicoBase<Funcionario, ValidarFuncionario>
    {
        private IRepositorioFuncionario repositorioFuncionario;

        public FuncionarioService(IRepositorioFuncionario repositorioFuncionario)
        {
            this.repositorioFuncionario = repositorioFuncionario;
        }
        public Result<Funcionario> Editar(Funcionario Funcionario)
        {
            Result resultado = Validar(Funcionario);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                repositorioFuncionario.Editar(Funcionario);

                return Result.Ok(Funcionario);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar editar o Funcionario");
            }
        }

        public Result<Funcionario> Excluir(Funcionario Funcionario)
        {

            try
            {
                repositorioFuncionario.Excluir(Funcionario);

                return Result.Ok(Funcionario);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar excluir o Funcionario");
            }
        }

        public Result<Funcionario> Inserir(Funcionario Funcionario)
        {

            Result resultado = Validar(Funcionario);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                repositorioFuncionario.Inserir(Funcionario);

                return Result.Ok(Funcionario);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar inserir o Funcionario");
            }
        }

        public Result<List<Funcionario>> SelecionarTodos()
         {
            try
            {
                var result = repositorioFuncionario.SelecionarTodos();

                if (result is null)
                {
                    Result.Fail("Nenhum Funcionario encotrando");
                }

                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar selecionar todos os funcionarios");
            }
        }
        public Result<Funcionario> SelecionarPorId(int id)
        {
            try
            {
                var result = repositorioFuncionario.SelecionarPorId(id);

                if (result is null)
                {
                    Result.Fail("Nenhum Funcionario encontrando");
                }

                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar selecionar o Funcionario");
            }
        }
    }
}
