using PizzariaDoZe.Compartilhado.UserControlComponentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Configuracoes.TelaIdioma
{
    internal class ControladorIdioma
    {
        private UserControlIdioma Idioma = new UserControlIdioma();
        
        public  void IdiomaPanel(Panel panelTelaPrincipal, TelaPrincipalForm telaPrincipalForm)
        {
            Idioma.TelaPrincipal = telaPrincipalForm;

            panelTelaPrincipal.Controls.Add(Idioma);
        }
    }
}
