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
