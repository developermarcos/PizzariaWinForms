using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.Compartilhado.UserControlComponentes
{
    public partial class UserControlSalvarCancelar : UserControl
    {
        private string _nomeTelaConfirmacao { get; set; }
        public UserControlSalvarCancelar()
        {
            InitializeComponent();
        }
        public string NomeTelaConfirmacao
        {
            set
            {
                _nomeTelaConfirmacao= value;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente salvar informações?", _nomeTelaConfirmacao, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja cancelar alterações?", _nomeTelaConfirmacao, MessageBoxButtons.OKCancel);
        }
    }
}
