using ApiResume.Domain.Enums;
using ApiResume.Services.Interfaces.Stacks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ApiResume.Controllers.V2
{
    [ApiVersion("2")]
    public class StackController : DefaultController<StackController>
    {
        private readonly IStackService _stackService;
        public StackController(IStackService stackService, ILogger<StackController> logger) : base(logger)
        {
            _stackService = stackService;
        }

        [HttpGet]
        [Route("{stackId}")]
        public async Task<IActionResult> GetStackPerStackId(StackGroup stackId)
        {
            try
            {
                return Ok(await _stackService.GetStackByStackId(stackId));
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
