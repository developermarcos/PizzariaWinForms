using PizzariaDoZe.Compartilhado.Configurar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.TelaIngrediente
{
    internal class ToolTripIngrediente : ToolStripBase
    {
        public override string InserirText => "Inserir Ingrediente";

        public override string EditarText => "Editar Ingrediente";

        public override string ExcluirText => "Excluir Ingrediente";

        public override string FiltrarText => "Filtrar Ingredientes";

        public override bool habilitarInserir => true;

        public override bool habilitarEditar => true;

        public override bool habilitarExcluir => true;

        public override bool habilitarFiltrar => false;
    }
}
