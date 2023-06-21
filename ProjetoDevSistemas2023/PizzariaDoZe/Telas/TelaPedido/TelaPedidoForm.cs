using PizzariaDoZe.Compartilhado.UserControlComponentes;


namespace PizzariaDoZe.Telas.TelaPedido
{
    public partial class TelaPedidoForm : Form
    {
        private UserControlSalvarCancelar botoesControl = new UserControlSalvarCancelar();
        public TelaPedidoForm()
        {
            InitializeComponent();

            ConfigurarTela();
        }

        private void ConfigurarTela()
        {
            panelBotoes.Controls.Add(botoesControl);
        }
    }
}
