using PizzariaDoZe.Domain.Compartilhado;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Infra.FeatureIngrediente;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.Compartilhado
{
    internal abstract class RepositorioBase<T> : Connection, IRepositorioBase<T>
    {
        public abstract string selecionarTodosSql { get; }
        public abstract string selecionarPorIdSql { get; }
        public abstract string insertSql { get; }
        public abstract string editarSql { get; }
        public abstract string exclusaoSql { get; }

        public void Editar(T ingrediente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(T ingrediente)
        {
            throw new NotImplementedException();
        }

        public void Inserir(T Ingrediente)
        {
            throw new NotImplementedException();
        }

        public T SelecionarPorId(int id)
        {
            var ingrediente = new T();

            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(selecionarPorIdSql, connection);

                //new MapeadorIngrediente().ConfigurarParametros("@id_ingrediente", id.ToString(), command);

                MapearCampoIdentificador(command);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            //ingrediente = new MapeadorIngrediente().ConverterRegistro(reader);
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
                            //var result = new MapeadorIngrediente().ConverterRegistro(reader);
                            var result = ConverterValor(reader);
                            listaItens.Add(result);
                        }
                    }
                }
            }
            return listaItens;
        }
        public abstract T ConverterValor(SqlDataReader reader);
        public abstract void MapearCampoIdentificador(SqlCommand command);
    }
}
