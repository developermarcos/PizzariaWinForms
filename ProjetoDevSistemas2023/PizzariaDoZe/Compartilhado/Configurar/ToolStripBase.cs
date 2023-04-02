namespace PizzariaDoZe.Compartilhado.Configurar
{
    public abstract class ToolStripBase
    {
        private string Inserir = Properties.Resources.ResourceManager.GetString("btnInserir.Text");
        private string Editar = Properties.Resources.ResourceManager.GetString("btnEditar.Text");
        private string Excluir = Properties.Resources.ResourceManager.GetString("btnExcluir.Text");
        private string Filtrar = Properties.Resources.ResourceManager.GetString("btnFiltrar.Text");
        protected abstract string Feature { get; }
        public string InserirText { get => $"{Inserir} {Feature}"; }
        public string EditarText { get => $"{Editar} {Feature}"; }
        public string ExcluirText { get => $"{Excluir} {Feature}"; }
        public string FiltrarText { get => $"{Filtrar} {Feature}"; }

        public abstract bool habilitarInserir { get; }
        public abstract bool habilitarEditar { get; }
        public abstract bool habilitarExcluir { get; }
        public abstract bool habilitarFiltrar { get; }
    }
}
