namespace PizzariaDoZe.Compartilhado.UserControlComponentes
{
    public partial class UserControlEndereco : UserControl
    {
        public UserControlEndereco()
        {
            InitializeComponent();
        }
        public string Logradouro { get => rua.Text; set => rua.Text = value; }
        public string Bairro { get => bairro.Text; set => bairro.Text = value; }
        public string Numero { get => numero.Text; set => numero.Text = value; }
        public string Cep { get => cep.Text; set => cep.Text = value; }
        public string Cidade { get => cidade.Text; set => cidade.Text = value; }
        public string Pais { get => pais.Text; set => pais.Text = value; }
        public string Complemento { get => complemento.Text; set => complemento.Text = value; }
    }
}
