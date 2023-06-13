using PizzariaDoZe.Domain.FeatureSabor;
using PizzariaDoZe.Domain.FeatureValor;
using PizzariaDoZe.Infra.Compartilhado.Mapeador;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection;

namespace PizzariaDoZe.Infra.FeatureValor
{
    public class MapeadorValor : MapeadorBase<Valor>
    {
        public override Valor ConverterRegistro(SqlDataReader leitorRegistro)
        {
            Valor registro = new Valor();

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("id")))
            {
                int id_sabor = leitorRegistro.GetInt32(leitorRegistro.GetOrdinal("id"));
                registro.id = id_sabor;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("tamanho")))
            {
                string tamanho = leitorRegistro.GetString(leitorRegistro.GetOrdinal("tamanho"));
                registro.tamanho = Enum.Parse<TamanhoPizza>(tamanho);
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("tradicional")))
            {
                decimal tradicional = leitorRegistro.GetDecimal(leitorRegistro.GetOrdinal("tradicional"));
                registro.tradicional = Convert.ToDecimal(tradicional);
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("bordaTradicional")))
            {
                decimal bordaTradicional = leitorRegistro.GetDecimal(leitorRegistro.GetOrdinal("bordaTradicional"));
                registro.bordaTradicional = Convert.ToDecimal(bordaTradicional);
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("especial")))
            {
                decimal especial = leitorRegistro.GetDecimal(leitorRegistro.GetOrdinal("especial"));
                registro.especial = Convert.ToDecimal(especial);
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("bordaEspecial")))
            {
                decimal bordaEspecial = leitorRegistro.GetDecimal(leitorRegistro.GetOrdinal("bordaEspecial"));
                registro.bordaEspecial = Convert.ToDecimal(bordaEspecial);
            }

            return registro;
        }
        public override void ConfigurarParametros(Valor registro, DbCommand comando)
        {

            Type tipo = registro.GetType();
            PropertyInfo[] propriedades = tipo.GetProperties();

            foreach (PropertyInfo propriedade in propriedades)
            {
                AdicionarParameter(propriedade.Name, propriedade.GetValue(registro), comando);
            }
        }
    }
}
