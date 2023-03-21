using PizzariaDoZe.Compartilhado.Configurar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.TelaCliente
{
    internal class ToolStripCliente : ToolStripBase
    {
        public override string InserirText => "Inserir Cliente";

        public override string EditarText => "Editar Cliente";

        public override string ExcluirText => "Excluir Cliente";

        public override string FiltrarText => "Filtrar Clientes";

        public override bool habilitarInserir => true;

        public override bool habilitarEditar => true;

        public override bool habilitarExcluir => true;

        public override bool habilitarFiltrar => false;
    }
}
