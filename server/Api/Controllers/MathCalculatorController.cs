using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Api.Errors;
using Core.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/math-calculator")]
    public class MathCalculatorController : ControllerBase
    {
        private readonly IMathResolver mathResolver;

        public MathCalculatorController(IMathResolver mathResolver)
        {
            this.mathResolver = mathResolver;
        }

        [HttpGet()]
        public async Task<ActionResult<MathResultDto>> GetAsync([FromQuery] MathQuestionDto mathQuestionDto)
        {
            try
            {
                return await mathResolver.ResolveMathQuestionAsync(mathQuestionDto);
            }
            catch (ArgumentException ex) // to catch dived by 0 or unknown operator and etc...
            {
                return BadRequest(new ApiResponse(400, ex.Message));
            }
        }
    }
}