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
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                AdicionarParameter(propriedade.Name, propriedade.GetValue(registro), comando);
            }
        }
        public override Endereco ConverterRegistro(SqlDataReader leitorRegistro)
        {
            Endereco registro = new Endereco();

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("logradouro")))
            {
                string logradouro = leitorRegistro.GetString(leitorRegistro.GetOrdinal("logradouro"));
                registro.logradouro = logradouro;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("bairro")))
            {
                string bairro = leitorRegistro.GetString(leitorRegistro.GetOrdinal("bairro"));
                registro.bairro = bairro;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("numero")))
            {
                string numero = leitorRegistro.GetString(leitorRegistro.GetOrdinal("numero"));
                registro.numero = numero;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("cep")))
            {
                string cep = leitorRegistro.GetString(leitorRegistro.GetOrdinal("cep"));
                registro.cep = cep;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("cidade")))
            {
                string cidade = leitorRegistro.GetString(leitorRegistro.GetOrdinal("cidade"));
                registro.cidade = cidade;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("pais")))
            {
                string pais = leitorRegistro.GetString(leitorRegistro.GetOrdinal("pais"));
                registro.pais = pais;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("complemento")))
            {
                string complemento = leitorRegistro.GetString(leitorRegistro.GetOrdinal("complemento"));
                registro.complemento = complemento;
            }

            return registro;
        }
    }
}
