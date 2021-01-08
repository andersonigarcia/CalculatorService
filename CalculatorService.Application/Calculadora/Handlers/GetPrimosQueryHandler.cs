using CalculatorService.Application.Calculadora.Queries;
using CalculatorService.Application.Calculadora.Queries.Responses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CalculatorService.Application.Calculadora.Handlers
{
    public class GetPrimosQueryHandler : IRequestHandler<GetCousinsQuery, CousinsResponse>
    {
        public async Task<CousinsResponse> Handle(GetCousinsQuery request, CancellationToken cancellationToken)
        {
            var result = new CousinsResponse(request.Values);
            return await Task.FromResult(result);
        }
    }
}