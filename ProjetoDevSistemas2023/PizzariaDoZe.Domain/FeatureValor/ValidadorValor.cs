using FluentValidation;

namespace PizzariaDoZe.Domain.FeatureValor
{
    public class ValidadorValor : AbstractValidator<Valor>
    {
        public ValidadorValor()
        {
            RuleFor(x => x.tamanho)
                .NotNull()
                .NotEmpty();
        }
    }
}
