using CalculatorService.Application.Calculadora.Queries.Responses;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = Constants.Title;
            Console.WriteLine(Constants.SubTitle);
            Console.WriteLine(Constants.MessageInitial);

            var numero = Helper.ReadValue(Constants.InformNumber);

            var dividers = new DivisoresResponse(numero);
            var cousins = new PrimosResponse(dividers.Divisores);

            Console.WriteLine(string.Format(Constants.ResultNumberInput, numero));
            Console.WriteLine(string.Format(Constants.ResultNumberDividers, string.Join(" ", dividers.Divisores.ToArray())));
            Console.WriteLine(string.Format(Constants.ResultNumberCousins, string.Join(" ", cousins.Primos.ToArray())));

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
