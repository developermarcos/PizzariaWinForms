using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.TelaValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.TelaValor
{
    internal class ControladorValor : ControladorBase, ITelaTipoFiltrarDados
    {
        public override ToolStripValor ToolTripConfiguracao => new ToolStripValor();

        public ControladorValor(TelaPrincipalForm telaPrincipalForm) : base(telaPrincipalForm)
        {

        }

        public override void Inserir()
        {
            TelaCadastroValorForm telaCadastroFuncionario = new TelaCadastroValorForm("Inserir novo Valor");

            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape("Nenhuma alteração feita");
                return;
            }

            TelaPrincipalForm.AtualizarRodape("Item salvo com sucesso");

        }
        public override void Editar()
        {
            TelaCadastroValorForm telaCadastroFuncionario = new TelaCadastroValorForm("Editar Valor");

            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape("Nenhuma alteração feita");
                return;
            }
            TelaPrincipalForm.AtualizarRodape("Item editado com sucesso");
        }

        public override void Excluir()
        {
            if (MessageBox.Show("Deseja realmente excluir o dado?", "Exclusão de Valores", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape("Nenhum item excluído!");
                return;
            }
            TelaPrincipalForm.AtualizarRodape("Item excluído com sucesso!");
        }

        public override void Listar()
        {
            TelaPrincipalForm.AtualizarRodape("Listando Valores");
        }

        public void Filtrar()
        {
            TelaPrincipalForm.AtualizarRodape("Nenhum filtro desponível no momento");
        }
    }
}
