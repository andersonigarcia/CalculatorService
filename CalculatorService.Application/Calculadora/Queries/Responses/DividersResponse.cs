using System.Collections.Generic;

namespace CalculatorService.Application.Calculadora.Queries.Responses
{
    public class DividersResponse
    {
        public DividersResponse(int value)
        {
            Number = value;
        }

        private readonly int Number;
        public List<int> Dividers
        {
            get => DecomposeInDividers();
        }
        private List<int> DecomposeInDividers()
        {
            var dividers = new List<int>();
            for (int i = 1; i <= Number; i++)
            {
                if ((Number % i) == 0)
                    dividers.Add(i);
            }
            return dividers;
        }
    }
}