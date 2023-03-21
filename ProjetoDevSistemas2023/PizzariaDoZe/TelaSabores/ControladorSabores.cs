using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.TelaCliente;
using PizzariaDoZe.TelaIngrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.TelaSabores
{
    internal class ControladorSabores : ControladorBase, ITelaTipoFiltrarDados
    {
        public override ToolStripSabores ToolTripConfiguracao => new ToolStripSabores();

        public ControladorSabores(TelaPrincipalForm telaPrincipalForm) : base(telaPrincipalForm)
        {

        }

        public override void Inserir()
        {
            TelaCadastroSaboresForm telaCadastroFuncionario = new TelaCadastroSaboresForm("Inserir novo sabor");

            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape("Nenhuma alteração feita");
                return;
            }

            TelaPrincipalForm.AtualizarRodape("Item salvo com sucesso");

        }
        public override void Editar()
        {
            TelaCadastroSaboresForm telaCadastroFuncionario = new TelaCadastroSaboresForm("Editar sabor");

            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape("Nenhuma alteração feita");
                return;
            }
            TelaPrincipalForm.AtualizarRodape("Item editado com sucesso");
        }

        public override void Excluir()
        {
            if (MessageBox.Show("Deseja realmente excluir o dado?", "Exclusão de Sabores", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape("Nenhum item excluído!");
                return;
            }
            TelaPrincipalForm.AtualizarRodape("Item excluído com sucesso!");
        }

        public override void Listar()
        {
            TelaPrincipalForm.AtualizarRodape("Listando Sabores");
        }

        public void Filtrar()
        {
            TelaPrincipalForm.AtualizarRodape("Nenhum filtro desponível no momento");
        }
    }
}
