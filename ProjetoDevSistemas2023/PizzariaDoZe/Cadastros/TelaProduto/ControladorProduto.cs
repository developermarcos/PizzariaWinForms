﻿using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Compartilhado.Configurar;
using PizzariaDoZe.TelaProduto;

namespace PizzariaDoZe.TelasCadastro.TelaProduto
{
    internal class ControladorProduto : ControladorBase, ITelaTipoFiltrarDados
    {
        public override ToolStripProduto ToolTripConfiguracao => new ToolStripProduto();
        protected override string _featureSingular => Properties.Resources.ResourceManager.GetString("FeatureProduto");
        protected override string _featurePlural => Properties.Resources.ResourceManager.GetString("produtosToolStripMenuItem.Text");

        public ControladorProduto(TelaPrincipalForm telaPrincipalForm) : base(telaPrincipalForm)
        {

        }

        public override void Inserir()
        {
            TelaCadastroProdutoForm telaCadastroIngrediente =
                new TelaCadastroProdutoForm($"{_inserir} {_novo} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            if (telaCadastroIngrediente.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape($"{_mensagemRegistroNaoInserido}");
                return;
            }

            TelaPrincipalForm.AtualizarRodape($"{_mensagemRegistroInserido}");

        }
        public override void Editar()
        {
            TelaCadastroProdutoForm telaCadastroProduto = new TelaCadastroProdutoForm($"{_editar} {_featureSingular}", _mensagemDesejaSalvar, _mensagemDesejaCancelar);

            if (telaCadastroProduto.ShowDialog() == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape($"{_mensagemRegistroNaoEditado}");
                return;
            }
            TelaPrincipalForm.AtualizarRodape($"{_mensagemRegistroEditado}");
        }

        public override void Excluir()
        {
            if (MessageBox.Show($"{_mensagemConfirmacaoExclusao}", $"{_excluir} {_featureSingular}", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                TelaPrincipalForm.AtualizarRodape($"{_mensagemRegistroNaoExcluido}");
                return;
            }
            TelaPrincipalForm.AtualizarRodape($"{_mensagemRegistroExcluido}");
        }

        public override void Listar(TelaPrincipalForm telaPrincipalForm)
        {
            telaPrincipalForm.AtualizarListagem(new Control());
            TelaPrincipalForm.AtualizarRodape($"{_listando} 0 {_featurePlural}");
        }

        public void Filtrar()
        {
            TelaPrincipalForm.AtualizarRodape("Nenhum filtro desponível no momento");
        }
    }
}
