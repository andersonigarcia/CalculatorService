using System.Collections.Generic;

namespace CalculatorService.Application.Calculadora.Queries.Responses
{
    public class PrimosResponse
    {
        public PrimosResponse(List<int> values)
        {
            numeros = values;
        }

        private List<int> numeros { get; set; }
        public List<int> Primos
        {
            get => GetNumerosPrimos();
        }

        private List<int> GetNumerosPrimos()
        {
            var primos = new List<int>(numeros.Count);

            foreach (var numero in numeros)
            {
                if (ehPrimo(numero))
                    primos.Add(numero);
            }
            return primos;
        }

        private bool ehPrimo(int value)
        {
            for (int i = 2; i <= value / 2; i++)
            {
                if (value % i == 0)
                    return false;
            }
            return true;
        }
    }
}