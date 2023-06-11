using FluentValidation;
using PizzariaDoZe.Domain.FeatureIngrediente;

namespace PizzariaDoZe.Domain.FeatureSabor
{
    public class ValidadorSabor : AbstractValidator<Sabor>
    {
        public ValidadorSabor()
        {
            RuleFor(x => x.nome)
                .NotNull()
                .NotEmpty();
        }
    }
}
