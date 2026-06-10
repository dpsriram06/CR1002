using Microsoft.AspNetCore.Mvc;

namespace CR1002.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHealth()
        {
            return Ok(new {
                StatusCode = "API is healthy",
                Message = "The API is running smoothly and all systems are operational."
            });
        }
    }

}

