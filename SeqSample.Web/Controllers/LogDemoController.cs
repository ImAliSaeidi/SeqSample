using Microsoft.AspNetCore.Mvc;

namespace SeqSample.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogDemoController : ControllerBase
    {
        private readonly ILogger<LogDemoController> logger;

        public LogDemoController(ILogger<LogDemoController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public string Ping()
        {
            logger.LogInformation("Im In Ping");
            throw new InvalidOperationException("This Is Exception");
        }

        [HttpGet("{id}")]
        public string Add(int id)
        {
            logger.LogInformation("This Is {Id}", id);
            return "1";
        }
    }
}