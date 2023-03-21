using PizzariaDoZe.Compartilhado.Configurar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Compartilhado
{
    public abstract class ControladorBase
    {
        protected TelaPrincipalForm TelaPrincipalForm { get; set; }
        public ControladorBase(TelaPrincipalForm telaPrincipalForm)
        {
            TelaPrincipalForm = telaPrincipalForm;
        }
        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Excluir();
        public abstract void Listar();
        public abstract ToolStripBase ToolTripConfiguracao { get; }
    }
}
