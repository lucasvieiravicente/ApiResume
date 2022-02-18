using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiResume.Domain.Models;
using ApiResume.Domain.Responses;
using ApiResume.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiResume.Controllers.V1
{
    [ApiController]
    [ApiVersion("1", Deprecated = true)]
    [Route("[controller]/V{v:apiVersion}")]
    public class KnowledgeController : ControllerBase
    {
        private readonly ILogger<KnowledgeController> _logger;
        private readonly IKnowledgeServiceV1 _knowledgeService;

        public KnowledgeController(ILogger<KnowledgeController> logger, IKnowledgeServiceV1 knowledgeService)
        {
            _logger = logger;
            _knowledgeService = knowledgeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<KnowledgeResponse>>> Get()
        {
            try
            {
                return Ok(await _knowledgeService.GetAllKnowledge());
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetDate")]
        public ActionResult<DateTime> GetDate()
        {
            try
            {
                return Ok(DateTime.Now);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
