using PizzariaDoZe.Compartilhado.ExtensionMethods;
using PizzariaDoZe.Domain.FeatureFuncionario;

namespace PizzariaDoZe.Telas.Cadastros.TelasFuncionario
{
    public partial class TabelaFuncionarioControl : UserControl
    {
        public TabelaFuncionarioControl()
        {
            InitializeComponent();

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
            grid.Columns.AddRange(ObterColunas());
            this.Dock = DockStyle.Fill;
        }
        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "email", HeaderText = "Email"},

                new DataGridViewTextBoxColumn { DataPropertyName = "grupo", HeaderText = "Grupo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "telefone", HeaderText = "Telefone"},
            };

            return colunas;
        }

        public int ObtemNumeroContatoSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Funcionario> funcionarios)
        {
            grid.DataSource = funcionarios;
        }
    }
}
