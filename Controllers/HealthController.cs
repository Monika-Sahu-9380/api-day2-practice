using Microsoft.AspNetCore.Mvc;
using Day2ApiPractice.Services;

namespace Day2ApiPractice.Controllers
{
    [ApiController]
    [Route("api/health")]
    public class HealthController : ControllerBase
    {
        private readonly IHealthService _healthService;

        public HealthController(IHealthService healthService)
        {
            _healthService = healthService;
        }
    
        [HttpGet]
        public IActionResult CheckHealth()
        {
            var result = _healthService.GetHealthStatus();
            return Ok(result);
        }

        [HttpGet("status")]
        public IActionResult Status()
        {
            return Ok("Healthy");
        }        
    }
}