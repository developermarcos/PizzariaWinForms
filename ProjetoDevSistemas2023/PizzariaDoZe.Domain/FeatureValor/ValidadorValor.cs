using FluentValidation;
using PizzariaDoZe.Domain.FeatureProduto;

namespace PizzariaDoZe.Domain.FeatureValor
{
    public class ValidadorValor : AbstractValidator<Valor>
    {
        public ValidadorValor()
        {
            //RuleFor(x => x.)
            //    .NotNull()
            //    .NotEmpty();
        }
    }
}
