using FluentResults;
using PizzariaDoZe.Distribuiton.Compartilhado;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Domain.FeatureProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
