using PizzariaDoZe.Compartilhado.Configurar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.TelaValor
{
    internal class ToolStripValor : ToolStripBase
    {
        public override string InserirText => "Inserir Valor";

        public override string EditarText => "Editar Valor";

        public override string ExcluirText => "Excluir Valor";

        public override string FiltrarText => "Filtrar Valores";

        public override bool habilitarInserir => true;

        public override bool habilitarEditar => true;

        public override bool habilitarExcluir => true;

        public override bool habilitarFiltrar => false;
    }
}
