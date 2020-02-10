using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Linq;
using Utils.Extensions;

namespace Tests
{
    [TestFixture]
    public abstract class BaseTests
    {
        protected static object? ObterObjeto(IActionResult actionResult)
        {
            if (actionResult is OkObjectResult)
                return actionResult.CastTo<OkObjectResult>().Value;

            return null;
        }

        protected static void ContemErro(ValidationResult resultado, string? codigoDoErro = null)
        {
            if (codigoDoErro.IsNull() && !resultado.Errors.Any())
                throw new AssertionException($"A validação deveria retornar erros.");

            if (!resultado.Errors.Any(r => r.ErrorCode == codigoDoErro))
                throw new AssertionException($"A validação deveria retornar o erro '{codigoDoErro}'.");
        }

        protected static void NaoContemErro(ValidationResult resultado, string? codigoDoErro = null)
        {
            if(codigoDoErro.IsNull() && resultado.Errors.Any())
                throw new AssertionException($"A validação não deveria retornar erros.");

            if (resultado.Errors.Any(r => r.ErrorCode == codigoDoErro))
                throw new AssertionException($"A validação não deveria retornar o erro '{codigoDoErro}'.");
        }

        protected static ValidationResult ValidResult() => new ValidationResult();
        protected static ValidationResult InvalidResult() => 
            new ValidationResult(
                new ValidationFailure[] {
                    new ValidationFailure("FakeProperty", "FakeError")
                });
    }
}
