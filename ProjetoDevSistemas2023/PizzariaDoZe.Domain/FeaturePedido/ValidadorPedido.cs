using FluentValidation;
using PizzariaDoZe.Domain.FeatureIngrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Domain.FeaturePedido
{
    public class ValidadorPedido : AbstractValidator<Pedido>
    {
        public ValidadorPedido()
        {
            //RuleFor(x => x.nome)
            //    .NotNull()
            //    .NotEmpty();
        }
    }
}
