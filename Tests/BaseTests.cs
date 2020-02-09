using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
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
    }
}
