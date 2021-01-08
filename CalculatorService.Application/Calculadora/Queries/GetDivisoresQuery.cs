using System.Collections.Generic;
using CalculatorService.Application.Calculadora.Queries.Responses;
using CalculatorService.Domain.Core.Messaging;

namespace CalculatorService.Application.Calculadora.Queries
{
    public class GetDivisoresQuery : Query<DivisoresResponse>
    {
        public GetDivisoresQuery(int value) => Numero = value;
        public int Numero { get; set; }
    }
}