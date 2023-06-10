using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Infra.Compartilhado;
using System.Data.Common;
using System.Data.SqlClient;

namespace PizzariaDoZe.Infra.FeatureIngrediente
{
    public class RepositorioIngrediente : Connection, IRepositorioIngrediente
    {
        public string selecionarTodosSql => @"Select * from cad_ingredientes";
        public string selecionarPorIdSql => @"Select * from cad_ingredientes where [id_ingrediente] = @id_ingrediente";
        public string insertSql => @"INSERT INTO cad_ingredientes(descricao_ingrediente) VALUES (@descricao_ingrediente)";
        public string editarSql => @"UPDATE [dbo].[cad_ingredientes]
                                       SET [descricao_ingrediente] = @descricao_ingrediente
                                     WHERE [id_ingrediente] = @id_ingrediente";
        public string exclusaoSql => @"DELETE cad_ingredientes WHERE id_ingrediente = @id_ingrediente";

        public void Editar(Ingrediente ingrediente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = strConnection; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            new MapeadorIngrediente().ConfigurarParametros(ingrediente, comando);

            conexao.Open();
            comando.CommandText = editarSql;
            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
            //using faz o Close() automático quando fecha o seu escopo
        }

        public void Excluir(Ingrediente ingrediente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = strConnection; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            new MapeadorIngrediente().ConfigurarParametros(ingrediente, comando);
            conexao.Open();
            comando.CommandText = exclusaoSql;
            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
            //using faz o Close() automático quando fecha o seu escopo
        }

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

        public Ingrediente SelecionarPorId(int id)
        {
            var ingrediente = new Ingrediente();

            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(selecionarPorIdSql, connection);

                new MapeadorIngrediente().ConfigurarParametros("@id_ingrediente", id.ToString(), command);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            ingrediente = new MapeadorIngrediente().ConverterRegistro(reader);
                        }
                    }
                }
            }
            return ingrediente;
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