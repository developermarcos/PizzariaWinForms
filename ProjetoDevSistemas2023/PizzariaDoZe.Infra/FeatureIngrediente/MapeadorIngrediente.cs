using Microsoft.Win32;
using PizzariaDoZe.Domain.FeatureIngrediente;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.FeatureIngrediente
{
    public class MapeadorIngrediente
    {
        public void ConfigurarParametros(string parametro, string valor, DbCommand comando)
        {
            var item = comando.CreateParameter();
            item.ParameterName = parametro;
            item.Value = valor;
            comando.Parameters.Add(item);
        }
        public void ConfigurarParametros(Ingrediente registro, DbCommand comando)
        {

            Type tipo = registro.GetType();
            PropertyInfo[] propriedades = tipo.GetProperties();

            foreach (PropertyInfo propriedade in propriedades)
            {
                AdicionarParameter(propriedade.GetValue(registro), propriedade.Name, comando);
            }
        }

        public Ingrediente ConverterRegistro(SqlDataReader leitorRegistro)
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

        #region métodos privados
        private void AdicionarParameter(object propertieValue, string propertieName, DbCommand comando)
        {
            var item = comando.CreateParameter();
            item.ParameterName = propertieName;
            item.Value = propertieValue;
            comando.Parameters.Add(item);
        }
        #endregion
    }
}
