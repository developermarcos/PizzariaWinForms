using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Infra.Compartilhado;
using System.Data.Common;
using System.Data.SqlClient;

namespace PizzariaDoZe.Infra.FeatureIngrediente
{
    public class RepositorioIngrediente : RepositorioBase<Ingrediente>, IRepositorioIngrediente
    {
        public override string selecionarTodosSql => @"Select * from pizzaria_ze.cadastro.tb_ingrediente";
        public override string selecionarPorIdSql => @"Select * from pizzaria_ze.cadastro.tb_ingrediente where [id] = @id";
        public override string insertSql => @"INSERT INTO pizzaria_ze.cadastro.tb_ingrediente (nome) VALUES (@nome)";
        public override string editarSql => @"UPDATE pizzaria_ze.cadastro.tb_ingrediente
                                       SET [nome] = @nome
                                     WHERE [id] = @id";
        public override string exclusaoSql => @"DELETE pizzaria_ze.cadastro.tb_ingrediente WHERE id = @id";

        public override Ingrediente ConverterValor(SqlDataReader reader)
        {
            return new MapeadorIngrediente().ConverterRegistro(reader);
        }

        public override void MapearCampoIdentificador(SqlCommand command, int id)
        {
            new MapeadorIngrediente().ConfigurarParametros("@id", id.ToString(), command);
        }

        public override void MapearObjeto(Ingrediente objeto, DbCommand comando)
        {
            new MapeadorIngrediente().ConfigurarParametros(objeto, comando);
        }
    }
}