using PizzariaDoZe.Compartilhado.Configurar;

namespace PizzariaDoZe.TelasCadastro.TelaSabores
{
    internal class ToolStripSabores : ToolStripBase
    {
        private string _feature = Properties.Resources.ResourceManager.GetString("FeatureSabor");
        protected override string Feature => _feature;

        public override bool habilitarInserir => true;

        public override bool habilitarEditar => true;

        public override bool habilitarExcluir => true;

        public override bool habilitarFiltrar => false;
    }
}
