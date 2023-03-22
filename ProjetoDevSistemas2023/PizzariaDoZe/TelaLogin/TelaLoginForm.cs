using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.TelaLogin
{
    public partial class TelaLoginForm : Form
    {
        public string Usuario { get { return usuario.Text.Trim(); } }
        public string Senha { get { return senha.Text.Trim(); } }
        public bool _usuarioLogado { get; set; }
        public bool UsuarioLogado { get { return _usuarioLogado; } }
        public TelaLoginForm()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Usuario) || string.IsNullOrEmpty(Senha))
            {
                MessageBox.Show("Preencha todos os campos", "Login", MessageBoxButtons.OK);
                return;
            }
            string logar = "marcos";
            if (Usuario != logar || Senha != logar)
            {
                MessageBox.Show("Usuario ou senha incorreta", "Login", MessageBoxButtons.OK);
                return;
            }

            _usuarioLogado = true;
        }
    }
}
