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

namespace PizzariaDoZe.TelaSabores
{
    public partial class TelaCadastroSaboresForm : Form
    {
        private UserControlSalvarCancelar AcoesUserControl = new UserControlSalvarCancelar();
        public TelaCadastroSaboresForm(string telaNome)
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

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            if (selecionarImagem.ShowDialog() == DialogResult.OK)
            {
                Image Imagem = Image.FromFile(selecionarImagem.FileName);
                imagemPK.SizeMode = PictureBoxSizeMode.StretchImage;
                imagemPK.Height = 197;
                imagemPK.Width = 229;
                imagemPK.Image = Imagem;
            }
        }
    }
}
