using PizzariaDoZe.Compartilhado.ExtensionMethods;
using PizzariaDoZe.Domain.FeatureProduto;

namespace PizzariaDoZe.Telas.Cadastros.TelaProduto
{
    public partial class TabelaProdutoControl : UserControl
    {
        public TabelaProdutoControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "valor", HeaderText = "Valor"},

                new DataGridViewTextBoxColumn { DataPropertyName = "tipo", HeaderText = "Tipo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "medida_unitaria", HeaderText = "Medida Unitária (ML)"},
            };

            return colunas;
        }

        public int ObtemNumeroContatoSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Produto> produtos)
        {
            grid.DataSource = produtos;
        }
    }
}
