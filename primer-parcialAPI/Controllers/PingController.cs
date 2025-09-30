using Microsoft.AspNetCore.Mvc;

namespace primer_parcialAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("pong");
    }
}