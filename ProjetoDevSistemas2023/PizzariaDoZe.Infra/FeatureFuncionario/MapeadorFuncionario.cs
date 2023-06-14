using PizzariaDoZe.Domain.Compartilhado;
using PizzariaDoZe.Domain.FeatureCliente;
using PizzariaDoZe.Domain.FeatureFuncionario;
using PizzariaDoZe.Infra.Compartilhado.Mapeador;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace PizzariaDoZe.Infra.FeatureFuncionario
{
    public class MapeadorFuncionario : MapeadorBase<Funcionario>
    {
        public override void ConfigurarParametros(Funcionario registro, DbCommand comando)
        {
            if (registro.id != 0)
                AdicionarParameter("id", registro.id.ToString(), comando);

            AdicionarParameter("nome", registro.nome, comando);
            AdicionarParameter("cpf", registro.cpf, comando);
            AdicionarParameter("email", registro.email, comando);
            AdicionarParameter("telefone", registro.telefone, comando);
            AdicionarParameter("excluido", registro.excluido, comando);
            AdicionarParameter("matricula", registro.matricula, comando);
            AdicionarParameter("senha", registro.senha, comando);
            AdicionarParameter("grupo", registro.grupo, comando);
            AdicionarParameter("possuiHabilitacao", registro.possuiHabilitacao, comando);
            AdicionarParameter("cnh", registro.cnh, comando);
            AdicionarParameter("validade_motorista", registro.validade_motorista, comando);
            AdicionarParameter("observacao", registro.observacao, comando);
            new MapeadorEndereco().ConfigurarParametros(registro.endereco, comando);
        }

        public override Funcionario ConverterRegistro(SqlDataReader leitorRegistro)
        {
            Funcionario registro = new Funcionario();

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

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("matricula")))
            {
                string matricula = leitorRegistro.GetString(leitorRegistro.GetOrdinal("matricula"));
                registro.matricula = matricula;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("senha")))
            {
                string senha = leitorRegistro.GetString(leitorRegistro.GetOrdinal("senha"));
                registro.senha = senha;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("grupo")))
            {
                GrupoFuncionario grupo = Enum.Parse<GrupoFuncionario>(leitorRegistro.GetString(leitorRegistro.GetOrdinal("grupo")));
                registro.grupo = grupo;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("possuiHabilitacao")))
            {
                bool possuiHabilitacao = leitorRegistro.GetBoolean(leitorRegistro.GetOrdinal("possuiHabilitacao"));
                registro.possuiHabilitacao = possuiHabilitacao;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("cnh")))
            {
                string cnh = leitorRegistro.GetString(leitorRegistro.GetOrdinal("cnh"));
                registro.cnh = cnh;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("validade_motorista")))
            {
                DateTime validade_motorista = leitorRegistro.GetDateTime(leitorRegistro.GetOrdinal("validade_motorista"));
                registro.validade_motorista = validade_motorista;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("observacao")))
            {
                string observacao = leitorRegistro.GetString(leitorRegistro.GetOrdinal("observacao"));
                registro.observacao = observacao;
            }
            
            registro.endereco = new MapeadorEndereco().ConverterRegistro(leitorRegistro);

            return registro;
        }
    }
}
