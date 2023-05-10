using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Infra.Compartilhado;

namespace PizzariaDoZe.Infra.FeatureIngrediente
{
    public class RepositorioIngrediente : Connection, IRepositorioIngrediente
    {
        public string insertSql => @"INSERT INTO tb_ingrediente(nome) VALUES (@nome)";
        public void Inserir(IngredienteVO Ingrediente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = strConnection; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var nome = comando.CreateParameter();
            nome.ParameterName = "@nome";
            nome.Value = Ingrediente.Nome;
            comando.Parameters.Add(nome);
            conexao.Open();
            comando.CommandText = insertSql;
            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
            //using faz o Close() automático quando fecha o seu escopo
        }
    }
}