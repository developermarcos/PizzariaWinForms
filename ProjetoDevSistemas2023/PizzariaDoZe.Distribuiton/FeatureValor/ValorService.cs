using FluentResults;
using PizzariaDoZe.Distribuiton.Compartilhado;
using PizzariaDoZe.Domain.FeatureValor;

namespace PizzariaDoZe.Distribuiton.FeatureValor
{
    public class ValorService : ServicoBase<Valor, ValidadorValor>
    {
        private IRepositorioValor repositorioValor;

        public ValorService(IRepositorioValor repositorioValor)
        {
            this.repositorioValor = repositorioValor;
        }

        public Result<Valor> Editar(Valor Valor)
        {
            Result resultado = Validar(Valor);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                repositorioValor.Editar(Valor);

                return Result.Ok(Valor);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar editar o Valor");
            }
        }

        public Result<Valor> Excluir(Valor Valor)
        {

            try
            {
                repositorioValor.Excluir(Valor);

                return Result.Ok(Valor);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar excluir o Valor");
            }
        }

        public Result<Valor> Inserir(Valor Valor)
        {
            Result resultado = Validar(Valor);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                repositorioValor.Inserir(Valor);

                return Result.Ok(Valor);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar inserir o Valor");
            }
        }

        public Result<List<Valor>> SelecionarTodos()
        {
            try
            {
                var result = repositorioValor.SelecionarTodos();

                if (result is null)
                {
                    Result.Fail("Nenhum Valor encontrando");
                }

                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar selecionar todos os Valores");
            }
        }

        public Result<Valor> SelecionarPorId(int id)
        {
            try
            {
                var result = repositorioValor.SelecionarPorId(id);

                if (result is null)
                {
                    Result.Fail("Nenhum Valor encontrando");
                }

                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar selecionar todos os Valors");
            }
        }
        public Result<Valor> SelecionarPorTamanho(TamanhoPizza tamanho)
        {
            try
            {
                var result = repositorioValor.SelecionarPorTamanho(tamanho);

                if (result is null)
                {
                    Result.Fail("Nenhum Valor encontrando");
                }

                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar selecionar todos os Valors");
            }
        }
    }
}
