using CalculatorService.Application.Calculadora.Queries;
using CalculatorService.Application.Calculadora.Queries.Responses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CalculatorService.Application.Calculadora.Handlers
{
    public class GetDivisoresQueryHandler : IRequestHandler<GetDividersQuery, DividersResponse>
    {
        public async Task<DividersResponse> Handle(GetDividersQuery request, CancellationToken cancellationToken)
        {
            var result = new DividersResponse(request.Number);
            return await Task.FromResult(result);
        }
    }
}
