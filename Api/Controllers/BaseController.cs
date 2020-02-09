using Api.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [ExceptionFilter]
    [Route("api/[controller]")]
    public abstract class BaseController : ControllerBase
    {
        protected static IActionResult CreateResult()
        {
            return new OkResult();
        }

        protected static IActionResult CreateObjectResult(object value)
        {
            return new OkObjectResult(value);
        }
    }
}
