using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Configuracoes.TelaIdioma;
using PizzariaDoZe.TelaCliente;
using PizzariaDoZe.TelaIngrediente;
using PizzariaDoZe.TelaLogin;
using PizzariaDoZe.TelaProduto;
using PizzariaDoZe.TelaSabores;
using PizzariaDoZe.TelasCadastro.TelaCliente;
using PizzariaDoZe.TelasCadastro.TelaIngrediente;
using PizzariaDoZe.TelasCadastro.TelaProduto;
using PizzariaDoZe.TelasCadastro.TelaSabores;
using PizzariaDoZe.TelasCadastro.TelasFuncionario;
using PizzariaDoZe.TelasCadastro.TelaValor;
using PizzariaDoZe.TelasFuncionario;
using PizzariaDoZe.TelaValor;
using System.ComponentModel;

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
            //Logar();
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
            _controladores.Add(new Tuple<string, ControladorBase>(funcionariosToolStripMenuItem.Name, new ControladorFuncionario(this)));
            _controladores.Add(new Tuple<string, ControladorBase>(clientesToolStripMenuItem.Name, new ControladorCliente(this)));
            _controladores.Add(new Tuple<string, ControladorBase>(ingredientesToolStripMenuItem.Name, new ControladorIngrediente(this)));
            _controladores.Add(new Tuple<string, ControladorBase>(saboresToolStripMenuItem.Name, new ControladorSabores(this)));
            _controladores.Add(new Tuple<string, ControladorBase>(produtosToolStripMenuItem.Name, new ControladorProduto(this)));
            _controladores.Add(new Tuple<string, ControladorBase>(valoresToolStripMenuItem.Name, new ControladorValor(this)));
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controladorSelecionado = ObterControlador(funcionariosToolStripMenuItem.Name);

            ConfigurarTela();
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controladorSelecionado = ObterControlador(clientesToolStripMenuItem.Name);

            ConfigurarTela();
        }

        private void saboresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controladorSelecionado = ObterControlador(saboresToolStripMenuItem.Name);

            ConfigurarTela();
        }
        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controladorSelecionado = ObterControlador(ingredientesToolStripMenuItem.Name);

            ConfigurarTela();
        }
        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controladorSelecionado = ObterControlador(produtosToolStripMenuItem.Name);

            ConfigurarTela();
        }

        private void valoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controladorSelecionado = ObterControlador(valoresToolStripMenuItem.Name);

            ConfigurarTela();
        }
        private void idiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var controladorIdioma = new ControladorIdioma();

            controladorIdioma.IdiomaPanel(panelConteudo);
        }
        #endregion

        #region configuração tela inicial
        private ControladorBase ObterControlador(string controladorName)
        {
            return _controladores.FirstOrDefault(t => t.Item1 == controladorName).Item2;
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
            ComponentResourceManager resources = new(typeof(Properties.Resources));

            BtnInserir.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnFiltrar.Enabled = false;

            BtnInserir.Text = "";
            btnEditar.Text = "";
            btnExcluir.Text = "";
            btnFiltrar.Text = "";

            this.Text = Properties.Resources.ResourceManager.GetString("TelaPrincipalForm.Text");

            cadastrosToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("cadastrosToolStripMenuItem.Text");
            funcionariosToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("funcionariosToolStripMenuItem.Text");
            clientesToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("clientesToolStripMenuItem.Text");
            saboresToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("saboresToolStripMenuItem.Text");
            ingredientesToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("ingredientesToolStripMenuItem.Text");
            produtosToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("produtosToolStripMenuItem.Text");
            valoresToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("valoresToolStripMenuItem.Text");
            
            pedidosToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("pedidosToolStripMenuItem.Text");

            relatoriosToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("relatoriosToolStripMenuItem.Text");

            configuracoesToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("configuracoesToolStripMenuItem.Text");
            idiomasToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("idiomasToolStripMenuItem.Text");
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