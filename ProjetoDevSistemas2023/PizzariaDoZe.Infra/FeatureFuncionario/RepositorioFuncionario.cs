using PizzariaDoZe.Domain.FeatureCliente;
using PizzariaDoZe.Domain.FeatureFuncionario;
using PizzariaDoZe.Infra.Compartilhado;
using PizzariaDoZe.Infra.FeatureCliente;
using System.Data.Common;
using System.Data.SqlClient;

namespace PizzariaDoZe.Infra.FeatureFuncionario
{
    public class RepositorioFuncionario : RepositorioBase<Funcionario>, IRepositorioFuncionario
    {
        public override string selecionarTodosSql => @"SELECT * FROM [cadastro].[tb_funcionario] where excluido = 0";

        public override string selecionarPorIdSql => @"SELECT * FROM [cadastro].[tb_funcionario] where id = @id";

        public override string insertSql => @"INSERT INTO [cadastro].[tb_funcionario]
                                                    (nome
                                                    ,cpf
                                                    ,matricula
                                                    ,senha
                                                    ,grupo
                                                    ,possuiHabilitacao
                                                    ,cnh
                                                    ,validade_motorista
                                                    ,observacao
                                                    ,telefone
                                                    ,email
                                                    ,logradouro
                                                    ,bairro
                                                    ,numero
                                                    ,cep
                                                    ,cidade
                                                    ,pais
                                                    ,complemento
                                                    ,excluido)
                                                VALUES
                                                    (@nome
                                                    ,@cpf
                                                    ,@matricula
                                                    ,@senha
                                                    ,@grupo
                                                    ,@possuiHabilitacao
                                                    ,@cnh
                                                    ,@validade_motorista
                                                    ,@observacao
                                                    ,@telefone
                                                    ,@email
                                                    ,@logradouro
                                                    ,@bairro
                                                    ,@numero
                                                    ,@cep
                                                    ,@cidade
                                                    ,@pais
                                                    ,@complemento
                                                    ,@excluido)";

        public override string editarSql => @"UPDATE [cadastro].[tb_funcionario]
                                                   SET nome = @nome
                                                      ,cpf = @cpf
                                                      ,matricula = @matricula
                                                      ,senha = @senha
                                                      ,grupo = @grupo
                                                      ,possuiHabilitacao = @possuiHabilitacao
                                                      ,cnh = @cnh
                                                      ,validade_motorista = @validade_motorista
                                                      ,observacao = @observacao
                                                      ,telefone = @telefone
                                                      ,email = @email
                                                      ,logradouro = @logradouro
                                                      ,bairro = @bairro
                                                      ,numero = @numero
                                                      ,cep = @cep
                                                      ,cidade = @cidade
                                                      ,pais = @pais
                                                      ,complemento = @complemento
                                                      ,excluido = @excluido
                                                 WHERE id = @id";

        public override string exclusaoSql => @"UPDATE [cadastro].[tb_funcionario] SET [excluido] = 1 WHERE id = @id";

        public override Funcionario ConverterValor(SqlDataReader reader)
        {
            return new MapeadorFuncionario().ConverterRegistro(reader);
        }

        public override void MapearCampoIdentificador(SqlCommand command, int id)
        {
            new MapeadorFuncionario().ConfigurarParametro("@id", id.ToString(), command);
        }

        public override void MapearObjeto(Funcionario objeto, DbCommand comando)
        {
            new MapeadorFuncionario().ConfigurarParametros(objeto, comando);
        }
    }
}
