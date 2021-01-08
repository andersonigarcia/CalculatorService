using CalculatorService.Application.Calculadora.Queries.Responses;
using CalculatorService.Domain.Core.Messaging;
using System.Collections.Generic;

namespace CalculatorService.Application.Calculadora.Queries
{
    public class GetCousinsQuery : Query<CousinsResponse>
    {
        public GetCousinsQuery(List<int> values) => Values = values;
        public List<int> Values { get; set; }
    }
}