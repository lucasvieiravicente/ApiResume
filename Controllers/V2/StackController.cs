using ApiResume.Domain.Enums;
using ApiResume.Services.Interfaces.Stacks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ApiResume.Controllers.V2
{
    [ApiController]
    [ApiVersion("2")]
    [Route("[controller]/v{v:apiVersion}")]
    public class StackController : ControllerBase
    {
        private readonly IStackService _stackService;
        private readonly ILogger<StackController> _logger;

        public StackController(IStackService stackService, ILogger<StackController> logger)
        {
            _stackService = stackService;
            _logger = logger;
        }

        [HttpGet]
        [Route("{stackId}")]
        public async Task<IActionResult> GetStackPerStackId(StackGroup stackId)
        {
            try
            {
                return Ok(await _stackService.GetStackPerStackId(stackId));
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }

        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _stackService.GetAll());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }

        }
    }
}
