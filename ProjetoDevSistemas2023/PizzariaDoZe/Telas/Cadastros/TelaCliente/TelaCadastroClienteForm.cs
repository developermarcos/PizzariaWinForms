using FluentResults;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Compartilhado.UserControlComponentes;
using PizzariaDoZe.Domain.Compartilhado;
using PizzariaDoZe.Domain.Compartilhado.ExtensionMethods;
using PizzariaDoZe.Domain.FeatureCliente;

namespace PizzariaDoZe.TelaCliente
{
    public partial class TelaCadastroClienteForm : Form
    {
        private UserControlEndereco EnderecoUserControl = new UserControlEndereco();
        private UserControlSalvarCancelar AcoesUserControl = new UserControlSalvarCancelar();
        private Cliente cliente;

        public TelaCadastroClienteForm(string telaNome, string mensagemDejesaSalvar, string mensagemDesejaCancelar)
        {
            InitializeComponent();
            Text = telaNome;
            ConfigurarTela();
        }
        public Cliente ClienteSelecionado
        {
            private get
            {
                return new Cliente()
                {
                    id = string.IsNullOrEmpty(id.Text) ? 0 : Convert.ToInt32(id.Text),
                    nome = nome.Text,
                    cpf = cpf.Text.RetornaApenasNumeros(),
                    email = email.Text,
                    telefone = telefone.Text.RemoverCaracterEspeciaisEhEspacoesEh(),
                    endereco = new Endereco()
                    {
                        logradouro = EnderecoUserControl.Logradouro,
                        bairro = EnderecoUserControl.Bairro,
                        numero = EnderecoUserControl.Numero,
                        cep = EnderecoUserControl.Cep,
                        cidade = EnderecoUserControl.Cidade,
                        pais = EnderecoUserControl.Pais,
                        complemento = EnderecoUserControl.Complemento
                    }
                };
            }
            set
            {
                cliente = value;
                PopularTela();
            }
        }

        public Func<Cliente, Result<Cliente>> Gravar { get; internal set; }

        #region métodos auxiliares
        private void PopularTela()
        {
            id.Text = cliente.id.ToString();
            nome.Text = cliente.nome;
            cpf.Text = cliente.cpf;
            email.Text = cliente.email;
            telefone.Text = cliente.telefone;
            EnderecoUserControl.Logradouro = cliente.endereco.logradouro;
            EnderecoUserControl.Bairro = cliente.endereco.bairro;
            EnderecoUserControl.Numero = cliente.endereco.numero;
            EnderecoUserControl.Cep = cliente.endereco.cep;
            EnderecoUserControl.Cidade = cliente.endereco.cidade;
            EnderecoUserControl.Pais = cliente.endereco.pais;
            EnderecoUserControl.Complemento = cliente.endereco.complemento;

        }
        private string ValidarCamposPreenchidos()
        {
            try
            {
                var clienteSelecionado = ClienteSelecionado;

                if (clienteSelecionado.nome.ValidaCampoEstaVazioOuNuloOuTamanhoInvalido(80, 2))
                    return clienteSelecionado.nome.CampoVazioOuNuloOuTamanhoInvalido("nome", 80, 2);

                if (clienteSelecionado.cpf.RetornaApenasNumeros().ValidaCampoEstaVazioOuNuloOuTamanhoInvalido(11, 11))
                    return clienteSelecionado.cpf.RemoverCaracterEspeciaisEhEspacoesEh().CampoVazioOuNuloOuTamanhoInvalido("cpf", 11, 11);

                if (clienteSelecionado.email.ValidaCampoEstaVazioOuNuloOuTamanhoInvalido(80, 2))
                    return clienteSelecionado.email.CampoVazioOuNuloOuTamanhoInvalido("email", 80, 2);

                if (clienteSelecionado.telefone.RemoverCaracterEspeciaisEhEspacoesEh().ValidaCampoEstaVazioOuNuloOuTamanhoInvalido(11, 8))
                    return clienteSelecionado.telefone.RemoverCaracterEspeciaisEhEspacoesEh().CampoVazioOuNuloOuTamanhoInvalido("telefone", 11, 8);

                if (clienteSelecionado.endereco.logradouro.ValidaCampoEstaVazioOuNuloOuTamanhoInvalido(80, 2))
                    return clienteSelecionado.endereco.logradouro.CampoVazioOuNuloOuTamanhoInvalido("Logradouro", 80, 2);

                if (clienteSelecionado.endereco.bairro.ValidaCampoEstaVazioOuNuloOuTamanhoInvalido(80, 2))
                    return clienteSelecionado.endereco.bairro.CampoVazioOuNuloOuTamanhoInvalido("Bairro", 80, 2);

                if (clienteSelecionado.endereco.numero.RemoverCaracterEspeciaisEhEspacoesEh().ValidaCampoEstaVazioOuNuloOuTamanhoInvalido(10, 1))
                    return clienteSelecionado.endereco.numero.RemoverCaracterEspeciaisEhEspacoesEh().CampoVazioOuNuloOuTamanhoInvalido("Numero", 10, 1);

                if (clienteSelecionado.endereco.cep.RemoverCaracterEspeciaisEhEspacoesEh().ValidaCampoEstaVazioOuNuloOuTamanhoInvalido(8, 8))
                    return clienteSelecionado.endereco.cep.RemoverCaracterEspeciaisEhEspacoesEh().CampoVazioOuNuloOuTamanhoInvalido("Cep", 8, 8);

                if (clienteSelecionado.endereco.cidade.ValidaCampoEstaVazioOuNuloOuTamanhoInvalido(80, 2))
                    return clienteSelecionado.endereco.cidade.CampoVazioOuNuloOuTamanhoInvalido("Cidade", 80, 2);

                if (clienteSelecionado.endereco.pais.ValidaCampoEstaVazioOuNuloOuTamanhoInvalido(80, 2))
                    return clienteSelecionado.endereco.pais.CampoVazioOuNuloOuTamanhoInvalido("Pais", 80, 2);

                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Preencha todos os campos";
            }
        }

        private void ArmazenarRegistro()
        {
            string resultado = ValidarCamposPreenchidos();

            if (resultado != string.Empty)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(resultado);

                DialogResult = DialogResult.None;

                return;
            }

            var result = Gravar(ClienteSelecionado);

            TelaPrincipalForm.Instancia.AtualizarRodape(Properties.Resources.ResourceManager.GetString("mensagemSucessoCadastro"));
        }

        private void ConfigurarTela()
        {
            panelAcoes.Controls.Add(AcoesUserControl);

            panelEndereco.Controls.Add(EnderecoUserControl);

            AcoesUserControl.btnSalvar.Click += (object? sender, EventArgs e) =>
            {
                ArmazenarRegistro();
            };

            new AjustarIdioma(this);

            Helpers.FocusTextBox(this);
        }
        #endregion
    }
}
