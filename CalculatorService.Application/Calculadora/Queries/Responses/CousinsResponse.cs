using System.Collections.Generic;

namespace CalculatorService.Application.Calculadora.Queries.Responses
{
    public class CousinsResponse
    {
        public CousinsResponse(List<int> values)
        {
            Numbers = values;
        }

        private List<int> Numbers { get; set; }
        public List<int> Cousins
        {
            get => GetNumberCousin();
        }

        private List<int> GetNumberCousin()
        {
            var cousins = new List<int>(Numbers.Count);
            foreach (var number in Numbers)
            {
                if (number > 0 && IsCousin(number))
                    cousins.Add(number);
            }
            return cousins;
        }

        private bool IsCousin(int number)
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}