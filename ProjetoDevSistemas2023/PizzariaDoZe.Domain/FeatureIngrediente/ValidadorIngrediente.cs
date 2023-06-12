using FluentValidation;

namespace PizzariaDoZe.Domain.FeatureIngrediente
{
    public class ValidadorIngrediente : AbstractValidator<Ingrediente>
    {
        public ValidadorIngrediente()
        {
            RuleFor(x => x.nome)
                .NotNull()
                .NotEmpty();
        }
    }
}
