using FluentResults;
using PizzariaDoZe.Distribuiton.Compartilhado;
using PizzariaDoZe.Domain.FeatureSabor;

namespace PizzariaDoZe.Distribuiton.FeatureSabor
{
    public class SaborService : ServicoBase<Sabor, ValidadorSabor>
    {
        private IRepositorioSabor repositorioSabor;

        public SaborService(IRepositorioSabor repositorioSabor)
        {
            this.repositorioSabor = repositorioSabor;
        }

        public Result<Sabor> Editar(Sabor Sabor)
        {
            Result resultado = Validar(Sabor);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                repositorioSabor.Editar(Sabor);

                return Result.Ok(Sabor);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar editar o Sabor");
            }
        }

        public Result<Sabor> Excluir(Sabor Sabor)
        {

            try
            {
                repositorioSabor.Excluir(Sabor);

                return Result.Ok(Sabor);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar excluir o Sabor");
            }
        }

        public Result<Sabor> Inserir(Sabor Sabor)
        {

            Result resultado = Validar(Sabor);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                repositorioSabor.Inserir(Sabor);

                return Result.Ok(Sabor);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar inserir o Sabor");
            }
        }

        public Result<List<Sabor>> SelecionarTodos()
        {
            try
            {
                var result = repositorioSabor.SelecionarTodos();

                if (result is null)
                {
                    Result.Fail("Nenhum Sabor encotrando");
                }

                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar selecionar todos os Sabor");
            }
        }
        public Result<Sabor> SelecionarPorId(int id)
        {
            try
            {
                var result = repositorioSabor.SelecionarPorId(id);

                if (result is null)
                {
                    Result.Fail("Nenhum Sabor encotrando");
                }

                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar selecionar todos os Sabores");
            }
        }
    }
}
