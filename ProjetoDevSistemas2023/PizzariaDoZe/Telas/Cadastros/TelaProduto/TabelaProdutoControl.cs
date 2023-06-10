﻿using PizzariaDoZe.Compartilhado.ExtensionMethods;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Domain.FeatureProduto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.Telas.Cadastros.TelaProduto
{
    public partial class TabelaProdutoControl : UserControl
    {
        public TabelaProdutoControl()
        {
            InitializeComponent();

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
            grid.Columns.AddRange(ObterColunas());
            this.Dock = DockStyle.Fill;
        }
        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "id_produto", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "descricao_produto", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "valor", HeaderText = "Valor"},

                new DataGridViewTextBoxColumn { DataPropertyName = "tipo", HeaderText = "Tipo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "medida_unitaria", HeaderText = "Medida Unitária"},
            };

            return colunas;
        }

        public int ObtemNumeroContatoSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Produto> produtos)
        {
            grid.DataSource = produtos;
        }
    }
}