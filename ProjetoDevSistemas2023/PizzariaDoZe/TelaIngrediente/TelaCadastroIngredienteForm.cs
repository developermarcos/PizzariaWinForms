using PizzariaDoZe.Compartilhado.UserControlComponentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.TelaIngrediente
{
    public partial class TelaCadastroIngredienteForm : Form
    {
        private UserControlSalvarCancelar AcoesUserControl = new UserControlSalvarCancelar();
        public TelaCadastroIngredienteForm(string telaNome)
        {
            InitializeComponent();
            Text = telaNome;
            AcoesUserControl.NomeTelaConfirmacao = telaNome;
            panelAcoes.Controls.Add(AcoesUserControl);
            PreencherTela();
        }

        private void PreencherTela()
        {
            lbId.Text = "ID: --";
        }
    }
}
