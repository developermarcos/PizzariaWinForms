﻿using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Compartilhado.ExtensionMethods;
using PizzariaDoZe.Telas.Configuracoes.TelaIdioma;

namespace PizzariaDoZe.Configuracoes.TelaIdioma
{
    public partial class UserControlIdioma : UserControl
    {
        private List<Tuple<string, Idioma>> idiomas;

        public UserControlIdioma()
        {
            InitializeComponent();

            idiomas = new List<Tuple<string, Idioma>>()
            {
                new Tuple<string, Idioma>("portugues", Idioma.Portugues),
                new Tuple<string, Idioma>("ingles", Idioma.Ingles),
                new Tuple<string, Idioma>("espanhol", Idioma.Espanhol)
            };

            Configurar();
        }
        private void Configurar()
        {
            new AjustarIdioma(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            foreach (var item in selecionarIdioma.Controls)
            {
                var btn = (RadioButton)item;
                if (btn.Checked) ProgramExtensions.AtualizarIdiomaAplicacao(idiomas.FirstOrDefault(x => x.Item1 == btn.Name).Item2);
            }


            TelaPrincipalForm.Instancia.AtualizarTelaPrincipal();

            Configurar();

            TelaPrincipalForm.Instancia.AtualizarRodape(Properties.Resources.ResourceManager.GetString("MensagemIdiomaAtualizado"));
        }
    }
}
