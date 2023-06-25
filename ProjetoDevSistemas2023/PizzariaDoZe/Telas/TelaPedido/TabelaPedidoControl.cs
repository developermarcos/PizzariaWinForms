﻿using PizzariaDoZe.Compartilhado.ExtensionMethods;
using PizzariaDoZe.Domain.FeatureCliente;
using PizzariaDoZe.Domain.FeaturePedido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.Telas.TelaPedido
{
    public partial class TabelaPedidoControl : UserControl
    {
        public TabelaPedidoControl()
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
                new DataGridViewTextBoxColumn { DataPropertyName = "id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Cliente"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Funcionario", HeaderText = "Funcionario"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ValorTotal", HeaderText = "Valor Total"},
            };

            return colunas;
        }

        public int ObtemNumeroContatoSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Pedido> clientes)
        {
            grid.DataSource = clientes;
        }
    }
}