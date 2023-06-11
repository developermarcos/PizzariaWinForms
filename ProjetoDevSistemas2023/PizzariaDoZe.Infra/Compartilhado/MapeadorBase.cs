﻿using PizzariaDoZe.Domain.FeatureIngrediente;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.Compartilhado
{
    internal abstract class MapeadorBase<T>
    {
        public virtual void ConfigurarParametros(string parametro, string valor, DbCommand comando)
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
