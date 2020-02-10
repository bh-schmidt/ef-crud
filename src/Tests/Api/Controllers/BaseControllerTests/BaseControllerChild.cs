using Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Tests.Api.Controllers.BaseControllerTests
{
    class BaseControllerChild : BaseController
    {
        public IActionResult ChildCreateResult()
        {
            return CreateResult();
        }

        public IActionResult ChildCreateObjectResult(object value)
        {
            return CreateObjectResult(value);
        }
    }
}
