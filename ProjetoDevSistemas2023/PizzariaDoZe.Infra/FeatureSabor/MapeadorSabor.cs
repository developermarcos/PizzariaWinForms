using PizzariaDoZe.Domain.FeatureProduto;
using PizzariaDoZe.Domain.FeatureSabor;
using PizzariaDoZe.Infra.Compartilhado;
using System.Data.Common;
using System.Data.SqlClient;

namespace PizzariaDoZe.Infra.FeatureSabor
{
    internal class MapeadorSabor : MapeadorBase<Sabor>
    {
        public override Sabor ConverterRegistro(SqlDataReader leitorRegistro)
        {
            Sabor registro = new Sabor();
            
            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("id_sabor")))
            {
                int id_sabor = leitorRegistro.GetInt32(leitorRegistro.GetOrdinal("id_sabor"));
                registro.id_sabor = id_sabor;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("descricao_sabor")))
            {
                string descricao_sabor = leitorRegistro.GetString(leitorRegistro.GetOrdinal("descricao_sabor"));
                registro.descricao_sabor = descricao_sabor;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("foto")))
            {
                byte[] foto = leitorRegistro.GetFieldValue<byte[]>(leitorRegistro.GetOrdinal("foto"));
                registro.foto = foto;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("categoria")))
            {
                CategoriaSabor categoria = Enum.Parse<CategoriaSabor>(leitorRegistro.GetString(leitorRegistro.GetOrdinal("categoria")));
                registro.categoria = categoria;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("tipo")))
            {
                TipoSabor tipo = Enum.Parse<TipoSabor>(leitorRegistro.GetString(leitorRegistro.GetOrdinal("tipo")));
                registro.tipo = tipo;
            }

            return registro;
        }

        public override void ConfigurarParametros(Sabor registro, DbCommand comando)
        {
            var descricao_sabor = comando.CreateParameter();
            descricao_sabor.ParameterName = "@descricao_sabor";
            descricao_sabor.Value = registro.descricao_sabor;
            comando.Parameters.Add(descricao_sabor);

            var categoria = comando.CreateParameter();
            categoria.ParameterName = "@categoria";
            categoria.Value = registro.categoria;
            comando.Parameters.Add(categoria);

            var tipo = comando.CreateParameter();
            tipo.ParameterName = "@tipo";
            tipo.Value = registro.tipo;
            comando.Parameters.Add(tipo);

            var item = comando.CreateParameter();
            item.ParameterName = "@foto";
            item.Value = registro.foto;
            comando.Parameters.Add(item);
        }
    }
}
