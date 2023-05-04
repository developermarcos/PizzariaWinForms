using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Compartilhado.UserControlComponentes;


namespace PizzariaDoZe.TelaCliente
{
    public partial class TelaCadastroProdutoForm : Form
    {
        private UserControlEndereco EnderecoUserControl = new UserControlEndereco();
        private UserControlSalvarCancelar AcoesUserControl = new UserControlSalvarCancelar();
        private List<Tuple<string, string>> Mensagens;

        public TelaCadastroProdutoForm(string telaNome, string mensagemDejesaSalvar, string mensagemDesejaCancelar)
        {
            InitializeComponent();
            Text = telaNome;
            Mensagens = new List<Tuple<string, string>>()
            {
                new Tuple<string, string>("mensagemSalvar", mensagemDejesaSalvar),
                new Tuple<string, string>("mensagemCancelar", mensagemDesejaCancelar)
            };
            Configurar();
        }

        private void Configurar()
        {
            ConfigurarTela();
            //PreencherTela();
        }

        private void ConfigurarTela()
        {
            panelAcoes.Controls.Add(AcoesUserControl);

            panelEndereco.Controls.Add(EnderecoUserControl);

            AcoesUserControl.btnSalvar.Click += (object? sender, EventArgs e) =>
            {
                if (MessageBox.Show(Mensagens.FirstOrDefault(t => t.Item1 == "mensagemSalvar").Item2, Text, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    DialogResult = DialogResult.None;
            };

            AcoesUserControl.btnCancelar.Click += (object? sender, EventArgs e) =>
            {
                if (MessageBox.Show(Mensagens.FirstOrDefault(t => t.Item1 == "mensagemCancelar").Item2, Text, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    DialogResult = DialogResult.None;
            };

            new AjustarIdioma(this);

            Helpers.FocusTextBox(this);
        }
    }
}
