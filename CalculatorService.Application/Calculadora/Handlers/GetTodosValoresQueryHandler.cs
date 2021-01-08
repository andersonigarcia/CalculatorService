using CalculatorService.Application.Calculadora.Queries;
using CalculatorService.Application.Calculadora.Queries.Responses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CalculatorService.Application.Calculadora.Handlers
{
    public class GetTodosValoresQueryHandler : IRequestHandler<GetTodosValoresQuery, TodosValoresResponse>
    {
        public async Task<TodosValoresResponse> Handle(GetTodosValoresQuery request, CancellationToken cancellationToken)
        {
            var result = new TodosValoresResponse(request.Value);
            var divisores = new DivisoresResponse(request.Value);
            var primos = new PrimosResponse(divisores.Divisores);

            result.Divisores = divisores.Divisores;
            result.Primos = primos.Primos;

            return await Task.FromResult(result);
        }
    }
}