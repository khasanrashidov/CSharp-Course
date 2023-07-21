using System;

namespace OOP
{
    public abstract class Shape // abstract classs
    {
        // Abstract keyword is used to declare an abstract method
        // Abstract methods do not have a body
        // To make methods abstract, the class must be abstract as well
        // Abstract methods are used to declare a method that must be implemented in a derived class
        // Abstract classes cannot be instantiated

        // Abstract class has a contract with derived classes to implement the abstract methods

        public Shape()
        {
            Console.WriteLine("Shape was created.");
        }

        public abstract void Draw();

        public abstract double Area();

        public abstract double Perimeter();

        // Derived classes must implement the abstract methods

        // Virtual methods can have a body
        // But abstract methods cannot have a body
        // Virtual methods can be overridden in derived classes (not necessary to override)
        // Abstract methods must be implemented in derived classes (must be overridden)

        // We can declare normal methods, virtual methods and abstract methods in an abstract class


        // virtual - allows the method to be overridden by the derived class
        // override - indicates the method is overriding the method from the base class
    }

    public class Rectangle : Shape
    {
        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

            Console.WriteLine("Rectangle was created.");
        }
        public override double Area()
        {
            return width * height;
        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle was drawn.");
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        public override double Perimeter()
        {
            return 2 * (width + height);
        }
    }

    public class Triangle : Shape
    {
        private readonly double side1;
        private readonly double side2;
        private readonly double side3;

        public Triangle(double side1, double side2, double side3) : base() // not necessary to call base() if there is no parameter
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;

            Console.WriteLine("Triangle was created.");
        }

        public override double Area()
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public override void Draw()
        {
            Console.WriteLine("Triangle was drawn.");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < side1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }
    }

    public class Circle : Shape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;

            Console.WriteLine("Circle was created.");
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Circle was drawn.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 2 * radius; i++)
            {
                for (int j = 0; j < 2 * radius; j++)
                {
                    if ((i - radius) * (i - radius) + (j - radius) * (j - radius) <= radius * radius)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
