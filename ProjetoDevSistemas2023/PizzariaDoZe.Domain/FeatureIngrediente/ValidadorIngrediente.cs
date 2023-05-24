using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Domain.FeatureIngrediente
{
    public class ValidadorIngrediente : AbstractValidator<Ingrediente>
    {
        public ValidadorIngrediente()
        {
            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty();
        }
    }
}
