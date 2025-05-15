using System;
using System.Text;
using MathLibrary;

namespace MathLibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int a = 10;
            int b = 5;
            int c = 0;

            Console.WriteLine($"Add(10, 5): {MathOperations.Add(a, b)}");
            Console.WriteLine($"Subtract(10, 5): {MathOperations.Subtract(a, b)}");
            Console.WriteLine($"Divide(10, 5): {FormatOutput(MathOperations.Divide(a, b))}");
            Console.WriteLine($"Divide(10, 5): {FormatOutput(MathOperations.Divide(a, c))}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static string FormatOutput(double value)
        {
            return double.IsNaN(value) ? "NaN" : value.ToString();
        }
    }
}
