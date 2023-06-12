using PizzariaDoZe.Domain.FeatureProduto;
using PizzariaDoZe.Infra.Compartilhado;
using System.Data.Common;
using System.Data.SqlClient;

namespace PizzariaDoZe.Infra.FeatureProduto
{
    public class RepositorioProduto : RepositorioBase<Produto>, IRepositorioProduto
    {
        public override string selecionarTodosSql => @"SELECT TOP (1000) * FROM [cadastro].[tb_produto]";

        public override string selecionarPorIdSql => @"SELECT TOP (1000) * FROM [cadastro].[tb_produto] where id = @id";

        public override string insertSql => @"INSERT INTO [cadastro].[tb_produto]
                                                   ([nome]
                                                   ,[valor]
                                                   ,[tipo]
                                                   ,[medida_unitaria])
                                             VALUES
                                                   (@nome
                                                   ,@valor
                                                   ,@tipo
                                                   ,@medida_unitaria)";

        public override string editarSql => @"UPDATE [cadastro].[tb_produto]
                                               SET [nome] = @nome
                                                  ,[valor] = @valor
                                                  ,[tipo] = @tipo
                                                  ,[medida_unitaria] = @medida_unitaria
                                             WHERE id = @id";

        public override string exclusaoSql => @"DELETE FROM [cadastro].[tb_produto] WHERE id = @id";

        public override Produto ConverterValor(SqlDataReader reader)
        {
            return new MapeadorProduto().ConverterRegistro(reader);
        }

        public override void MapearCampoIdentificador(SqlCommand command, int id)
        {
            new MapeadorProduto().ConfigurarParametro("@id", id.ToString(), command);
        }

        public override void MapearObjeto(Produto objeto, DbCommand comando)
        {
            new MapeadorProduto().ConfigurarParametros(objeto, comando);
        }
    }
}
