using PizzariaDoZe.Domain.FeatureSabor;
using PizzariaDoZe.Infra.Compartilhado.Mapeador;
using System.Data.Common;
using System.Data.SqlClient;

namespace PizzariaDoZe.Infra.FeatureSabor
{
    internal class MapeadorSabor : MapeadorBase<Sabor>
    {
        public override Sabor ConverterRegistro(SqlDataReader leitorRegistro)
        {
            Sabor registro = new Sabor();

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("id")))
            {
                int id_sabor = leitorRegistro.GetInt32(leitorRegistro.GetOrdinal("id"));
                registro.id = id_sabor;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("nome")))
            {
                string descricao_sabor = leitorRegistro.GetString(leitorRegistro.GetOrdinal("nome"));
                registro.nome = descricao_sabor;
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
            if (registro.id != 0)
            {
                var id_sabor = comando.CreateParameter();
                id_sabor.ParameterName = "@id";
                id_sabor.Value = registro.id;
                comando.Parameters.Add(id_sabor);
            }

            var descricao_sabor = comando.CreateParameter();
            descricao_sabor.ParameterName = "@nome";
            descricao_sabor.Value = registro.nome;
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
