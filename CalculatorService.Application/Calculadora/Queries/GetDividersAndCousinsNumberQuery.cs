using CalculatorService.Application.Calculadora.Queries.Responses;
using CalculatorService.Domain.Core.Messaging;

namespace CalculatorService.Application.Calculadora.Queries
{
    public class GetDividersAndCousinsNumberQuery : Query<DividersAndCousinsNumberResponse>
    {
        public GetDividersAndCousinsNumberQuery(int value) => Value = value;
        public int Value { get; set; }
    }
}