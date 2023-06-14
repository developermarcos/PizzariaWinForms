using FluentResults;
using PizzariaDoZe.Distribuiton.Compartilhado;
using PizzariaDoZe.Domain.FeatureCliente;

namespace PizzariaDoZe.Distribuiton.FeatureCliente
{
    public class ClienteService : ServicoBase<Cliente, ValidadorCliente>
    {
        private IRepositorioCliente repositorioCliente;

        public ClienteService(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public Result<Cliente> Editar(Cliente Cliente)
        {
            Result resultado = Validar(Cliente);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                repositorioCliente.Editar(Cliente);

                return Result.Ok(Cliente);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar editar o Cliente");
            }
        }

        public Result<Cliente> Excluir(Cliente Cliente)
        {

            try
            {
                repositorioCliente.Excluir(Cliente);

                return Result.Ok(Cliente);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar excluir o Cliente");
            }
        }

        public Result<Cliente> Inserir(Cliente Cliente)
        {

            Result resultado = Validar(Cliente);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                repositorioCliente.Inserir(Cliente);

                return Result.Ok(Cliente);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar inserir o Cliente");
            }
        }

        public Result<List<Cliente>> SelecionarTodos()
        {
            try
            {
                var result = repositorioCliente.SelecionarTodos();

                if (result is null)
                {
                    Result.Fail("Nenhum Cliente encotrando");
                }

                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar selecionar todos os Clientes");
            }
        }
        public Result<Cliente> SelecionarPorId(int id)
        {
            try
            {
                var result = repositorioCliente.SelecionarPorId(id);

                if (result is null)
                {
                    Result.Fail("Nenhum Cliente encotrando");
                }

                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar selecionar o cliente");
            }
        }
    }
}
