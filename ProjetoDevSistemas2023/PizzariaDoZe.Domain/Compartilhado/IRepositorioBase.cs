namespace PizzariaDoZe.Domain.Compartilhado
{
    public interface IRepositorioBase<T>
    {
        void Editar(T registro);
        void Excluir(T registro);
        void Inserir(T registro);
        T SelecionarPorId(int id);
        List<T> SelecionarTodos();
    }
}
