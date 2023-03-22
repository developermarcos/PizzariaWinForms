using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Compartilhado.ExtensionMethods;
using PizzariaDoZe.TelaCliente;
using PizzariaDoZe.TelaIngrediente;
using PizzariaDoZe.TelaLogin;
using PizzariaDoZe.TelaSabores;
using PizzariaDoZe.TelasFuncionario;
using System.Numerics;

namespace PizzariaDoZe
{
    public partial class TelaPrincipalForm : Form
    {
        private List<Tuple<string, ControladorBase>> _controladores = new List<Tuple<string, ControladorBase>>();
        private ControladorBase _controladorSelecionado;
        private TelaLoginForm _telaLogin = new TelaLoginForm();

        public TelaPrincipalForm()
        {
            InitializeComponent();
            CarregarControladores();
            ConfigurarTelaInicial();
            Logar();
        }

        private void Logar()
        {
            do
            {
                _telaLogin.ShowDialog();
            } while (!_telaLogin.UsuarioLogado);
        }



        #region menu seleção
        private void CarregarControladores()
        {
            _controladores.Add(new Tuple<string, ControladorBase>("funcionarios", new ControladorFuncionario(this)));
            _controladores.Add(new Tuple<string, ControladorBase>("clientes", new ControladorCliente(this)));
            _controladores.Add(new Tuple<string, ControladorBase>("ingredientes", new ControladorIngrediente(this)));
            _controladores.Add(new Tuple<string, ControladorBase>("sabores", new ControladorSabores(this)));
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controladorSelecionado = ObterControlador(funcionáriosToolStripMenuItem.Text);

            ConfigurarTela();
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controladorSelecionado = ObterControlador(clientesToolStripMenuItem.Text);

            ConfigurarTela();
        }

        private void saboresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controladorSelecionado = ObterControlador(saboresToolStripMenuItem.Text);

            ConfigurarTela();
        }
        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controladorSelecionado = ObterControlador(ingredientesToolStripMenuItem.Text);

            ConfigurarTela();
        }
        #endregion

        #region configuração tela inicial
        private ControladorBase ObterControlador(string controladorName)
        {
            return _controladores.FirstOrDefault(t => t.Item1 == controladorName.RemoverCaracterEspeciaisEhEspacoesEh()).Item2;
        }

        public void AtualizarListagem()
        {
            //
        }
        public void AtualizarRodape(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return;

            lbRodape.Text = texto;
        }

        private void ConfigurarTela()
        {
            if (_controladorSelecionado != null)
            {
                ConfigurarToolTips();
                _controladorSelecionado.Listar();
            }
        }
        private void ConfigurarTelaInicial()
        {
            BtnInserir.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnFiltrar.Enabled = false;

            BtnInserir.Text = "";
            btnEditar.Text = "";
            btnExcluir.Text = "";
            btnFiltrar.Text = "";
        }
        private void ConfigurarToolTips()
        {
            var toolStrip = _controladorSelecionado.ToolTripConfiguracao;

            BtnInserir.Text = toolStrip.InserirText;
            btnEditar.Text = toolStrip.EditarText;
            btnExcluir.Text = toolStrip.ExcluirText;
            btnFiltrar.Text = toolStrip.FiltrarText;

            BtnInserir.Enabled = toolStrip.habilitarInserir;
            btnEditar.Enabled = toolStrip.habilitarEditar;
            btnExcluir.Enabled = toolStrip.habilitarExcluir;
            btnFiltrar.Enabled = toolStrip.habilitarFiltrar;
        }
        #endregion

        #region ações toolstrip
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            _controladorSelecionado.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _controladorSelecionado.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _controladorSelecionado.Excluir();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (_controladorSelecionado is ITelaTipoFiltrarDados)
            {
                var telaFiltro = (ITelaTipoFiltrarDados)_controladorSelecionado;
                telaFiltro.Filtrar();
            }
        }
        #endregion
    }
}