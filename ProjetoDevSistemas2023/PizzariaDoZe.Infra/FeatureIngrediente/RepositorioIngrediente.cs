using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Infra.Compartilhado;
using System.Data.Common;
using System.Data.SqlClient;

namespace PizzariaDoZe.Infra.FeatureIngrediente
{
    public class RepositorioIngrediente : RepositorioBase<Ingrediente>, IRepositorioIngrediente
    {
        public override string selecionarTodosSql => @"Select * from cad_ingredientes";
        public override string selecionarPorIdSql => @"Select * from cad_ingredientes where [id_ingrediente] = @id_ingrediente";
        public override string insertSql => @"INSERT INTO cad_ingredientes(descricao_ingrediente) VALUES (@descricao_ingrediente)";
        public override string editarSql => @"UPDATE [dbo].[cad_ingredientes]
                                       SET [descricao_ingrediente] = @descricao_ingrediente
                                     WHERE [id_ingrediente] = @id_ingrediente";
        public override string exclusaoSql => @"DELETE cad_ingredientes WHERE id_ingrediente = @id_ingrediente";

        public override Ingrediente ConverterValor(SqlDataReader reader)
        {
            return new MapeadorIngrediente().ConverterRegistro(reader);
        }

        public override void MapearCampoIdentificador(SqlCommand command, int id)
        {
            new MapeadorIngrediente().ConfigurarParametros("@id_ingrediente", id.ToString(), command);
        }

        public override void MapearObjeto(Ingrediente objeto, DbCommand comando)
        {
            new MapeadorIngrediente().ConfigurarParametros(objeto, comando);
        }
    }
}