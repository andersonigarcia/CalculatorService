using CalculatorService.Application.Calculadora.Queries;
using CalculatorService.Application.Calculadora.Queries.Responses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CalculatorService.Application.Calculadora.Handlers
{
    public class DividersAndCousinsNumberQueryHandler : IRequestHandler<GetDividersAndCousinsNumberQuery, DividersAndCousinsNumberResponse>
    {
        public async Task<DividersAndCousinsNumberResponse> Handle(GetDividersAndCousinsNumberQuery request, CancellationToken cancellationToken)
        {
            var result = new DividersAndCousinsNumberResponse(request.Value);
            var divisores = new DividersResponse(request.Value);
            var primos = new CousinsResponse(divisores.Dividers);

            result.Dividers = divisores.Dividers;
            result.Cousins = primos.Cousins;

            return await Task.FromResult(result);
        }
    }
}