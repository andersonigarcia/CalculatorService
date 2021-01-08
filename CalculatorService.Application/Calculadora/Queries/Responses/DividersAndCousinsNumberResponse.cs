using Newtonsoft.Json;
using System.Collections.Generic;

namespace CalculatorService.Application.Calculadora.Queries.Responses
{
    public class DividersAndCousinsNumberResponse
    {
        public DividersAndCousinsNumberResponse(int value)
        {
            Value = value;
            Dividers = new List<int>();
            Cousins = new List<int>();
        }

        [JsonProperty("Numero")]
        public int Value;

        [JsonProperty("Divisores")]
        public List<int> Dividers { get; set; }

        [JsonProperty("Primos")]
        public List<int> Cousins { get; set; }       
    }
}