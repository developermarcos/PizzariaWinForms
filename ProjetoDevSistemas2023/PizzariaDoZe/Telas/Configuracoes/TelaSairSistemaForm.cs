namespace PizzariaDoZe.Telas.Configuracoes
{
    public partial class TelaSairSistemaForm : Form
    {
        public TelaSairSistemaForm()
        {
            InitializeComponent();
            Text = Properties.Resources.ResourceManager.GetString("sairToolStripMenuItem.Text");
            btnSair.Text = Properties.Resources.ResourceManager.GetString("sairToolStripMenuItem.Text");
            btnCancelar.Text = Properties.Resources.ResourceManager.GetString("btnCancelar.Text");
            btnBandeja.Text = Properties.Resources.ResourceManager.GetString("btnBandeja.Text");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnBandeja_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}
