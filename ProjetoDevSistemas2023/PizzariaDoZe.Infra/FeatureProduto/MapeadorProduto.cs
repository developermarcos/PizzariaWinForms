using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Domain.FeatureProduto;
using PizzariaDoZe.Infra.Compartilhado;
using System.Data;
using System.Data.SqlClient;

namespace PizzariaDoZe.Infra.FeatureProduto
{
    internal class MapeadorProduto : MapeadorBase<Produto>
    {
        public override Produto ConverterRegistro(SqlDataReader leitorRegistro)
        {
            Produto registro = new Produto();

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("id_produto")))
            {
                int id_produto = leitorRegistro.GetInt32(leitorRegistro.GetOrdinal("id_produto"));
                registro.id_produto = id_produto;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("descricao_produto")))
            {
                string descricao_produto = leitorRegistro.GetString(leitorRegistro.GetOrdinal("descricao_produto"));
                registro.descricao_produto = descricao_produto;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("valor")))
            {
                decimal valor = leitorRegistro.GetDecimal(leitorRegistro.GetOrdinal("valor"));
                registro.valor = valor;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("tipo")))
            {
                TipoProduto tipo = Enum.Parse<TipoProduto>(leitorRegistro.GetString(leitorRegistro.GetOrdinal("tipo")));
                registro.tipo = tipo;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("medida_unitaria")))
            {
                string medida_unitaria = leitorRegistro.GetString(leitorRegistro.GetOrdinal("medida_unitaria"));
                registro.medida_unitaria = medida_unitaria;
            }

            return registro;
        }
    }
}
