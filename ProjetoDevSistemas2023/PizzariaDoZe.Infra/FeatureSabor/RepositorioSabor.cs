using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Domain.FeatureSabor;
using PizzariaDoZe.Infra.Compartilhado;
using PizzariaDoZe.Infra.FeatureIngrediente;
using System.Data.Common;
using System.Data.SqlClient;

namespace PizzariaDoZe.Infra.FeatureSabor
{
    public class RepositorioSabor : RepositorioBase<Sabor>, IRepositorioSabor
    {
        public override string selecionarTodosSql => @"SELECT TOP (1000) * FROM [pizzaria_ze].[cadastro].[tb_sabor]";

        public override string selecionarPorIdSql => @"SELECT TOP (1000) * FROM [pizzaria_ze].[cadastro].[tb_sabor] where id = @id";

        public override string insertSql => @"INSERT INTO [pizzaria_ze].[cadastro].[tb_sabor]
                                                   (nome
                                                   ,foto
                                                   ,categoria
                                                   ,tipo)
                                             VALUES
                                                   (@nome
                                                   ,@foto
                                                   ,@categoria
                                                   ,@tipo)
                                            SELECT SCOPE_IDENTITY()";

        public override string editarSql => @"UPDATE [pizzaria_ze].[cadastro].[tb_sabor]
                                               SET nome = @nome
                                                  ,foto = @foto
                                                  ,categoria = @categoria
                                                  ,tipo = @tipo
                                              WHERE id = @id";

        public override string exclusaoSql => @"DELETE FROM [pizzaria_ze].[cadastro].[tb_sabor] WHERE id = @id";

        public string selectIngredientes_saborSql => @"Select * from pizzaria_ze.cadastro.tb_ingrediente as ingrediente
                                                inner join [pizzaria_ze].[cadastro].[ingredientes_sabores] as vinculo
                                                on vinculo.ingrediente_id = ingrediente.id
                                                where vinculo.sabor_id = @id";

        public string inserirIngredientes_saborSql => @"INSERT INTO [cadastro].[ingredientes_sabores]
                                                           (ingrediente_id
                                                           ,sabor_id)
                                                     VALUES
                                                           (@ingrediente_id
                                                           ,@sabor_id)";

        public string excluirIngredientes_saborSql => @"DELETE FROM [cadastro].[ingredientes_sabores] where sabor_id = @sabor_id";

        public override Sabor ConverterValor(SqlDataReader reader)
        {
            return new MapeadorSabor().ConverterRegistro(reader);
        }

        public override void MapearCampoIdentificador(SqlCommand command, int id)
        {
            var id_sabor = command.CreateParameter();
            id_sabor.ParameterName = "@id";
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

                var mapeadorSabor = new MapeadorSabor();

                mapeadorSabor.ConfigurarParametros(registro, command);

                var idSaborInserido = command.ExecuteScalar();

                registro.ingredientes.ForEach(x =>
                {
                    SqlCommand command2 = new SqlCommand(selecionarPorIdSql, connection);
                    mapeadorSabor.ConfigurarParametro("@sabor_id", idSaborInserido.ToString(), command2);
                    mapeadorSabor.ConfigurarParametro("@ingrediente_id", x.id.ToString(), command2);
                    command2.ExecuteNonQuery();
                });

            }
        }

        public override void Editar(Sabor registro)
        {
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(editarSql, connection);

                var mapeadorSabor = new MapeadorSabor();

                mapeadorSabor.ConfigurarParametros(registro, command);

                command.ExecuteNonQuery();

                SqlCommand command2 = new SqlCommand(excluirIngredientes_saborSql, connection);

                mapeadorSabor.ConfigurarParametro("@sabor_id", registro.id.ToString(), command2);
                command2.ExecuteNonQuery();

                registro.ingredientes.ForEach(x =>
                 {
                     SqlCommand command3 = new SqlCommand(inserirIngredientes_saborSql, connection);
                     mapeadorSabor.ConfigurarParametro("@sabor_id", registro.id.ToString(), command3);
                     mapeadorSabor.ConfigurarParametro("@ingrediente_id", x.id.ToString(), command3);
                     command3.ExecuteNonQuery();
                 });
            }
        }

        public override void Excluir(Sabor registro)
        {
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                SqlCommand command2 = new SqlCommand(excluirIngredientes_saborSql, connection);

                new MapeadorSabor().ConfigurarParametro("@sabor_id", registro.id.ToString(), command2);

                command2.ExecuteNonQuery();

                SqlCommand command = new SqlCommand(exclusaoSql, connection);

                MapearObjeto(registro, command);

                command.ExecuteNonQuery();
            }
        }

        public Sabor SelecionarPorId(int id, bool incluirIngredientes = false)
        {
            var registro = new Sabor();

            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(selecionarPorIdSql, connection);

                MapearCampoIdentificador(command, id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            registro = ConverterValor(reader);
                        }
                    }
                }
            }

            if (incluirIngredientes)
                registro.ingredientes = BuscarIngredientes(registro.id);

            return registro;
        }

        private List<Ingrediente> BuscarIngredientes(int saborId)
        {

            var listaItens = new List<Ingrediente>();

            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(selectIngredientes_saborSql, connection);

                var mapeadorIngrediente = new MapeadorIngrediente();

                mapeadorIngrediente.ConfigurarParametros("@id", saborId.ToString(), command);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            var result = mapeadorIngrediente.ConverterRegistro(reader);
                            listaItens.Add(result);
                        }
                    }
                }
            }
            return listaItens;
        }
    }
}
