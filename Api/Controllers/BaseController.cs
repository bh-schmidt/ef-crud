using Api.Attributes;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Api.Controllers
{
    [ApiController]
    [ExceptionFilter]
    [Route("api/[controller]")]
    public abstract class BaseController : ControllerBase
    {
        protected IActionResult CreateResult(object model)
        {
            return StatusCode(HttpStatusCode.OK.GetHashCode(), model);
        }
    }
}
