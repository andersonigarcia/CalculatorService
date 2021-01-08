using System.Collections.Generic;
using CalculatorService.Application.Calculadora.Queries.Responses;
using CalculatorService.Domain.Core.Messaging;

namespace CalculatorService.Application.Calculadora.Queries
{
    public class GetDividersQuery : Query<DividersResponse>
    {
        public GetDividersQuery(int value) => Number = value;
        public int Number { get; set; }
    }
}