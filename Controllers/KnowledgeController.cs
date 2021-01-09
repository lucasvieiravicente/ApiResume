using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiResume.Domain.Models;
using ApiResume.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiResume.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KnowledgeController : ControllerBase
    {
        private readonly ILogger<KnowledgeController> _logger;
        private readonly IKnowledgeService _knowledgeService;

        public KnowledgeController(ILogger<KnowledgeController> logger, IKnowledgeService knowledgeService)
        {
            _logger = logger;
            _knowledgeService = knowledgeService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<KnowledgeResponse>> Get()
        {
            try
            {
                return Ok(_knowledgeService.GetAllKnowledge());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
