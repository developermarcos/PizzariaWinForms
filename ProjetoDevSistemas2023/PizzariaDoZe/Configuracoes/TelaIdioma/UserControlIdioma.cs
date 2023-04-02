using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.Compartilhado.UserControlComponentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.Configuracoes.TelaIdioma
{
    public partial class UserControlIdioma : UserControl
    {
        private List<Tuple<string, string>> idiomas;
        public UserControlIdioma()
        {
            InitializeComponent();

            idiomas = new List<Tuple<string, string>>()
            {
                new Tuple<string, string>("portugues", "pt-br"),
                new Tuple<string, string>("ingles", "en-US"),
                new Tuple<string, string>("espanhol", "es")
            };

            Configurar();
        }
        private void Configurar()
        {
            new AjustarIdioma(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string auxIdiomaRegiao = "en-US"; // en-US, es, pt-BR, etc
                                              //ajusta o idioma/região
            foreach (var item in selecionarIdioma.Controls)
            {
                var btn = (RadioButton)item;
                if (btn.Checked) auxIdiomaRegiao = idiomas.FirstOrDefault(x => x.Item1 == btn.Name).Item2;
            }

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao);
        }
    }
}
