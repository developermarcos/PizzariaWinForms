using PizzariaDoZe.Compartilhado.Configurar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.TelaSabores
{
    internal class ToolStripSabores : ToolStripBase
    {
        public override string InserirText => "Inserir Sabor";

        public override string EditarText => "Editar Sabor";

        public override string ExcluirText => "Excluir Sabor";

        public override string FiltrarText => "Filtrar Sabores";

        public override bool habilitarInserir => true;

        public override bool habilitarEditar => true;

        public override bool habilitarExcluir => true;

        public override bool habilitarFiltrar => false;
    }
}
