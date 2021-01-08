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
    public class CalculadoraController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CalculadoraController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("divisores")]
        public async Task<ActionResult<IEnumerable<DivisoresResponse>>> GetDivisores(int value)
        {
            var result = await _mediator.Send(new GetDivisoresQuery(value));
            return Ok(result);
        }

        [HttpGet("primos")]
        public async Task<ActionResult<PrimosResponse>> GetPrimos([FromQuery] List<int> values)
        {
            var response = await _mediator.Send(new GetPrimosQuery(values));
            return Ok(response);
        }

        [HttpGet("todosValores")]
        public async Task<ActionResult<TodosValoresResponse>> GetTodosValores(int value)
        {         
            var response = await _mediator.Send(new GetTodosValoresQuery(value));
            return Ok(response);
        }
    }
}