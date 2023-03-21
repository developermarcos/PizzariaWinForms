using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.TelaCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.TelaIngrediente
{
    internal class ControladorIngrediente : ControladorBase, ITelaTipoFiltrarDados
    {
        public override ToolStripBase ToolTripConfiguracao => new ToolStripCliente();

        public ControladorIngrediente(TelaPrincipalForm telaPrincipalForm) : base(telaPrincipalForm)
        {

        }

        public override void Inserir()
        {
            TelaCadastroIngredienteForm telaCadastroFuncionario = new TelaCadastroIngredienteForm("Inserir novo ingrediente");

            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape("Nenhuma alteração feita");
                return;
            }

            TelaPrincipalForm.AtualizarRodape("Item salvo com sucesso");

        }
        public override void Editar()
        {
            TelaCadastroIngredienteForm telaCadastroFuncionario = new TelaCadastroIngredienteForm("Editar ingrediente");

            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape("Nenhuma alteração feita");
                return;
            }
            TelaPrincipalForm.AtualizarRodape("Item editado com sucesso");
        }

        public override void Excluir()
        {
            if (MessageBox.Show("Deseja realmente excluir o dado?", "Exclusão de ingredientes", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape("Nenhum item excluído!");
                return;
            }
            TelaPrincipalForm.AtualizarRodape("Item excluído com sucesso!");
        }

        public override void Listar()
        {
            TelaPrincipalForm.AtualizarRodape("Listando ingredientes");
        }

        public void Filtrar()
        {
            TelaPrincipalForm.AtualizarRodape("Nenhum filtro desponível no momento");
        }
    }
}
