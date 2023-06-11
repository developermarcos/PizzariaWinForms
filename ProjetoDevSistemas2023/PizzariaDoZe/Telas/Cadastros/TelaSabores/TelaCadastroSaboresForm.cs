using FluentResults;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Compartilhado.UserControlComponentes;
using PizzariaDoZe.Distribuiton.FeatureSabor;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Domain.FeatureProduto;
using PizzariaDoZe.Domain.FeatureSabor;
using PizzariaDoZe.Domain.FeatureValor;
using System;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PizzariaDoZe.TelaSabores
{
    public partial class TelaCadastroFuncionarioForm : Form
    {
        private UserControlSalvarCancelar AcoesUserControl = new UserControlSalvarCancelar();

        public Sabor _saborSelecionado;

        public List<Ingrediente> Ingredientes { get; set; }

        public Func<Sabor, Result<Sabor>> Gravar { get; internal set; }

        public Sabor SaborSelecionado
        {
            get {

                Sabor sabor = new Sabor()
                {
                    tipo = Enum.Parse<TipoSabor>(tipo.Text),
                    categoria = Enum.Parse<CategoriaSabor>(categorias.Text),
                    nome = nome.Text
                };

                if (imagemPK.Image != null)
                    sabor.foto = ImagemToByte(imagemPK.Image);


                if (!string.IsNullOrEmpty(id.Text))
                    sabor.id = Convert.ToInt32(id.Text);

                sabor.ingredientes.Clear();

                var contador = ingredientes.Items.Count;
                for (int i = 0; i < contador; i++)
                {
                    if (ingredientes.GetItemCheckState(i) == CheckState.Checked)
                    {
                        sabor.ingredientes.Add((Ingrediente)ingredientes.Items[i]);
                    }
                }
                
                return sabor; 
            }
            set
            {
                _saborSelecionado = value;
                PreencherTela();
            }
        }

        public TelaCadastroFuncionarioForm(string nomeTela, List<Ingrediente> ingredientes)
        {
            InitializeComponent();
            Text = nomeTela;
            Ingredientes = ingredientes;
            ConfigurarTela();
        }

        private void ConfigurarTela()
        {
            panelAcoes.Controls.Add(AcoesUserControl);

            AcoesUserControl.btnSalvar.Click += (object? sender, EventArgs e) =>
            {
                var validarResult = ValidarCampos();

                if(validarResult != string.Empty)
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape(validarResult);
                    DialogResult = DialogResult.None;
                    return;
                }

                var gravarResult = Gravar(SaborSelecionado);

                TelaPrincipalForm.Instancia.AtualizarRodape(Properties.Resources.ResourceManager.GetString("mensagemSucessoCadastro"));
            };

            new AjustarIdioma(this);

            Helpers.FocusTextBox(this);

            ingredientes.Items.Clear();

            ingredientes.Items.AddRange(Ingredientes.ToArray());
            
            PreencherEnum(Enum.GetValues(typeof(TipoSabor)), tipo);

            PreencherEnum(Enum.GetValues(typeof(CategoriaSabor)), categorias);
        }

        #region métodos auxiliares
        private void PreencherEnum(Array valores, ComboBox comboBox)
        {
            comboBox.Items.Clear();

            comboBox.Items.Clear();
            foreach (var i in valores)
            {
                comboBox.Items.Add(i.ToString());
            }
        }
        private string ValidarCampos()
        {
            var sabor = SaborSelecionado;

            if (sabor.tipo == 0)
                return "Tipo invalido";
            
            if(sabor.categoria == 0)
                return "categoria invalido";

            if (string.IsNullOrEmpty(sabor.nome))
                return "Nome não informado invalido";

            if (sabor.ingredientes.Count == 0)
                return "Nenhum ingrediente selecionado";

            return string.Empty;
        }
        private void PreencherTela()
        {
            id.Text = _saborSelecionado.id.ToString();
            nome.Text = _saborSelecionado.nome;
            categorias.SelectedItem = _saborSelecionado.categoria.ToString();
            tipo.SelectedItem = _saborSelecionado.tipo.ToString();

            var tamanhoArray = ingredientes.Items.Count;

            for (int i = 0; i < tamanhoArray; i++)
            {
                var ingredienteTeste = (Ingrediente)ingredientes.Items[i];
                if (_saborSelecionado.ingredientes.Exists(x => x.Igual(ingredienteTeste)))
                {
                    ingredientes.SetItemChecked(i, true);
                }
                    
            }

            imagemPK.Image = ByteToImage(_saborSelecionado.foto);
            imagemPK.SizeMode = PictureBoxSizeMode.StretchImage;
            imagemPK.Height = 197;
            imagemPK.Width = 229;
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

        private byte[] ImagemToByte(Image imagem)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                imagem.Save(mStream, imagem.RawFormat);
                return mStream.ToArray();
            }
        }
        private Image ByteToImage(byte[] bityImage)
        {
            using (var ms = new MemoryStream(bityImage))
            {
                return Image.FromStream(ms);
            }
        }
        #endregion
    }
}
