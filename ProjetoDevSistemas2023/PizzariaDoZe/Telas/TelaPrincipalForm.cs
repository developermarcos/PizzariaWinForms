using Microsoft.Extensions.DependencyInjection;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.TelaLogin;
using PizzariaDoZe.Telas.Cadastros.TelaCliente;
using PizzariaDoZe.Telas.Cadastros.TelaIngrediente;
using PizzariaDoZe.Telas.Cadastros.TelaProduto;
using PizzariaDoZe.Telas.Cadastros.TelaSabores;
using PizzariaDoZe.Telas.Cadastros.TelasFuncionario;
using PizzariaDoZe.Telas.Cadastros.TelaValor;
using PizzariaDoZe.Telas.Configuracoes;
using PizzariaDoZe.Telas.Configuracoes.TelaIdioma;
using System.ComponentModel;

namespace PizzariaDoZe
{
    public partial class TelaPrincipalForm : Form
    {
        private TelaLoginForm _telaLogin = new TelaLoginForm();
        private Dependencias _dependencias;
        private ControladorBase _controladorSelecionado;

        public TelaPrincipalForm(Dependencias Dependencias)
        {
            _dependencias = Dependencias;

            InitializeComponent();
            ConfigurarTelaInicial();

            Instancia = this;
        }
        /// <summary>
        /// Método responsável por atualizar informações da tela principal como idioma e configurações de nome de menus e botões
        /// </summary>
        /// 

        public static TelaPrincipalForm Instancia
        {
            get;
            private set;
        }

        public void AtualizarTelaPrincipal()
        {
            this.Refresh();

            ConfigurarTelaInicial();
        }
        /// <summary>
        /// Método responsável por atualizar o conteúdo da feature em seleção
        /// </summary>
        /// <param name="conteudo">Recebe um control com dados da feature em seleção</param>
        public void AtualizarListagem(UserControl conteudo)
        {
            panelConteudo.Controls.Clear();

            panelConteudo.Controls.Add(conteudo);
        }
        /// <summary>
        /// Método responsável por mostrar mensagens de informação ao usuário
        /// </summary>
        /// <param name="texto"></param>
        public void AtualizarRodape(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return;

            lbRodape.Text = texto;
        }


        #region menu seleção
        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTela(_dependencias.Get<ControladorFuncionario>());
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTela(_dependencias.Get<ControladorCliente>());
        }

        private void saboresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTela(_dependencias.Get<ControladorSabor>());
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTela(_dependencias.Get<ControladorIngrediente>());
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTela(_dependencias.Get<ControladorProduto>());
        }

        private void valoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTela(_dependencias.Get<ControladorValor>());
        }

        private void idiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var controladorIdioma = new ControladorIdioma();

            AtualizarListagem(controladorIdioma.IdiomaPanel());

            InabilitarBotoesAcoes();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (new TelaSairSistemaForm().ShowDialog())
            {
                case DialogResult.OK:
                    this.Close();
                    break;
                case DialogResult.Abort:
                    this.Hide();
                    notifyBandeja.Visible = true;
                    notifyBandeja.ShowBalloonTip(200);
                    break;
            }
        }
        #endregion

        #region configuração tela inicial
        private void ConfigurarTela(ControladorBase controlador)
        {
            _controladorSelecionado = controlador;

            ConfigurarToolTips(controlador);

            AtualizarListagem(controlador.ObtemListagem());

        }
        private void ConfigurarTelaInicial()
        {
            InabilitarBotoesAcoes();

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

            sairToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("sairToolStripMenuItem.Text");
            abrirToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("abrirToolStripMenuItem.Text");
            encerarToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("encerarToolStripMenuItem.Text");
            sobreToolStripMenuItem.Text = Properties.Resources.ResourceManager.GetString("sobreToolStripMenuItem.Text");
        }

        private void InabilitarBotoesAcoes()
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

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            var toolStrip = controlador.ToolTripConfiguracao;

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

        #region Ações menu contexto bandeja
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyBandeja.Visible = false;
        }

        private void encerarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            notifyBandeja.Visible = false;
        }
        private void notifyBandeja_DoubleClick(object sender, EventArgs e)
        {
            Show();
            notifyBandeja.Visible = false;
        }
        #endregion

    }
}