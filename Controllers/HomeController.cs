using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practical_16.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // GET: api/<HomeController>
        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Hello World");
            return Ok("Hello World");
        }

        // GET api/<HomeController>/5
        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            _logger.LogInformation($"Hello {name}");
            return Ok($"Hello {name}");
        }        
    }
}
