using PizzariaDoZe.Compartilhado.Configurar;

namespace PizzariaDoZe.Telas.Cadastros.TelasFuncionario
{
    internal class ToolStripFuncionario : ToolStripBase
    {
        private string _feature = Properties.Resources.ResourceManager.GetString("FeatureFuncionario");
        protected override string Feature => _feature;

        public override bool habilitarInserir => true;

        public override bool habilitarEditar => true;

        public override bool habilitarExcluir => true;

        public override bool habilitarVisualizar => false;
    }
}
