using System;

namespace PracticalTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex(1, 2);
            Complex complex2 = new Complex(3, 4);
            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result);
            Console.WriteLine(result.Equals(complex1));

            Complex result2 = complex1.Minus(complex2);
            Console.WriteLine(result2);
            Console.WriteLine(result2.Equals(complex1));

            Console.WriteLine(complex1.GetHashCode());
            Console.WriteLine(complex2.GetHashCode());
            Console.WriteLine(result.GetHashCode());
            Console.WriteLine(result2.GetHashCode());

            Console.ReadKey();
            
        }
    }
}
