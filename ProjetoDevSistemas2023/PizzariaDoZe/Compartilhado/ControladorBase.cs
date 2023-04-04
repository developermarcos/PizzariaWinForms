using PizzariaDoZe.Compartilhado.Configurar;

namespace PizzariaDoZe.Compartilhado
{
    public abstract class ControladorBase
    {
        protected string _inserir { get { return Properties.Resources.ResourceManager.GetString("btnInserir.Text"); } }
        protected string _editar { get { return Properties.Resources.ResourceManager.GetString("btnEditar.Text"); } }
        protected string _excluir { get { return Properties.Resources.ResourceManager.GetString("btnExcluir.Text"); } }
        protected string _listando { get { return Properties.Resources.ResourceManager.GetString("Listando"); } }
        protected string _novo { get { return Properties.Resources.ResourceManager.GetString("Novo"); } }

        protected string _mensagemDesejaSalvar { get { return Properties.Resources.ResourceManager.GetString("MensagemDesejaSalvar"); } }
        protected string _mensagemDesejaCancelar { get { return Properties.Resources.ResourceManager.GetString("MensagemDesejaCancelar"); } }
        protected string _mensagemRegistroInserido { get { return Properties.Resources.ResourceManager.GetString("MensagemInseridoSucesso"); } }
        protected string _mensagemRegistroEditado { get { return Properties.Resources.ResourceManager.GetString("MensagemEditadoSucesso"); } }
        protected string _mensagemRegistroExcluido { get { return Properties.Resources.ResourceManager.GetString("MensagemExcluidoSucesso"); } }
        protected string _mensagemRegistroNaoInserido { get { return Properties.Resources.ResourceManager.GetString("MensagemNenhumItemInserido"); } }
        protected string _mensagemRegistroNaoEditado { get { return Properties.Resources.ResourceManager.GetString("MensagemNenhumItemEditado"); } }
        protected string _mensagemRegistroNaoExcluido { get { return Properties.Resources.ResourceManager.GetString("MensagemNenhumItemExcluido"); } }
        protected string _mensagemConfirmacaoExclusao { get { return Properties.Resources.ResourceManager.GetString("MensagemConfirmacaoExclusao"); } }



        protected abstract string _featureSingular { get; }
        protected abstract string _featurePlural { get; }

        protected TelaPrincipalForm TelaPrincipalForm { get; set; }
        public ControladorBase(TelaPrincipalForm telaPrincipalForm)
        {
            TelaPrincipalForm = telaPrincipalForm;
        }
        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Excluir();
        public abstract void Listar(TelaPrincipalForm telaPrincipalForm);
        public abstract ToolStripBase ToolTripConfiguracao { get; }
    }
}
