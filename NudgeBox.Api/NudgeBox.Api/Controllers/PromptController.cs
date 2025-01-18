using Microsoft.AspNetCore.Mvc;

namespace NudgeBox.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PromptController : ControllerBase
    {
        private readonly ILogger<PromptController> _logger;

        public PromptController(ILogger<PromptController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("this is a prompt!");
        }

    }
}
