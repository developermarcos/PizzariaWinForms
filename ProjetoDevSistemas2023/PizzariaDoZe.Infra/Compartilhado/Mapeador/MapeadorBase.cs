using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection;

namespace PizzariaDoZe.Infra.Compartilhado.Mapeador
{
    public abstract class MapeadorBase<T>
    {
        public void ConfigurarParametro(string parametro, object valor, DbCommand comando)
        {
            var item = comando.CreateParameter();
            item.ParameterName = parametro;
            item.Value = valor;
            comando.Parameters.Add(item);
        }
        public virtual void ConfigurarParametros(T registro, DbCommand comando)
        {

            Type tipo = registro.GetType();
            PropertyInfo[] propriedades = tipo.GetProperties();

            foreach (PropertyInfo propriedade in propriedades)
            {
                AdicionarParameter(propriedade.GetValue(registro), propriedade.Name, comando);
            }
        }

        public abstract T ConverterRegistro(SqlDataReader leitorRegistro);

        #region métodos privados
        protected void AdicionarParameter(object propertieValue, string propertieName, DbCommand comando)
        {
            var item = comando.CreateParameter();
            item.ParameterName = propertieName;
            item.Value = propertieValue;
            comando.Parameters.Add(item);
        }
        #endregion
    }
}
