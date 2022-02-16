﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiResume.Domain.Models;
using ApiResume.Services.Interfaces;
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
        private readonly IKnowledgeService _knowledgeService;

        public KnowledgeController(ILogger<KnowledgeController> logger, IKnowledgeService knowledgeService)
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

        [HttpGet("Get")]
        public ActionResult<IEnumerable<Knowledge>> GetDirtyInfos()
        {
            try
            {
                return Ok(_knowledgeService.GetAllKnowledgeWithoutPhotos());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetPhoto")]
        public async Task<ActionResult<IEnumerable<byte[]>>> GetPhoto()
        {
            try
            {
                return Ok(await _knowledgeService.GetPhoto());
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