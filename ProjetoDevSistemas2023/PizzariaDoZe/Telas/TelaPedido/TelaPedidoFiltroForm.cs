using PizzariaDoZe.Compartilhado.ExtensionMethods;
using PizzariaDoZe.Compartilhado.UserControlComponentes;
using PizzariaDoZe.Domain.FeaturePedido;
using PizzariaDoZe.Domain.FeatureSabor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace PizzariaDoZe.Telas.TelaPedido
{
    public partial class TelaPedidoFiltroForm : Form
    {
        public UserControlSalvarCancelar botoes = new UserControlSalvarCancelar();
        public TipoFiltro TipoSelecionado
        {
            get
            {
                return Enum.Parse<TipoFiltro>(filtro.Text);
            }
        }
        public TelaPedidoFiltroForm()
        {
            InitializeComponent();
            PreencherTela();
            panelAcoes.Controls.Add(botoes);
        }

        private void PreencherTela()
        {
            filtro.Items.Clear();
            filtro.PopularComboBoxComEnum<TipoFiltro>();

            filtro.SelectedIndex = 0;

            botoes.btnSalvar.Click += (object? sender, EventArgs e) =>
            {
            };

        }
    }
    public enum TipoFiltro
    {
        Todos = 1,
        ApenasSelecionado = 2,
    }
}
