using FluentResults;
using PizzariaDoZe.Distribuiton.Compartilhado;
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
                return Result.Fail("Falha no sistema ao tentar inserir o Ingrediente");
            }
        }
    }
}
