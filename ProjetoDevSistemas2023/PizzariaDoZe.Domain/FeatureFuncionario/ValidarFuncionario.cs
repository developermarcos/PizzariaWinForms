using FluentValidation;

namespace PizzariaDoZe.Domain.FeatureFuncionario
{
    public class ValidarFuncionario : AbstractValidator<Funcionario>
    {
        public ValidarFuncionario()
        {
            RuleFor(x => x.nome)
                .NotNull()
                .NotEmpty();
        }
    }
}
