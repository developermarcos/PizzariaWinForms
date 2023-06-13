using PizzariaDoZe.Domain.Compartilhado;
using PizzariaDoZe.Domain.FeatureCliente;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.Compartilhado.Mapeador
{
    public class MapeadorEndereco : MapeadorBase<Endereco>
    {
        public override void ConfigurarParametros(Endereco registro, DbCommand comando)
        {

            Type tipo = registro.GetType();
            PropertyInfo[] propriedades = tipo.GetProperties();

            foreach (PropertyInfo propriedade in propriedades)
            {
                AdicionarParameter(propriedade.GetValue(registro), propriedade.Name, comando);
            }
        }
        public override Endereco ConverterRegistro(SqlDataReader leitorRegistro)
        {
            throw new NotImplementedException();
        }
    }
}
