using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Domain.FeatureIngrediente
{
    public interface IRepositorioIngrediente
    {
        void Inserir(Ingrediente Ingrediente);
        List<Ingrediente> SelecionarTodos();
    }
}
