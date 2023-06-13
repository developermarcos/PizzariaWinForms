using PizzariaDoZe.Domain.FeatureProduto;
using PizzariaDoZe.Infra.Compartilhado.Mapeador;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection;

namespace PizzariaDoZe.Infra.FeatureProduto
{
    internal class MapeadorProduto : MapeadorBase<Produto>
    {
        public override Produto ConverterRegistro(SqlDataReader leitorRegistro)
        {
            Produto registro = new Produto();

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("id")))
            {
                int id = leitorRegistro.GetInt32(leitorRegistro.GetOrdinal("id"));
                registro.id = id;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("nome")))
            {
                string nome = leitorRegistro.GetString(leitorRegistro.GetOrdinal("nome"));
                registro.nome = nome;
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
        public override void ConfigurarParametros(Produto registro, DbCommand comando)
        {

            Type tipo = registro.GetType();
            PropertyInfo[] propriedades = tipo.GetProperties();

            foreach (PropertyInfo propriedade in propriedades)
            {
                AdicionarParameter(propriedade.GetValue(registro), propriedade.Name, comando);
            }
        }
    }
}
