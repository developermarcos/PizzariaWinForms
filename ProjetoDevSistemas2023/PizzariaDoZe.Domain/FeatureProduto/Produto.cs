using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Domain.FeatureProduto
{
    public class Produto
    {
        public int id_produto {  get; set; }
        public string descricao_produto {  get; set; }
        public decimal valor {  get; set; }
        public TipoProduto tipo {  get; set; }
        public string medida_unitaria {  get; set; }
    }
    public enum TipoProduto
    {

    }
}
