using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Infra.Compartilhado.Mapeador;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection;

namespace PizzariaDoZe.Infra.FeatureIngrediente
{
    public class MapeadorIngrediente : MapeadorBase<Ingrediente>
    {
        public override void ConfigurarParametros(Ingrediente registro, DbCommand comando)
        {

            Type tipo = registro.GetType();
            PropertyInfo[] propriedades = tipo.GetProperties();

            foreach (PropertyInfo propriedade in propriedades)
            {
                AdicionarParameter(propriedade.Name, propriedade.GetValue(registro), comando);
            }
        }

        public override Ingrediente ConverterRegistro(SqlDataReader leitorRegistro)
        {
            Ingrediente registro = new Ingrediente();

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("id")))
            {
                int id_ingrediente = leitorRegistro.GetInt32(leitorRegistro.GetOrdinal("id"));
                registro.id = id_ingrediente;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("nome")))
            {
                string descricao_ingrediente = leitorRegistro.GetString(leitorRegistro.GetOrdinal("nome"));
                registro.nome = descricao_ingrediente;
            }

            return registro;
        }
    }
}
