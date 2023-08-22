using Microsoft.AspNetCore.Mvc;

namespace TestWebApi_HangProblem.Controllers
{
    [ApiController]
    [Route("Ping")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "pong" + DateTime.Now;
        }
    }
}
