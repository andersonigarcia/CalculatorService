using System;

namespace CalculatorConsole
{
    public static class Helper
    {
        public static int ReadValue(string description, string errorMessage = Constants.ValueError)
        {
            int number = 0;
            bool repet = true;

            Console.Write(description);
            while (repet)
            {
                repet = !int.TryParse(Console.ReadLine(), out number) || number < 0;
                if (repet) Console.WriteLine(errorMessage);
            }

            return number;
        }
    }
}
