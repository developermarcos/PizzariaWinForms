using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.TelaProduto
{
    public partial class TelaCadastroProdutoForm : Form
    {
        public TelaCadastroProdutoForm(string nomeTela)
        {
            InitializeComponent();
            Text = nomeTela;
        }
    }
}
