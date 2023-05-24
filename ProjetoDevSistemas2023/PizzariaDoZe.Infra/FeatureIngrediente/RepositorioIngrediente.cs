using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Infra.Compartilhado;
using System.Data.Common;
using System.Data.SqlClient;

namespace PizzariaDoZe.Infra.FeatureIngrediente
{
    public class RepositorioIngrediente : Connection, IRepositorioIngrediente
    {
        public string selecionarTodosSql => @"Select * from tb_ingrediente";
        public string insertSql => @"INSERT INTO tb_ingrediente(nome) VALUES (@nome)";
        public void Inserir(Ingrediente Ingrediente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = strConnection; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            new MapeadorIngrediente().ConfigurarParametros(Ingrediente, comando);
            conexao.Open();
            comando.CommandText = insertSql;
            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
            //using faz o Close() automático quando fecha o seu escopo
        }

        public List<Ingrediente> SelecionarTodos()
        {
            var ingredientes = new List<Ingrediente>();
            
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(selecionarTodosSql, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            var result = new MapeadorIngrediente().ConverterRegistro(reader);
                            ingredientes.Add(result);
                        }
                    }
                }
            }
            return ingredientes;
        }
    }
}