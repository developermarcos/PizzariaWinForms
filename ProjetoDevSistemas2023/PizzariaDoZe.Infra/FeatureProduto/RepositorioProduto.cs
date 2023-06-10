using PizzariaDoZe.Domain.FeatureProduto;
using PizzariaDoZe.Infra.Compartilhado;
using PizzariaDoZe.Infra.FeatureIngrediente;
using System.Data.Common;
using System.Data.SqlClient;

namespace PizzariaDoZe.Infra.FeatureProduto
{
    public class RepositorioProduto : RepositorioBase<Produto>, IRepositorioProduto
    {
        public override string selecionarTodosSql => @"SELECT TOP (1000) * FROM [pizzaria_ze].[dbo].[cad_produtos]";

        public override string selecionarPorIdSql => @"SELECT TOP (1000) * FROM [pizzaria_ze].[dbo].[cad_produtos] where id_produto = @id_produto";

        public override string insertSql => @"INSERT INTO [dbo].[cad_produtos]
                                                   ([descricao_produto]
                                                   ,[valor]
                                                   ,[tipo]
                                                   ,[medida_unitaria])
                                             VALUES
                                                   (@descricao_produto
                                                   ,@valor
                                                   ,@tipo
                                                   ,@medida_unitaria)";

        public override string editarSql => @"UPDATE [dbo].[cad_produtos]
                                               SET [descricao_produto] = @descricao_produto
                                                  ,[valor] = @valor
                                                  ,[tipo] = @tipo
                                                  ,[medida_unitaria] = @medida_unitaria
                                             WHERE id_produto = @id_produto";

        public override string exclusaoSql => @"DELETE FROM [dbo].[cad_produtos] WHERE id_produto = @id_produto";

        public override Produto ConverterValor(SqlDataReader reader)
        {
            return new MapeadorProduto().ConverterRegistro(reader);
        }

        public override void MapearCampoIdentificador(SqlCommand command, int id)
        {
            new MapeadorProduto().ConfigurarParametros("@id_produto", id.ToString(), command);
        }

        public override void MapearObjeto(Produto objeto, DbCommand comando)
        {
            new MapeadorProduto().ConfigurarParametros(objeto, comando);
        }
    }
}
