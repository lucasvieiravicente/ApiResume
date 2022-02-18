using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiResume.Controllers
{
    [ApiController]
    [Route("V{v:apiVersion}/[controller]")]
    public class DefaultController<T> : ControllerBase where T : class
    {
        protected readonly ILogger<T> _logger;
        public DefaultController(ILogger<T> logger)
        {
            _logger = logger;
        }
    }
}
