using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Telas.Configuracoes.TelaIdioma
{
    public enum Idioma
    {
        [Description("pt-BR")]
        Portugues = 1,
        [Description("en")]
        Ingles = 2,
        [Description("es")]
        Espanhol = 3,
    }
}
