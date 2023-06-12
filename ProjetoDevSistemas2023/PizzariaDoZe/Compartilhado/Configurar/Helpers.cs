namespace PizzariaDoZe.Compartilhado.Configurar
{
    public class Helpers
    {
        /// <summary>
        /// Método responsável por setar um background color em campos TextBoxCase, ComboBox, RadioButton e Checkbox que estiverem em foco
        /// </summary>
        /// <param name="container"></param>
        public static void FocusTextBox(Control container)
        {
            foreach (Control c in container.Controls)
            {
                FocusTextBox(c);
                switch (c)
                {
                    case TextBoxBase:
                    case ComboBox:
                    case RadioButton:
                    case CheckBox:
                        //case ButtonBase:
                        //adiciona eventos ganhar e perder o foco
                        c.Enter += new EventHandler(CampoEventoEnter!);
                        c.Leave += new EventHandler(CampoEventoLeave!);
                        break;

                }
            }
        }

        #region métodos privados
        /// <summary>
        /// Altera a cor do BackGroud quando o campo ganha o foco
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">Evento que foi capturado</param>
        /// <example> textBoxUsuario.Enter += new System.EventHandler(ClassFuncoes.CampoEventoEnter); </example>
        private static void CampoEventoEnter(object sender, EventArgs e)
        {
            if (sender is TextBoxBase txt) //MaskedTextBox, TextBox
            {
                txt.BackColor = Color.LightCyan;
                txt.BorderStyle = BorderStyle.Fixed3D;
            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.LightCyan;
            }
            else if (sender is RadioButton rb)
            {
                rb.BackColor = Color.LightCyan;
            }
            else if (sender is ButtonBase btn)
            {
                btn.BackColor = Color.LightGreen;
            }
        }

        /// <summary>
        /// Alterar a cor do BackGroup quando o campo perde o foco
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">Evento que foi capturado</param>
        /// <example> textBoxUsuario.Leave += new System.EventHandler(ClassFuncoes.CampoEventoLeave); </example>
        private static void CampoEventoLeave(object sender, EventArgs e)
        {
            if (sender is TextBoxBase txt)
            {
                txt.BackColor = Color.White;
            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.White;
            }
            else if (sender is RadioButton rb)
            {
                rb.BackColor = SystemColors.ActiveBorder;
            }
            else if (sender is ButtonBase btn)
            {
                btn.BackColor = Color.Red;
            }
        }

        #endregion
    }
}
