using FluentValidation;
using PizzariaDoZe.Domain.FeatureIngrediente;

namespace PizzariaDoZe.Domain.FeatureCliente
{
    public class ValidadorCliente : AbstractValidator<Cliente>
    {
        public ValidadorCliente()
        {
            RuleFor(x => x.nome)
                .NotNull()
                .NotEmpty();
        }
    }
}
