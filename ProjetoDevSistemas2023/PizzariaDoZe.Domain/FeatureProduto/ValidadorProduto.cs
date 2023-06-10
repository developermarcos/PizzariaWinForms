using FluentValidation;

namespace PizzariaDoZe.Domain.FeatureProduto
{
    public class ValidadorProduto : AbstractValidator<Produto>
    {
        public ValidadorProduto()
        {
            RuleFor(x => x.descricao_produto)
                .NotNull()
                .NotEmpty();
        }
    }
}
