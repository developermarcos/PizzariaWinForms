using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Domain.FeaturePedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Telas.TelaPedido
{
    public class ToolStripPedido : ToolStripBase
    {
        private string _feature = "Pedidos";
        protected override string Feature => _feature;
        public override bool habilitarInserir => true;

        public override bool habilitarEditar => true;

        public override bool habilitarExcluir => true;

        public override bool habilitarFiltrar => false;
    }
}
