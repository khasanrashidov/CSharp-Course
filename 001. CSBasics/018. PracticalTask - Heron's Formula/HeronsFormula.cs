// Program to calculate the area of a triangle using Heron's formula.
using System;

namespace CSBasics
{
    class HeronsFormula
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to calculate the area of a triangle using Heron's formula.");
            Console.WriteLine("Enter the length of the first side:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the second side:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the third side:");
            double c = double.Parse(Console.ReadLine());

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine($"The area of the triangle is {area:f2}.");
            Console.ReadLine();
        }
    }
}