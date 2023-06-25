using FluentResults;
using PizzariaDoZe.Distribuiton.Compartilhado;
using PizzariaDoZe.Domain.FeatureCliente;
using PizzariaDoZe.Domain.FeatureFuncionario;
using PizzariaDoZe.Domain.FeatureIngrediente;
using PizzariaDoZe.Domain.FeaturePedido;
using PizzariaDoZe.Domain.FeatureProduto;
using PizzariaDoZe.Domain.FeatureSabor;

namespace PizzariaDoZe.Distribuiton.FeaturePedido
{
    public class PedidoService : ServicoBase<Pedido, ValidadorPedido>
    {
        private IRepositorioFuncionario repositorioFuncionario;
        private IRepositorioCliente repositorioCliente;
        private IRepositorioSabor repositorioSabor;
        private IRepositorioIngrediente repositorioingrediente;
        private IRepositorioProduto repositorioProduto;
        private IRepositorioPedido _repositorio { get; set; }

        public PedidoService(IRepositorioPedido repositorio, IRepositorioFuncionario repositorioFuncionario, IRepositorioCliente repositorioCliente, IRepositorioSabor repositorioSabor, IRepositorioIngrediente repositorioingrediente, IRepositorioProduto repositorioProduto)
        {
            this._repositorio = repositorio;
            this.repositorioFuncionario = repositorioFuncionario;
            this.repositorioCliente = repositorioCliente;
            this.repositorioSabor = repositorioSabor;
            this.repositorioingrediente = repositorioingrediente;
            this.repositorioProduto = repositorioProduto;
        }

        public Result<Pedido> Editar(Pedido Pedido)
        {
            Result resultado = Validar(Pedido);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                _repositorio.Editar(Pedido);

                return Result.Ok(Pedido);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar editar o Pedido");
            }
        }

        public Result<Pedido> Excluir(Pedido Pedido)
        {

            try
            {
                _repositorio.Excluir(Pedido);

                return Result.Ok(Pedido);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar excluir o Pedido");
            }
        }

        public Result<Pedido> Inserir(Pedido Pedido)
        {

            Result resultado = Validar(Pedido);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                _repositorio.Inserir(Pedido);

                return Result.Ok(Pedido);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar inserir o Pedido");
            }
        }

        public Result<List<Pedido>> SelecionarTodos(bool incluirDependencias)
        {
            try
            {
                var result = _repositorio.SelecionarTodos();

                if (result is null)
                {
                    Result.Fail("Nenhum Pedido encotrando");
                }

                if(incluirDependencias)
                    result.ForEach(Pedido =>
                    {
                        IncluirClientePedido(Pedido)
                        .Bind(IncluirFuncionarioPedido)
                        .Bind(IncluirPizzasPedido)
                        .Bind(IncluirProdutosPedido);
                    });

                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar selecionar todos os Pedido");
            }
        }
        public Result<Pedido> SelecionarPorId(int id, bool incluirDependencas = false)
        {
            try
            {
                var result = _repositorio.SelecionarPorId(id);

                if (result is null)
                {
                    Result.Fail("Nenhum Pedido encotrando");
                }

                if (incluirDependencas)
                    IncluirClientePedido(result)
                        .Bind(IncluirFuncionarioPedido)
                        .Bind(IncluirPizzasPedido)
                        .Bind(IncluirProdutosPedido);


                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar selecionar todos os Pedidos");
            }
        }

        #region métodos privados
        public Pedido IncluirClientePedido(Pedido pedido)
        {
            pedido.Cliente = repositorioCliente.SelecionarPorId(pedido.ClienteId);

            return pedido;
        }
        public Pedido IncluirFuncionarioPedido(Pedido pedido)
        {
            pedido.Funcionario = repositorioFuncionario.SelecionarPorId(pedido.FuncionarioId);

            return pedido;
        }
        public Pedido IncluirPizzasPedido(Pedido pedido)
        {
            pedido.Pizzas = _repositorio.SelecionarPizzarPorPedido(pedido.Id);
            return pedido;
        }
        public Pedido IncluirProdutosPedido(Pedido pedido)
        {
            pedido.Produtos = _repositorio.SelecionarProdutosPorPedido(pedido.Id);
            return pedido;
        }
        #endregion
    }
}
