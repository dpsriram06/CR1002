using Microsoft.AspNetCore.Mvc;

namespace CR1002.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {

        private readonly IConfiguration _configuration;

        public HealthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetHealth()
        {
            return Ok(new {
                Status = "200",
                ApplicationName = _configuration["ApplicationSettings:ApplicationName"],
                SupportEmailId = _configuration["ApplicationSettings:SupportEmailId"],
                StudentBaseURl = _configuration["ApplicationSettings:StudentBaseURl"]

            });
        }
    }

}

