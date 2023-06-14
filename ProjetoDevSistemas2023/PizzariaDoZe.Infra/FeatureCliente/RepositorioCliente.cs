using PizzariaDoZe.Domain.FeatureCliente;
using PizzariaDoZe.Infra.Compartilhado;
using System.Data.Common;
using System.Data.SqlClient;

namespace PizzariaDoZe.Infra.FeatureCliente
{
    public class RepositorioCliente : RepositorioBase<Cliente>, IRepositorioCliente
    {
        public override string selecionarTodosSql => @"SELECT * FROM [pizzaria_ze].[cadastro].[tb_cliente] where excluido = 0";

        public override string selecionarPorIdSql => @"SELECT * FROM [pizzaria_ze].[cadastro].[tb_cliente] where id = @id";

        public override string insertSql => @"INSERT INTO [cadastro].[tb_cliente]
                                                           (nome
                                                           ,cpf
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

        public override string editarSql => @"UPDATE [cadastro].[tb_cliente]
                                                    SET  nome = @nome
                                                        ,cpf = @cpf
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

        public override string exclusaoSql => @"UPDATE [cadastro].[tb_cliente]
                                                    SET excluido = 1
                                                    WHERE id = @id";

        public override Cliente ConverterValor(SqlDataReader reader)
        {
            return new MapeadorCliente().ConverterRegistro(reader);
        }

        public override void MapearCampoIdentificador(SqlCommand command, int id)
        {
            new MapeadorCliente().ConfigurarParametro("@id", id.ToString(), command);
        }

        public override void MapearObjeto(Cliente objeto, DbCommand comando)
        {
            new MapeadorCliente().ConfigurarParametros(objeto, comando);
        }
    }
}
