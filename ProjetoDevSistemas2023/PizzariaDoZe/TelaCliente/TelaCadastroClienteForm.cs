using PizzariaDoZe.Compartilhado.UserControlComponentes;

namespace PizzariaDoZe.TelaCliente
{
    public partial class TelaCadastroClienteForm : Form
    {
        private UserControlSalvarCancelar AcoesUserControl = new UserControlSalvarCancelar();
        private UserControlEndereco EnderecoUserControl = new UserControlEndereco();
        public TelaCadastroClienteForm(string telaNome)
        {
            InitializeComponent();
            Text = telaNome;
            panelAcoes.Controls.Add(AcoesUserControl);
            AcoesUserControl.NomeTelaConfirmacao = telaNome;
            panelEndereco.Controls.Add(EnderecoUserControl);

            PreencherTela();
        }

        private void PreencherTela()
        {
            lbId.Text = "ID: --";
        }
    }
}
