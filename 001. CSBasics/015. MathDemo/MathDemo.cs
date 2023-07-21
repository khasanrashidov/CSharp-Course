using System;

namespace CSBasics
{
    class MathDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MathDemo");
            // Math class is static and contains only static methods
            // Math class is in the System namespace
            // Math class contains methods for mathematical operations
            // Math class contains methods for constants like PI and E
            Console.WriteLine("Math.PI = " + Math.PI); // PI
            Console.WriteLine("Math.E = " + Math.E); // Euler's number
            Console.WriteLine("Math.Abs(-5) = " + Math.Abs(-5)); // absolute value
            Console.WriteLine("Math.Ceiling(5.2) = " + Math.Ceiling(5.2)); // round up
            Console.WriteLine("Math.Floor(5.2) = " + Math.Floor(5.2)); // round down
            Console.WriteLine("Math.Round(5.2) = " + Math.Round(5.2)); // round to nearest
            Console.WriteLine("Math.Round(5.5) = " + Math.Round(5.5));
            Console.WriteLine("Math.Round(5.7) = " + Math.Round(5.7));
            Console.WriteLine("Math.Max(5, 10) = " + Math.Max(5, 10)); // returns the larger of two numbers
            Console.WriteLine("Math.Min(5, 10) = " + Math.Min(5, 10)); // returns the smaller of two numbers
            Console.WriteLine("Math.Pow(5, 2) = " + Math.Pow(5, 2)); // 5 to the power of 2
            Console.WriteLine("Math.Sqrt(25) = " + Math.Sqrt(25)); // square root
            Console.WriteLine("Math.Log(25) = " + Math.Log(25)); // natural logarithm
            Console.WriteLine("Math.Log10(25) = " + Math.Log10(25)); // base 10 logarithm
            Console.WriteLine("Math.Exp(2) = " + Math.Exp(2)); // e to the power of 2
            
            Console.WriteLine();

            Console.WriteLine(Math.Round(2.5)); // 2, default is MidpointRounding.ToEven
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero)); // 3
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven)); // 2
            // MidpointRounding.ToEven is the default and it is used in banking

            Console.WriteLine();

            // Random class is in the System namespace
            // Random class is used to generate random numbers
            // Random class is not static and must be instantiated
            Random random = new Random();
            Console.WriteLine("random.Next() = " + random.Next()); // random integer
            Console.WriteLine("random.Next(10) = " + random.Next(10)); // random integer between 0 and 10
            Console.WriteLine("random.Next(10, 20) = " + random.Next(10, 20)); // random integer between 10 and 20
            Console.WriteLine("random.NextDouble() = " + random.NextDouble()); // random double between 0 and 1

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
