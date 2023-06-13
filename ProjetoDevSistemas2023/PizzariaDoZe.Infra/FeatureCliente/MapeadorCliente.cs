using PizzariaDoZe.Domain.Compartilhado;
using PizzariaDoZe.Domain.FeatureCliente;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Infra.Compartilhado;
using PizzariaDoZe.Infra.Compartilhado.Mapeador;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection;

namespace PizzariaDoZe.Infra.FeatureCliente
{
    public class MapeadorCliente : MapeadorBase<Cliente>
    {
        public override void ConfigurarParametros(Cliente registro, DbCommand comando)
        {
            if (registro.id != 0)
                AdicionarParameter("id", registro.id.ToString(), comando);

            AdicionarParameter("nome", registro.nome, comando);
            AdicionarParameter("cpf", registro.cpf, comando);
            AdicionarParameter("email", registro.email, comando);
            AdicionarParameter("telefone", registro.telefone, comando);
            AdicionarParameter("excluido", registro.excluido, comando);
            new MapeadorEndereco().ConfigurarParametros(registro.endereco, comando);
        }

        public override Cliente ConverterRegistro(SqlDataReader leitorRegistro)
        {
            Cliente registro = new Cliente();

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

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("cpf")))
            {
                string cpf = leitorRegistro.GetString(leitorRegistro.GetOrdinal("cpf"));
                registro.cpf = cpf;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("email")))
            {
                string email = leitorRegistro.GetString(leitorRegistro.GetOrdinal("email"));
                registro.email = email;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("telefone")))
            {
                string telefone = leitorRegistro.GetString(leitorRegistro.GetOrdinal("telefone"));
                registro.telefone = telefone;
            }

            registro.endereco = new MapeadorEndereco().ConverterRegistro(leitorRegistro);

            return registro;
        }
    }
}
