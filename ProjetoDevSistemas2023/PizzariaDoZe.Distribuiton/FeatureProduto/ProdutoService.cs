using PizzariaDoZe.Domain.FeatureProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Distribuiton.FeatureProduto
{
    public class ProdutoService
    {
        private IRepositorioProduto repositorioProduto;

        public ProdutoService(IRepositorioProduto repositorioProduto)
        {
            this.repositorioProduto = repositorioProduto;
        }
    }
}
