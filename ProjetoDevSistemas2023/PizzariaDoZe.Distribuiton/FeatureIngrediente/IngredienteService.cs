using FluentResults;
using PizzariaDoZe.Distribuiton.Compartilhado;
using PizzariaDoZe.Domain.FeatureIngrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Distribuiton.FeatureIngrediente
{
    public class IngredienteService : ServicoBase<Ingrediente, ValidadorIngrediente>
    {
        private IRepositorioIngrediente _repositorio { get; set; }
        public IngredienteService(IRepositorioIngrediente repositorio)
        {
            _repositorio = repositorio;
        }

        public Result<Ingrediente> Editar(Ingrediente ingrediente)
        {
            throw new NotImplementedException();
        }

        public Result<Ingrediente> Excluir(Ingrediente ingrediente)
        {
            throw new NotImplementedException();
        }

        public Result<Ingrediente> Inserir(Ingrediente ingrediente)
        {
            
            Result resultado = Validar(ingrediente);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                _repositorio.Inserir(ingrediente);

                return Result.Ok(ingrediente);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar inserir o Ingrediente");
            }
        }

        public Result<List<Ingrediente>> SelecionarTodos()
        {
            try
            {
                var result = _repositorio.SelecionarTodos();

                if(result is null)
                {
                    Result.Fail("Nenhum ingrediente encotrando");
                }

                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail("Falha no sistema ao tentar selecionar todos os Ingrediente");
            }
        }
    }
}
