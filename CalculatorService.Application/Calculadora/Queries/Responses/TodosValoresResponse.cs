using System.Collections.Generic;

namespace CalculatorService.Application.Calculadora.Queries.Responses
{
    public class TodosValoresResponse
    {
        public int Value;
        public List<int> Divisores { get; set; }
        public List<int> Primos { get; set; }

        public TodosValoresResponse(int value)
        {
            Value = value;
            Divisores = new List<int>();
            Primos = new List<int>();
        }
    }
}