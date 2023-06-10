using PizzariaDoZe.Domain.Compartilhado;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Infra.FeatureIngrediente;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.Compartilhado
{
    public abstract class RepositorioBase<T> : Connection, IRepositorioBase<T>
    {
        public abstract string selecionarTodosSql { get; }
        public abstract string selecionarPorIdSql { get; }
        public abstract string insertSql { get; }
        public abstract string editarSql { get; }
        public abstract string exclusaoSql { get; }

        public void Editar(T ingrediente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = strConnection; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            MapearObjeto(ingrediente, comando);

            conexao.Open();
            comando.CommandText = editarSql;
            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
            //using faz o Close() automático quando fecha o seu escopo
        }

        public void Excluir(T ingrediente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = strConnection; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            MapearObjeto(ingrediente, comando);
            conexao.Open();
            comando.CommandText = exclusaoSql;
            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
            //using faz o Close() automático quando fecha o seu escopo
        }

        public void Inserir(T Ingrediente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = strConnection; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            MapearObjeto(Ingrediente, comando);

            conexao.Open();
            comando.CommandText = insertSql;
            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
            //using faz o Close() automático quando fecha o seu escopo
        }

        public T SelecionarPorId(int id)
        {
            //var ingrediente = new T();
            var ingrediente = (T)Activator.CreateInstance(typeof(T));

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
                            ingrediente = ConverterValor(reader);
                        }
                    }
                }
            }
            return ingrediente;
        }

        public List<T> SelecionarTodos()
        {
            var listaItens = new List<T>();

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
                            var result = ConverterValor(reader);
                            listaItens.Add(result);
                        }
                    }
                }
            }
            return listaItens;
        }
        public abstract T ConverterValor(SqlDataReader reader);
        public abstract void MapearCampoIdentificador(SqlCommand command, int id);
        public abstract void MapearObjeto(T objeto, DbCommand comando);
    }
}
