using System;
using System.Numerics;

namespace ControlFlow
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // BigInteger is a data type that can store very large numbers
            // It is in the System.Numerics namespace
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Factorial of " + number + " is " + factorial);
        }
    }
}
