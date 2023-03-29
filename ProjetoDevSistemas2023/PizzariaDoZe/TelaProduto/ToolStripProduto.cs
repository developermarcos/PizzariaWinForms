using PizzariaDoZe.Compartilhado.Configurar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.TelaProduto
{
    internal class ToolStripProduto : ToolStripBase
    {
        public override string InserirText => "Inserir Produto";

        public override string EditarText => "Editar Produto";

        public override string ExcluirText => "Excluir Produto";

        public override string FiltrarText => "Filtrar Produtos";

        public override bool habilitarInserir => true;

        public override bool habilitarEditar => true;

        public override bool habilitarExcluir => true;

        public override bool habilitarFiltrar => false;
    }
}
