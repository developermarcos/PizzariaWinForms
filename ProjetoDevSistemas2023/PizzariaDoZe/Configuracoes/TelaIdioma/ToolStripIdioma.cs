using PizzariaDoZe.Compartilhado.Configurar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Configuracoes.TelaIdioma
{
    internal class ToolStripIdioma : ToolStripBase
    {
        private string _feature = Properties.Resources.ResourceManager.GetString("FeatureIdioma");
        protected override string Feature => _feature;
        public override bool habilitarInserir => false;

        public override bool habilitarEditar => false;

        public override bool habilitarExcluir => false;

        public override bool habilitarFiltrar => false;
    }
}
