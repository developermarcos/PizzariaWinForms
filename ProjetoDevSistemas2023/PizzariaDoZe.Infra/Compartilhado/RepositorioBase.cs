using PizzariaDoZe.Domain.Compartilhado;
using System.Data.Common;
using System.Data.SqlClient;

namespace PizzariaDoZe.Infra.Compartilhado
{
    public abstract class RepositorioBase<T> : Connection, IRepositorioBase<T>
    {
        public abstract string selecionarTodosSql { get; }
        public abstract string selecionarPorIdSql { get; }
        public abstract string insertSql { get; }
        public abstract string editarSql { get; }
        public abstract string exclusaoSql { get; }

        public void Editar(T registro)
        {
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(editarSql, connection);

                MapearObjeto(registro, command);

                command.ExecuteNonQuery();
            }
        }

        public void Excluir(T registro)
        {
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(exclusaoSql, connection);

                MapearObjeto(registro, command);

                command.ExecuteNonQuery();
            }
        }

        public void Inserir(T registro)
        {
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(insertSql, connection);

                MapearObjeto(registro, command);

                command.ExecuteNonQuery();
            }
        }

        public T SelecionarPorId(int id)
        {
            var registro = (T)Activator.CreateInstance(typeof(T));

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
            return registro;
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
