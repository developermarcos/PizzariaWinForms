﻿using FluentResults;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Distribuiton.Compartilhado
{
    public abstract class ServicoBase<TDominio, TValidador> where TValidador : AbstractValidator<TDominio>, new()
    {
        protected virtual Result Validar(TDominio obj)
        {
            var validador = new TValidador();

            var resultadoValidacao = validador.Validate(obj);

            var erros = new List<Error>();

            foreach (var validationFailure in resultadoValidacao.Errors)
            {
                //Log.Logger.Warning(validationFailure.ErrorMessage);

                erros.Add(new Error(validationFailure.ErrorMessage));
            }

            if (erros.Any())
                return Result.Fail(erros);

            return Result.Ok();
        }
    }
}
