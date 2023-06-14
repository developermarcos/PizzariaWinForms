using PizzariaDoZe.Compartilhado.ExtensionMethods;
using PizzariaDoZe.Domain.FeatureValor;

namespace PizzariaDoZe.Telas.Cadastros.TelaValor
{
    public partial class TabelaValorControl : UserControl
    {
        public TabelaValorControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "tamanho", HeaderText = "Tamanho"},

                new DataGridViewTextBoxColumn { DataPropertyName = "tradicional", HeaderText = "Tradicional"},

                new DataGridViewTextBoxColumn { DataPropertyName = "especial", HeaderText = "Especial"},

                new DataGridViewTextBoxColumn { DataPropertyName = "bordaTradicional", HeaderText = "Borda Trad."},

                new DataGridViewTextBoxColumn { DataPropertyName = "bordaEspecial", HeaderText = "Bord Esp."}
            };

            return colunas;
        }

        public int ObtemNumeroContatoSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Valor> produtos)
        {
            grid.DataSource = produtos;
        }
    }
}
