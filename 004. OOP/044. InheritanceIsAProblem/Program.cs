using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object initialization syntax.
            // () are optional when using object initialization syntax.
            Rectangle rectangle = new Rectangle { Width = 10, Height = 5 };
            int rectangleArea = CalculateArea.Area(rectangle);
            Console.WriteLine("Rectangle area: {0}", rectangleArea);

            Rectangle square = new Square { Width = 10, Height = 10 };
            int squareArea = CalculateArea.Area(square);
            Console.WriteLine("Square area: {0}", squareArea);

            // Problem
            // Square is a particular case of Rectangle.
            // But we should not inherit from Rectangle.
            // Here "is a" relationship is not correct.

        }
    }
}