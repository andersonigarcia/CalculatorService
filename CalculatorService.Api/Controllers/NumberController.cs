using CalculatorService.Application.Calculadora.Queries;
using CalculatorService.Application.Calculadora.Queries.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CalculatorService.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumberController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NumberController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("decomposicao-divisores")]
        public async Task<ActionResult<IEnumerable<DividersResponse>>> GetDividersNumber(int value)
        {
            var result = await _mediator.Send(new GetDividersQuery(value));
            return Ok(result);
        }

        [HttpGet("numeros-primos")]
        public async Task<ActionResult<CousinsResponse>> GetCousinsNumber([FromQuery] List<int> values)
        {
            var response = await _mediator.Send(new GetCousinsQuery(values));
            return Ok(response);
        }

        [HttpGet("divisores-numeros-primos")]
        public async Task<ActionResult<DividersAndCousinsNumberResponse>> GetDividersAndCousinsNumber(int value)
        {         
            var response = await _mediator.Send(new GetDividersAndCousinsNumberQuery(value));
            return Ok(response);
        }
    }
}