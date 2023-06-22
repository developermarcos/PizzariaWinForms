using PizzariaDoZe.Domain.FeatureCliente;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Domain.FeaturePedido;
using PizzariaDoZe.Domain.FeatureProduto;
using PizzariaDoZe.Domain.FeatureSabor;
using PizzariaDoZe.Domain.FeatureValor;
using PizzariaDoZe.Infra.Compartilhado;
using PizzariaDoZe.Infra.FeatureIngrediente;
using PizzariaDoZe.Infra.FeatureSabor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.FeaturePedido
{
    public class RepositorioPedido : RepositorioBase<Pedido>, IRepositorioPedido
    {
        public override string selecionarTodosSql => @"select * from pedido.tb_pedido";

        public override string selecionarPorIdSql => throw new NotImplementedException();

        public override string insertSql => @"INSERT INTO [pedido].[tb_pedido]
                                                   (dataPedido
                                                   ,ClienteId
                                                   ,FuncionarioId)
                                             VALUES
                                                   (@dataPedido
                                                   ,@ClienteId
                                                   ,@FuncionarioId)
                                                SELECT SCOPE_IDENTITY()";

        public override string editarSql => throw new NotImplementedException();

        public override string exclusaoSql => throw new NotImplementedException();

        public override void Inserir(Pedido registro)
        {
            var idPedido = 0;

            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(insertSql, connection);

                MapearObjeto(registro, command);

                var id = command.ExecuteScalar();

                idPedido = Decimal.ToInt32((decimal)id);
            }

            if(idPedido != 0)
            {
                registro.Id = idPedido;

                InserirAgregados(registro);
            }
        }

        public override List<Pedido> SelecionarTodos()
        {
            var listaItens = new List<Pedido>();

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

        public override Pedido ConverterValor(SqlDataReader reader)
        {
            return new MapeadorPedido().ConverterRegistro(reader);
        }

        public override void MapearCampoIdentificador(SqlCommand command, int id)
        {
            new MapeadorPedido().ConfigurarParametro("@id", id.ToString(), command);
        }

        public override void MapearObjeto(Pedido objeto, DbCommand comando)
        {
            new MapeadorPedido().ConfigurarParametros(objeto, comando);
        }
        
        #region métodos privados
        private void InserirAgregados(Pedido registro)
        {
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                // tb_pizza tb_sabor tb_produto
                connection.Open();

                using (SqlCommand comandoInserirPizza = new SqlCommand(@"INSERT INTO [pedido].[tb_pizza]
                                                    (PedidoId
                                                    ,tamanho
                                                    ,tipoBorda
                                                    ,valor)
                                             VALUES
                                                   (@PedidoId
                                                   ,@tamanho
                                                   ,@tipoBorda
                                                   ,@valor)
                                                SELECT SCOPE_IDENTITY()", connection))
                {
                    foreach (Pizza pizza in registro.Pizzas)
                    {
                        comandoInserirPizza.Parameters.Clear();
                        comandoInserirPizza.Parameters.AddWithValue("@PedidoId", registro.Id);
                        comandoInserirPizza.Parameters.AddWithValue("@tamanho", pizza.TamanhoPizza);
                        comandoInserirPizza.Parameters.AddWithValue("@tipoBorda", pizza.TipoBorda);
                        comandoInserirPizza.Parameters.AddWithValue("@valor", pizza.Valor);
                        var idPizza = comandoInserirPizza.ExecuteNonQuery();
                        if (idPizza != 0)
                            pizza.Id = idPizza;
                    }
                }
                using (SqlCommand comandoInserirSabores = new SqlCommand(@"UPDATE [pedido].[pizza_sabor]
                                                                       SET PizzaId = @PizzaId
                                                                          ,SaborId = @SaborId
                                                                        SELECT SCOPE_IDENTITY()", connection))
                {
                    foreach (Pizza pizza in registro.Pizzas)
                    {
                        foreach(Sabor sabor in pizza.sabores)
                        {
                            comandoInserirSabores.Parameters.Clear();
                            comandoInserirSabores.Parameters.AddWithValue("@PizzaId", pizza.Id);
                            comandoInserirSabores.Parameters.AddWithValue("@SaborId", sabor.id);
                            comandoInserirSabores.ExecuteNonQuery();
                        }
                    }
                }

                using (SqlCommand comandoInserirProdutos = new SqlCommand(@"INSERT INTO [pedido].[pedido_produto]
                                                                                       (PedidoId
                                                                                       ,ProdutoId)
                                                                                 VALUES
                                                                                       (@PedidoId
                                                                                       ,@ProdutoId)", connection))
                {
                    foreach (Produto produto in registro.Produtos)
                    {
                        comandoInserirProdutos.Parameters.Clear();
                        comandoInserirProdutos.Parameters.AddWithValue("@PedidoId", registro.Id);
                        comandoInserirProdutos.Parameters.AddWithValue("@ProdutoId", produto.id);
                        comandoInserirProdutos.ExecuteNonQuery();
                    }
                }
            }
        }

        public List<Pizza> SelecionarPizzarPorPedido(int id)
        {
            var listaItens = new List<Pizza>();

            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                    SqlCommand command = new SqlCommand(@"SELECT pizza.[id]
                                                              ,[PedidoId]
                                                              ,[tamanho]
                                                              ,[tipoBorda]
                                                              ,[valor]
                                                          FROM [pizzaria_ze].[pedido].[tb_pizza] as pizza
  
                                                          inner join [pizzaria_ze].[pedido].[tb_pedido] as pedido
                                                          on pedido.id = pizza.PedidoId", connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            var result = ConverterPizza(reader);
                            listaItens.Add(result);
                        }
                    }
                }
            }
            SelecionarSabores(listaItens);
            return listaItens;
        }

        private void SelecionarSabores(List<Pizza> listaItens)
        {
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(@"SELECT sabor.[id]
                                                            ,[nome]
                                                            ,[foto]
                                                            ,[categoria]
                                                            ,[tipo]
                                                        FROM [cadastro].[tb_sabor] sabor

                                                        join pedido.pizza_sabor as pizza_sabor
                                                        on pizza_sabor.SaborId = sabor.id

                                                        join pedido.tb_pizza as pizza
                                                        on pizza.id = pizza_sabor.PizzaId

                                                        where pizza.id = @id", connection);
                
                foreach (var item in listaItens)
                {
                    MapearCampoIdentificador(command, item.Id);
                    var listaSabores = new List<Sabor>();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.HasRows)
                            {
                                var result = new MapeadorSabor().ConverterRegistro(reader);
                                listaSabores.Add(result);
                            }
                        }
                    }
                }
            }
        }

        private Pizza ConverterPizza(SqlDataReader leitorRegistro)
        {
            Pizza pizza = new Pizza();
            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("PedidoId")))
            {
                int PedidoId = leitorRegistro.GetInt32(leitorRegistro.GetOrdinal("PedidoId"));
                pizza.PedidoId = PedidoId;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("TamanhoPizza")))
            {
                TamanhoPizza tamanhoPizza = Enum.Parse<TamanhoPizza>(leitorRegistro.GetString(leitorRegistro.GetOrdinal("TamanhoPizza")));
                pizza.TamanhoPizza = tamanhoPizza;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("TipoBorda")))
            {
                TipoBorda TipoBorda = Enum.Parse<TipoBorda>(leitorRegistro.GetString(leitorRegistro.GetOrdinal("TipoBorda")));
                pizza.TipoBorda = TipoBorda;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("valor")))
            {
                decimal valor = leitorRegistro.GetDecimal(leitorRegistro.GetOrdinal("valor"));
                pizza.Valor = valor;
            }


            return pizza;
        }
        #endregion
    }
}
