using PizzariaDoZe.Domain.FeatureSabor;
using PizzariaDoZe.Domain.FeatureValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Domain.FeaturePedido
{
    public class Pizza
    {
        public int Id { get; set; }
        public TipoBorda TipoBorda { get; set; }
        public TamanhoPizza TamanhoPizza { get; set; }
        public decimal Valor { get; set; }

        public int PedidoId { get; set; }
        public List<Sabor> sabores { get; set; }

        public void CalcularValor(List<Valor> valores)
        {
            Valor valor = valores.Find(x => x.tamanho == TamanhoPizza);

            if (sabores.Exists(x => x.categoria == CategoriaSabor.Especial))
                Valor = valor.especial;

            Valor = valor.tradicional;
        }

        public override string ToString()
        {
            return $"{TamanhoPizza} ({string.Concat(sabores.Select(x => string.Concat(x.nome, " ")))}) {TipoBorda}";
        }
    }
    public enum TipoBorda
    {
        Nenhuma = 1,
        Salgada = 2,
        Doce = 3,
    }
}
