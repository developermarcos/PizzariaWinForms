using PizzariaDoZe.Compartilhado.Configurar;

namespace PizzariaDoZe.Telas.Cadastros.TelaCliente
{
    internal class ToolStripCliente : ToolStripBase
    {
        private string _feature = Properties.Resources.ResourceManager.GetString("FeatureCliente");
        protected override string Feature => _feature;
        public override bool habilitarInserir => true;

        public override bool habilitarEditar => true;

        public override bool habilitarExcluir => true;

        public override bool habilitarVisualizar => false;
    }
}
