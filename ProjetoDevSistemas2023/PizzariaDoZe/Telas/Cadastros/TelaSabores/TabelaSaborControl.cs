using PizzariaDoZe.Compartilhado.ExtensionMethods;
using PizzariaDoZe.Domain.FeatureSabor;

namespace PizzariaDoZe.Telas.Cadastros.TelaSabores
{
    public partial class TabelaSaborControl : UserControl
    {
        public TabelaSaborControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "categoria", HeaderText = "Categoria"},

                new DataGridViewTextBoxColumn { DataPropertyName = "tipo", HeaderText = "Tipo"},
            };

            return colunas;
        }

        public int ObtemNumeroContatoSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Sabor> produtos)
        {
            grid.DataSource = produtos;
        }
    }
}
