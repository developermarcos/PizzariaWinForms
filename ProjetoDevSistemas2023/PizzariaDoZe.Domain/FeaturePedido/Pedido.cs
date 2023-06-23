using PizzariaDoZe.Domain.FeatureCliente;
using PizzariaDoZe.Domain.FeatureFuncionario;
using PizzariaDoZe.Domain.FeatureProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Domain.FeaturePedido
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime dataPedido { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public List<Produto> Produtos { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int FuncionarioId { get; set; }
        public bool excluido { get; set; }
        public Funcionario Funcionario { get; set; }
        public decimal ValorTotal { 
            get
            {
                if (PizzasVazia() && ProdutosVazia())
                    return 0;

                if (!PizzasVazia() && ProdutosVazia())
                    return Pizzas.Sum(x => x.Valor);

                if (PizzasVazia() && !ProdutosVazia())
                    return Produtos.Sum(x => x.valor);

                return Pizzas.Sum(x => x.Valor) + Produtos.Sum(x => x.valor);
            }
        }

        
        private bool PizzasVazia()
        {
            return (Pizzas == null || Pizzas?.Count == 0);
        }
        private bool ProdutosVazia()
        {
            return (Produtos == null || Produtos?.Count == 0);
        }
    }
}
