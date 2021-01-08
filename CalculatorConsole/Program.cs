using CalculatorService.Application.Calculadora.Queries.Responses;
using System;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = Constants.Title;
            Console.WriteLine(Constants.SubTitle);

            var number = Helper.ReadValue(Constants.InformNumber);

            var dividers = new DividersResponse(number);
            var cousins = new CousinsResponse(dividers.Dividers);

            Console.WriteLine(string.Format(Constants.ResultNumberInput, number));
            Console.WriteLine(string.Format(Constants.ResultNumberDividers, string.Join(" ", dividers.Dividers.ToArray())));
            Console.WriteLine(string.Format(Constants.ResultNumberCousins, string.Join(" ", cousins.Cousins.ToArray())));

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
