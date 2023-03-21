using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Compartilhado.Configurar
{
    public abstract class ToolStripBase
    {
        public abstract string InserirText { get; }
        public abstract string EditarText { get; }
        public abstract string ExcluirText { get; }
        public abstract string FiltrarText { get; }

        public abstract bool habilitarInserir { get; }
        public abstract bool habilitarEditar { get; }
        public abstract bool habilitarExcluir { get; }
        public abstract bool habilitarFiltrar{ get; }
    }
}
