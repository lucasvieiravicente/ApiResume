using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiResume.Domain.Models;
using ApiResume.Domain.Responses;
using ApiResume.Services.Interfaces.Knowledges;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiResume.Controllers.V2
{
    [ApiController]
    [ApiVersion("2")]
    [Route("[controller]/V{v:apiVersion}")]
    public class KnowledgeController : ControllerBase
    {
        private readonly ILogger<KnowledgeController> _logger;
        private readonly IKnowledgeServiceV2 _knowledgeService;

        public KnowledgeController(ILogger<KnowledgeController> logger, IKnowledgeServiceV2 knowledgeService)
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

        [HttpGet("{id}")]
        public async Task<ActionResult<Knowledge>> GetKnowledge([FromRoute] string id)
        {
            try
            {
                return Ok(await _knowledgeService.GetKnowledge(id));
            }
            catch (Exception ex)
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
