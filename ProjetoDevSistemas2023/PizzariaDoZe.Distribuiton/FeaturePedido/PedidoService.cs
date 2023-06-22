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

        public Result<List<Pedido>> SelecionarTodos(bool incluirCliente = false, bool incluirFuncionario = false, bool incluirPizzas = false)
        {
            try
            {
                var result = _repositorio.SelecionarTodos();

                if (result is null)
                {
                    Result.Fail("Nenhum Pedido encotrando");
                }

                if (incluirCliente)
                {
                    result.ForEach(Pedido =>
                    {
                        Pedido.Cliente = repositorioCliente.SelecionarPorId(Pedido.ClienteId);
                    });
                }

                if (incluirFuncionario)
                {
                    result.ForEach(Pedido =>
                    {
                        Pedido.Funcionario = repositorioFuncionario.SelecionarPorId(Pedido.FuncionarioId);
                    });
                }

                if (incluirPizzas)
                {
                    result.ForEach(Pedido =>
                    {
                        Pedido.Pizzas = _repositorio.SelecionarPizzarPorPedido(Pedido.Id);
                    });
                }

                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar selecionar todos os Pedido");
            }
        }
        public Result<Pedido> SelecionarPorId(int id)
        {
            try
            {
                var result = _repositorio.SelecionarPorId(id);

                if (result is null)
                {
                    Result.Fail("Nenhum Pedido encotrando");
                }

                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar selecionar todos os Pedidos");
            }
        }
    }
}
