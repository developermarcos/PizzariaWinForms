using FluentResults;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Compartilhado.UserControlComponentes;
using PizzariaDoZe.Domain.Compartilhado;
using PizzariaDoZe.Domain.Compartilhado.ExtensionMethods;
using PizzariaDoZe.Domain.FeatureFuncionario;

namespace PizzariaDoZe.TelasFuncionario
{
    public partial class TelaCadastroFuncionarioForm : Form
    {
        private UserControlSalvarCancelar AcoesUserControl = new UserControlSalvarCancelar();
        private UserControlEndereco EnderecoUserControl = new UserControlEndereco();
        private Funcionario funcionario;
        public TelaCadastroFuncionarioForm(string nomeTela, string mensagemDejesaSalvar, string mensagemDesejaCancelar)
        {
            InitializeComponent();
            Text = nomeTela;
            ConfigurarTela();
        }
        public Func<Funcionario, Result<Funcionario>> Gravar { get; internal set; }
        public Funcionario FuncionarioSelecionado
        {
            private get
            {
                return new Funcionario()
                {
                    id = string.IsNullOrEmpty(id.Text) ? 0 : Convert.ToInt32(id.Text),
                    nome = nomeCompleto.Text,
                    cpf = cpf.Text.RetornaApenasNumeros(),
                    email = email.Text,
                    telefone = telefone.Text.RemoverCaracterEspeciaisEhEspacoesEh(),
                    matricula = matricula.Text,
                    senha = senha.Text,
                    grupo = Enum.Parse<GrupoFuncionario>(grupoFuncionario.Text),
                    possuiHabilitacao = PossuiHabilitacao(),
                    cnh = cnh.Text,
                    validade_motorista = DateTime.Parse(dataVencimentoHabilitacao.Text),
                    observacao = observacoes.Text,
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
                funcionario = value;
                PopularTela();
            }
        }

        #region métodos auxiliares
        private void PopularTela()
        {
            id.Text = funcionario.id.ToString();
            nomeCompleto.Text = funcionario.nome;
            cpf.Text = funcionario.cpf;
            email.Text = funcionario.email;
            telefone.Text = funcionario.telefone;

            matricula.Text = funcionario.matricula;
            senha.Text = funcionario.senha;
            grupoFuncionario.Text = funcionario.grupo.GetDescription();
            sim.Checked = funcionario.possuiHabilitacao;
            nao.Checked = !funcionario.possuiHabilitacao;
            cnh.Text = funcionario.cnh;
            dataVencimentoHabilitacao.Text = funcionario.validade_motorista.ToString();
            observacoes.Text = funcionario.observacao;
            EnderecoUserControl.Logradouro = funcionario.endereco.logradouro;
            EnderecoUserControl.Bairro = funcionario.endereco.bairro;
            EnderecoUserControl.Numero = funcionario.endereco.numero;
            EnderecoUserControl.Cep = funcionario.endereco.cep;
            EnderecoUserControl.Cidade = funcionario.endereco.cidade;
            EnderecoUserControl.Pais = funcionario.endereco.pais;
            EnderecoUserControl.Complemento = funcionario.endereco.complemento;

        }
        private bool PossuiHabilitacao()
        {
            return grupoHabilitacao.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked).Text.ToLower() == "sim";
        }
        private string ValidarCamposPreenchidos()
        {
            return string.Empty;
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

            var result = Gravar(FuncionarioSelecionado);

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

            Array values = Enum.GetValues(typeof(GrupoFuncionario));

            grupoFuncionario.Items.Clear();
            foreach (var i in values)
            {
                grupoFuncionario.Items.Add(i.ToString());
            }
        }
        #endregion
    }
}
