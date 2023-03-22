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
            panelAcoes.Controls.Add(AcoesUserControl);
            PreencherTela();
            Salvar();
            Cancelar();
        }
        private void Salvar()
        {
            AcoesUserControl.btnSalvar.Click += (object? sender, EventArgs e) =>
            {
                if (MessageBox.Show("Deseja realmente salvar as informações?", Text, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    DialogResult = DialogResult.None;
            };

        }
        private void Cancelar()
        {
            AcoesUserControl.btnCancelar.Click += (object? sender, EventArgs e) =>
            {
                if (MessageBox.Show("Deseja realmente cancelar?", Text, MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    DialogResult = DialogResult.None;
            };

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
