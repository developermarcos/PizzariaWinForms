using PizzariaDoZe.Domain.FeatureCliente;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Domain.FeaturePedido;
using PizzariaDoZe.Domain.FeatureProduto;
using PizzariaDoZe.Domain.FeatureSabor;
using PizzariaDoZe.Domain.FeatureValor;
using PizzariaDoZe.Infra.Compartilhado;
using PizzariaDoZe.Infra.FeatureIngrediente;
using PizzariaDoZe.Infra.FeatureProduto;
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
        public override string selecionarTodosSql => @"select * from pedido.tb_pedido where excluido = 0";

        public override string selecionarPorIdSql => @"select * from pedido.tb_pedido where id = @id";

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

        public override string exclusaoSql => @"UPDATE [pedido].[tb_pedido]  SET excluido = 1  WHERE id = @id";

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
                                                          on pedido.id = pizza.PedidoId
                            
                                                          where PedidoId = @id", connection);

                MapearCampoIdentificador(command, id);
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

        public List<Produto> SelecionarProdutosPorPedido(int pedidoId)
        {
            var listaProdutos = new List<Produto>();

            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(@"SELECT produto.[id]
                                                          ,[nome]
                                                          ,[tipo]
                                                          ,[medida_unitaria]
                                                          ,pedido_produto.produtoValor as valor
                                                      FROM [pizzaria_ze].[cadastro].[tb_produto] produto
  
                                                      join pedido.pedido_produto pedido_produto
                                                      on pedido_produto.ProdutoId = produto.id

                                                      join pedido.tb_pedido pedido
                                                      on pedido.id = pedido_produto.PedidoId

                                                      where pedido.id = @id", connection);


                MapearCampoIdentificador(command, pedidoId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            var produto = new MapeadorProduto().ConverterRegistro(reader);
                            listaProdutos.Add(produto);
                        }
                    }
                }

            }

            return listaProdutos;
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

                        var id = comandoInserirPizza.ExecuteScalar();

                        var idPizza = Decimal.ToInt32((decimal)id);

                        if (idPizza != 0)
                            pizza.Id = idPizza;
                    }
                }
                using (SqlCommand comandoInserirSabores = new SqlCommand(@"INSERT INTO [pedido].[pizza_sabor]
                                                                               (PizzaId
                                                                               ,SaborId)
                                                                         VALUES
                                                                               (@PizzaId
                                                                               ,@SaborId)
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
                                                                                       ,ProdutoId
                                                                                       ,produtoValor)       
                                                                                 VALUES
                                                                                       (@PedidoId
                                                                                       ,@ProdutoId
                                                                                       ,@produtoValor)", connection))
                {
                    foreach (Produto produto in registro.Produtos)
                    {
                        comandoInserirProdutos.Parameters.Clear();
                        comandoInserirProdutos.Parameters.AddWithValue("@PedidoId", registro.Id);
                        comandoInserirProdutos.Parameters.AddWithValue("@ProdutoId", produto.id);
                        comandoInserirProdutos.Parameters.AddWithValue("@produtoValor", produto.valor);
                        comandoInserirProdutos.ExecuteNonQuery();
                    }
                }
            }
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
                    command.Parameters.Clear();
                    MapearCampoIdentificador(command, item.Id);
                    var listaSabores = new List<Sabor>();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.HasRows)
                            {
                                var sabor = ConverterSabore(reader);
                                item.sabores.Add(sabor);
                            }
                        }
                    }
                }
            }
        }

        private List<Produto> SelecionarProdutos(int pedidoId)
        {
            var listaProdutos = new List<Produto>();

            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(@"SELECT produto.[id]
                                                          ,[nome]
                                                          ,[tipo]
                                                          ,[medida_unitaria]
                                                          ,pedido_produto.produtoValor as valor
                                                      FROM [pizzaria_ze].[cadastro].[tb_produto] produto
  
                                                      join pedido.pedido_produto pedido_produto
                                                      on pedido_produto.ProdutoId = produto.id

                                                      join pedido.tb_pedido pedido
                                                      on pedido.id = pedido_produto.PedidoId

                                                      where pedido.id = @id", connection);

                
                MapearCampoIdentificador(command, pedidoId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            var produto = new MapeadorProduto().ConverterRegistro(reader);
                            listaProdutos.Add(produto);
                        }
                    }
                }
                
            }

            return listaProdutos;
        }

        private Sabor ConverterSabore(SqlDataReader leitorRegistro)
        {
            var sabor = new Sabor();
            
            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("id")))
            {
                int id = leitorRegistro.GetInt32(leitorRegistro.GetOrdinal("id"));
                sabor.id = id;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("nome")))
            {
                string nome = leitorRegistro.GetString(leitorRegistro.GetOrdinal("nome"));
                sabor.nome = nome;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("foto")))
            {
                byte[] foto = leitorRegistro.GetFieldValue<byte[]>(leitorRegistro.GetOrdinal("foto"));
                sabor.foto = foto;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("categoria")))
            {
                CategoriaSabor categoria = Enum.Parse<CategoriaSabor>(leitorRegistro.GetString(leitorRegistro.GetOrdinal("categoria")));
                sabor.categoria = categoria;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("tipo")))
            {
                TipoSabor tipo = Enum.Parse<TipoSabor>(leitorRegistro.GetString(leitorRegistro.GetOrdinal("tipo")));
                sabor.tipo = tipo;
            }

            return sabor;
        }

        private Pizza ConverterPizza(SqlDataReader leitorRegistro)
        {
            Pizza pizza = new Pizza();

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("id")))
            {
                int id = leitorRegistro.GetInt32(leitorRegistro.GetOrdinal("id"));
                pizza.Id = id;
            }
            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("PedidoId")))
            {
                int PedidoId = leitorRegistro.GetInt32(leitorRegistro.GetOrdinal("PedidoId"));
                pizza.PedidoId = PedidoId;
            }

            if (!leitorRegistro.IsDBNull(leitorRegistro.GetOrdinal("Tamanho")))
            {
                TamanhoPizza tamanhoPizza = Enum.Parse<TamanhoPizza>(leitorRegistro.GetString(leitorRegistro.GetOrdinal("Tamanho")));
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
