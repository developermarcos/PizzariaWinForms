using PizzariaDoZe.Configuracoes.TelaIdioma;

namespace PizzariaDoZe.Telas.Configuracoes.TelaIdioma
{
    internal class ControladorIdioma
    {
        private UserControlIdioma Idioma = new UserControlIdioma();
        /// <summary>
        /// Método responsável por gerar um panel com opções de idioma para a aplicação
        /// </summary>
        /// <param name="panelTelaPrincipal">Adicional as opções de idioma a tela principal</param>
        /// <param name="telaPrincipalForm">Parametro necessário para atualizar o idioma da tela principal</param>
        public void IdiomaPanel(Panel panelTelaPrincipal, TelaPrincipalForm telaPrincipalForm)
        {
            Idioma.TelaPrincipal = telaPrincipalForm;

            panelTelaPrincipal.Controls.Add(Idioma);
        }
    }
}
