using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.Compartilhado
{
    public partial class UserControlSalvarCancelar : UserControl
    {
        public UserControlSalvarCancelar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente salvar informações?", "Nome tela", MessageBoxButtons.OKCancel) == DialogResult.None)
            {
                e. = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja cancelar alterações?", "Nome tela", MessageBoxButtons.OKCancel);
        }
    }
}
