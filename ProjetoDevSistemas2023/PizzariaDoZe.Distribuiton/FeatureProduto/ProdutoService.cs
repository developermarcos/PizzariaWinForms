using FluentResults;
using PizzariaDoZe.Distribuiton.Compartilhado;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Domain.FeatureProduto;

namespace PizzariaDoZe.Distribuiton.FeatureProduto
{
    public class ProdutoService : ServicoBase<Produto, ValidadorProduto>
    {
        private IRepositorioProduto repositorioProduto;

        public ProdutoService(IRepositorioProduto repositorioProduto)
        {
            this.repositorioProduto = repositorioProduto;
        }

        public Result<Produto> Editar(Produto produto)
        {
            Result resultado = Validar(produto);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                repositorioProduto.Editar(produto);

                return Result.Ok(produto);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar editar o produto");
            }
        }

        public Result<Produto> Excluir(Produto produto)
        {

            try
            {
                repositorioProduto.Excluir(produto);

                return Result.Ok(produto);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar excluir o produto");
            }
        }

        public Result<Produto> Inserir(Produto produto)
        {
            Result resultado = Validar(produto);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                repositorioProduto.Inserir(produto);

                return Result.Ok(produto);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar inserir o produto");
            }
        }

        public Result<List<Produto>> SelecionarTodos()
        {
            try
            {
                var result = repositorioProduto.SelecionarTodos();

                if (result is null)
                {
                    Result.Fail("Nenhum produto encontrando");
                }

                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar selecionar todos os produtos");
            }
        }

        public Result<Produto> SelecionarPorId(int id)
        {
            try
            {
                var result = repositorioProduto.SelecionarPorId(id);

                if (result is null)
                {
                    Result.Fail("Nenhum produto encontrando");
                }

                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar selecionar todos os produtos");
            }
        }
    }
}
