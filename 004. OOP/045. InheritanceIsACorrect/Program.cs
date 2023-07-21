using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape rectangle = new Rectangle { Width = 10, Height = 5 }; // () is optional in object initialization syntax
            IShape square = new Square() { Side = 10 }; // () is optional in object initialization syntax
            IShape circle = new Circle() { Radius = 10 }; // () is optional in object initialization syntax

            Console.WriteLine($"Rectangle area: {rectangle.Area()}");
            Console.WriteLine($"Square area: {square.Area()}");
            Console.WriteLine($"Circle area: {circle.Area()}");

            Console.ReadKey(); // Keep the console window open in debug mode.
        }
    }
}