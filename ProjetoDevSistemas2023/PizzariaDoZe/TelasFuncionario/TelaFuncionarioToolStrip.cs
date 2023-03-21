using PizzariaDoZe.Compartilhado.Configurar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.TelasFuncionario
{
    internal class TelaFuncionarioToolStrip : ToolStripBase
    {
        public override string InserirText => "Inserir Funcionário";

        public override string EditarText => "Editar Funcionário";

        public override string ExcluirText => "Excluir Funcionário";

        public override string FiltrarText => "Filtrar Funcionário";

        public override bool habilitarInserir => true;

        public override bool habilitarEditar => true;

        public override bool habilitarExcluir => true;

        public override bool habilitarFiltrar => true;
    }
}
