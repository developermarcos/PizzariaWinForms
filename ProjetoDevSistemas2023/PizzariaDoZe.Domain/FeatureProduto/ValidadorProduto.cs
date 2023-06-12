using FluentValidation;

namespace PizzariaDoZe.Domain.FeatureProduto
{
    public class ValidadorProduto : AbstractValidator<Produto>
    {
        public ValidadorProduto()
        {
            RuleFor(x => x.nome)
                .NotNull()
                .NotEmpty();
        }
    }
}
