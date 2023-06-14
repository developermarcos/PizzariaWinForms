using PizzariaDoZe.Compartilhado.ExtensionMethods;
using PizzariaDoZe.Domain.FeatureCliente;

namespace PizzariaDoZe.Telas.Cadastros.TelaCliente
{
    public partial class TabelaClienteControl : UserControl
    {
        public TabelaClienteControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "telefone", HeaderText = "Telefone"},

                new DataGridViewTextBoxColumn { DataPropertyName = "email", HeaderText = "Email"},
            };

            return colunas;
        }

        public int ObtemNumeroContatoSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            grid.DataSource = clientes;
        }
    }
}
