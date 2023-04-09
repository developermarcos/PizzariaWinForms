using PizzariaDoZe.Compartilhado.Configurar;

namespace PizzariaDoZe.Telas.Cadastros.TelaProduto
{
    internal class ToolStripProduto : ToolStripBase
    {
        private string _feature = Properties.Resources.ResourceManager.GetString("FeatureProduto");
        protected override string Feature => _feature;
        public override bool habilitarInserir => true;

        public override bool habilitarEditar => true;

        public override bool habilitarExcluir => true;

        public override bool habilitarFiltrar => false;
    }
}
