using CalculatorService.Application.Calculadora.Queries.Responses;
using CalculatorService.Domain.Core.Messaging;

namespace CalculatorService.Application.Calculadora.Queries
{
    public class GetTodosValoresQuery : Query<TodosValoresResponse>
    {
        public GetTodosValoresQuery(int value) => Value = value;
        public int Value { get; set; }
    }
}