namespace PizzariaDoZe.Domain.Compartilhado
{
    public interface IRepositorioBase<T>
    {
        void Editar(T ingrediente);
        void Excluir(T ingrediente);
        void Inserir(T Ingrediente);
        T SelecionarPorId(int id);
        List<T> SelecionarTodos();
    }
}
