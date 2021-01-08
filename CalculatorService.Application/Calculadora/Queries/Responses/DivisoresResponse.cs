using System.Collections.Generic;

namespace CalculatorService.Application.Calculadora.Queries.Responses
{
    public class DivisoresResponse
    {
        public DivisoresResponse(int value)
        {
            numero = value;
        }

        public int numero;        

        public List<int> Divisores
        {
            get => CalcularDivisores();
        }
        
        private List<int> CalcularDivisores()
        {
            var divisores = new List<int>();

            for (int i = 1; i <= numero; i++)
            {
                if ((numero % i) == 0)
                    divisores.Add(i);
            }
            return divisores;
        }
    }
}