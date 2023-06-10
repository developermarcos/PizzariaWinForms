using PizzariaDoZe.Compartilhado.ExtensionMethods;
using PizzariaDoZe.Domain.FeatureIngrediente;

namespace PizzariaDoZe.Telas.Cadastros.TelaIngrediente
{
    public partial class TabelaingredientesControl : UserControl
    {
        public TabelaingredientesControl()
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
                new DataGridViewTextBoxColumn { DataPropertyName = "id_ingrediente", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "descricao_ingrediente", HeaderText = "Nome"}
            };

            return colunas;
        }

        public int ObtemNumeroContatoSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Ingrediente> ingredientes)
        {
            grid.DataSource = ingredientes;
        }
    }
}
