using PizzariaDoZe.Domain.FeatureValor;
using PizzariaDoZe.Infra.Compartilhado;
using PizzariaDoZe.Infra.FeatureIngrediente;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection.Metadata;

namespace PizzariaDoZe.Infra.FeatureValor
{
    public class RepositorioValor : RepositorioBase<Valor>, IRepositorioValor
    {
        public override string selecionarTodosSql => @"SELECT * FROM [pizzaria_ze].[cadastro].[tb_valor]";

        public override string selecionarPorIdSql => @"SELECT * FROM [pizzaria_ze].[cadastro].[tb_valor] where id = @id";

        public override string insertSql => @"INSERT INTO [cadastro].[tb_valor]
                                               (tamanho
                                               ,tradicional
                                               ,especial
                                               ,bordaTradicional
                                               ,bordaEspecial)
                                         VALUES
                                               (@tamanho
                                               ,@tradicional
                                               ,@especial
                                               ,@bordaTradicional
                                               ,@bordaEspecial)";

        public override string editarSql => @"UPDATE [cadastro].[tb_valor]
                                               SET tamanho = @tamanho
                                                  ,tradicional = @tradicional
                                                  ,especial = @especial
                                                  ,bordaTradicional = @bordaTradicional
                                                  ,bordaEspecial = @bordaEspecial
                                             WHERE id = @id";

        public override string exclusaoSql => @"DELETE FROM [pizzaria_ze].[cadastro].[tb_valor] where id = @id";

        public string selecionarPorTamanhoSql => @"SELECT * FROM [pizzaria_ze].[cadastro].[tb_valor] where tamanho = @tamanho";

        public override Valor ConverterValor(SqlDataReader reader)
        {
            return new MapeadorValor().ConverterRegistro(reader);
        }

        public override void MapearCampoIdentificador(SqlCommand command, int id)
        {
            new MapeadorValor().ConfigurarParametro("@id", id.ToString(), command);
        }

        public override void MapearObjeto(Valor objeto, DbCommand comando)
        {
            new MapeadorValor().ConfigurarParametros(objeto, comando);
        }

        public Valor SelecionarPorTamanho(TamanhoPizza tamanho)
        {
           
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(selecionarPorTamanhoSql, connection);

                var tamanhoCommand = command.CreateParameter();
                tamanhoCommand.ParameterName = "@tamanho";
                tamanhoCommand.Value = tamanho;
                command.Parameters.Add(tamanhoCommand);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            return ConverterValor(reader);
                        }
                    }
                }
            }
            return null;
        }
    }
}
