using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiGateway.Controller
{
    [Route("apiGateway/version")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        [HttpGet]
        [Produces("application/json")]
        public IActionResult Get()
        {

            return Ok("Version 1.0 Api Gateway PJ");
        }
    }
}
