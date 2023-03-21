using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.TelasFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.TelaCliente
{
    internal class ControladorCliente : ControladorBase, ITelaTipoFiltrarDados
    {
        public override ToolStripBase ToolTripConfiguracao => new ToolStripCliente();

        public ControladorCliente(TelaPrincipalForm telaPrincipalForm) : base(telaPrincipalForm)
        {

        }

        public override void Inserir()
        {
            TelaCadastroClienteForm telaCadastroFuncionario = new TelaCadastroClienteForm("Inserir novo cliente");

            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape("Nenhuma alteração feita");
                return;
            }

            TelaPrincipalForm.AtualizarRodape("Item salvo com sucesso");

        }
        public override void Editar()
        {
            TelaCadastroClienteForm telaCadastroFuncionario = new TelaCadastroClienteForm("Editar cliente");

            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape("Nenhuma alteração feita");
                return;
            }
            TelaPrincipalForm.AtualizarRodape("Item editado com sucesso");
        }

        public override void Excluir()
        {
            if (MessageBox.Show("Deseja realmente excluir o dado?", "Exclusão de clientes", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape("Nenhum item excluído!");
                return;
            }
            TelaPrincipalForm.AtualizarRodape("Item excluído com sucesso!");
        }

        public override void Listar()
        {
            TelaPrincipalForm.AtualizarRodape("Listando clientess");
        }

        public void Filtrar()
        {
            TelaPrincipalForm.AtualizarRodape("Nenhum filtro desponível no momento");
        }
    }
}
