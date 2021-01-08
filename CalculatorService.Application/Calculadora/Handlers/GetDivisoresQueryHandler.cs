using CalculatorService.Application.Calculadora.Queries;
using CalculatorService.Application.Calculadora.Queries.Responses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CalculatorService.Application.Calculadora.Handlers
{
    public class GetDivisoresQueryHandler : IRequestHandler<GetDivisoresQuery, DivisoresResponse>
    {
        public async Task<DivisoresResponse> Handle(GetDivisoresQuery request, CancellationToken cancellationToken)
        {
            var result = new DivisoresResponse(request.Numero);
            return await Task.FromResult(result);
        }
    }
}
