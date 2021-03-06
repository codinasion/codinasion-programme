// Write a programme to find cube of a number
using System;

namespace Codinasion.Programme
{
    internal class CubeNumber
    {
        static void Main()
        {
            var input = GetInput();
            var output = Cube(input);
            Console.WriteLine($"\n{input} cubed is {output}");
        }

        private static double GetInput()
        {
            double? input = null;
            Console.Write("Please input your number to find the cube of : ");
            while (input == null)
            {
                var consoleInput = Console.ReadLine();
                if (double.TryParse(consoleInput, out double parsedInput))
                {
                    input = parsedInput;
                }
                else
                {
                    Console.WriteLine($"Unable to parse input {consoleInput}");
                }
            }
            return input.Value;
        }

        private static double Cube(double input)
        {
            var cubedNumber = Math.Pow(input, 3);
            return cubedNumber;
        }
    }
}
