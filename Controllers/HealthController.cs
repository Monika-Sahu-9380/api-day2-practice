using Microsoft.AspNetCore.Mvc;

namespace Day2ApiPractice.Controllers
{
    [ApiController]
    [Route("api/health")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult CheckHealth()
        {
            return Ok("API is running fine");
        }
    }
}