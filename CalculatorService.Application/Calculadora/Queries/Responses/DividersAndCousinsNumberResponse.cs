using System.Collections.Generic;

namespace CalculatorService.Application.Calculadora.Queries.Responses
{
    public class DividersAndCousinsNumberResponse
    {
        public int Value;
        public List<int> Dividers { get; set; }
        public List<int> Cousins { get; set; }

        public DividersAndCousinsNumberResponse(int value)
        {
            Value = value;
            Dividers = new List<int>();
            Cousins = new List<int>();
        }
    }
}