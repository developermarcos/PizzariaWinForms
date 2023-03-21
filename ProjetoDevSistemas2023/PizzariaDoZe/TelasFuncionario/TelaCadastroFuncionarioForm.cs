using PizzariaDoZe.Compartilhado.UserControlComponentes;

namespace PizzariaDoZe.TelasFuncionario
{
    public partial class TelaCadastroFuncionarioForm : Form
    {
        private UserControlSalvarCancelar AcoesUserControl = new UserControlSalvarCancelar();
        private UserControlEndereco EnderecoUserControl = new UserControlEndereco();
        public TelaCadastroFuncionarioForm(string telaNome)
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
            id.Text = "ID: --";
        }
    }
}
