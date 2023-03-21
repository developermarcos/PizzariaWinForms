using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.TelaCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzariaDoZe.TelasFuncionario
{
    [Display(Name = "funcionario")]
    public class ControladorFuncionario : ControladorBase, ITelaTipoFiltrarDados
    {
        public override ToolStripBase ToolTripConfiguracao => new ToolStripFuncionario();

        public ControladorFuncionario(TelaPrincipalForm telaPrincipalForm) : base(telaPrincipalForm)
        {

        }

        public override void Inserir()
        {
            TelaCadastroFuncionarioForm telaCadastroFuncionario = new TelaCadastroFuncionarioForm("Inserir novo funcionário");

            if(telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape("Nenhuma alteração feita");
                return;
            }

            TelaPrincipalForm.AtualizarRodape("Item salvo com sucesso");

        }
        public override void Editar()
        {
            TelaCadastroFuncionarioForm telaCadastroFuncionario = new TelaCadastroFuncionarioForm("Editar funcionário");
            
            if (telaCadastroFuncionario.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape("Nenhuma alteração feita");
                return;
            }
            TelaPrincipalForm.AtualizarRodape("Item editado com sucesso");
        }

        public override void Excluir()
        {
            if (MessageBox.Show("Deseja realmente excluir o dado?", "Exclusão de funcionários", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape("Nenhum item excluído!");
                return;
            }
            TelaPrincipalForm.AtualizarRodape("Item excluído com sucesso!");
        }

        public override void Listar()
        {
            TelaPrincipalForm.AtualizarRodape("Listando funcionarios");
        }

        public void Filtrar()
        {
            TelaPrincipalForm.AtualizarRodape("Nenhum filtro desponível no momento");
        }
    }
}
