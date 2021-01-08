using CalculatorService.Application.Calculadora.Queries;
using CalculatorService.Application.Calculadora.Queries.Responses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CalculatorService.Application.Calculadora.Handlers
{
    public class GetPrimosQueryHandler : IRequestHandler<GetPrimosQuery, PrimosResponse>
    {
        public async Task<PrimosResponse> Handle(GetPrimosQuery request, CancellationToken cancellationToken)
        {
            var result = new PrimosResponse(request.Values);
            return await Task.FromResult(result);
        }
    }
}