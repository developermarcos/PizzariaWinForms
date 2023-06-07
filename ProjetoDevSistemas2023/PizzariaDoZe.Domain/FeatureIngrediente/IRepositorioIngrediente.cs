using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Domain.FeatureIngrediente
{
    public interface IRepositorioIngrediente
    {
        void Editar(Ingrediente ingrediente);
        void Excluir(Ingrediente ingrediente);
        void Inserir(Ingrediente Ingrediente);
        Ingrediente SelecionarPorId(int id);
        List<Ingrediente> SelecionarTodos();
    }
}
