using Microsoft.Win32;
using PizzariaDoZe.Domain.FeatureSabor;
using PizzariaDoZe.Domain.FeatureValor;
using PizzariaDoZe.Infra.Compartilhado;
using PizzariaDoZe.Infra.FeatureProduto;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection.Metadata;

namespace PizzariaDoZe.Infra.FeatureSabor
{
    public class RepositorioSabor : RepositorioBase<Sabor>, IRepositorioSabor
    {
        public override string selecionarTodosSql => @"SELECT TOP (1000) * FROM [pizzaria_ze].[dbo].[tb_sabores]";

        public override string selecionarPorIdSql => @"SELECT TOP (1000) * FROM [pizzaria_ze].[dbo].[tb_sabores] where id_sabor = @id_sabor";

        public override string insertSql => @"INSERT INTO [dbo].[tb_sabores]
                                                   (descricao_sabor
                                                   ,foto
                                                   ,categoria
                                                   ,tipo)
                                             VALUES
                                                   (@descricao_sabor
                                                   ,@foto
                                                   ,@categoria
                                                   ,@tipo)";

        public override string editarSql => @"UPDATE [dbo].[tb_sabores]
                                               SET descricao_sabor = @descricao_sabor
                                                  ,foto = @foto
                                                  ,categoria = @categoria
                                                  ,tipo = @tipo
                                              WHERE id_sabor = @id_sabor";

        public override string exclusaoSql => @"DELETE FROM [dbo].[cad_produtos] WHERE id_sabor = @id_sabor";

        public override Sabor ConverterValor(SqlDataReader reader)
        {
            return new MapeadorSabor().ConverterRegistro(reader);
        }

        public override void MapearCampoIdentificador(SqlCommand command, int id)
        {
            var id_sabor = command.CreateParameter();
            id_sabor.ParameterName = "@id_sabor";
            id_sabor.Value = id;
            command.Parameters.Add(id_sabor);
        }

        public override void MapearObjeto(Sabor objeto, DbCommand comando)
        {
            new MapeadorSabor().ConfigurarParametros(objeto, comando);
        }

        public override void Inserir(Sabor registro)
        {
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();
                
                SqlCommand command = new SqlCommand(insertSql, connection);
                
                new MapeadorSabor().ConfigurarParametros(registro, command);

                command.ExecuteNonQuery();
            }
        }
    }
}
