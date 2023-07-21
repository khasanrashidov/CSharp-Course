using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // We cannot create an instance of an abstract class
            // Shape shape = new Shape();
            // We can create an array of an abstract class
            Shape[] shapes = new Shape[3];
            // by default, shapes[0] contains null
            shapes[0] = new Rectangle(10, 5);
            shapes[1] = new Triangle(10, 20, 30);
            shapes[2] = new Circle(10);
            
            Console.WriteLine("=====================================");
            foreach (Shape shape in shapes)
            {
                shape.Draw();
                Console.WriteLine("Area: " + shape.Area());
                Console.WriteLine("Perimeter: " + shape.Perimeter());
                Console.WriteLine("=====================================");
            }

            // When we create an object of Rectangle, Triangle or Circle, 
            // the constructor of the base class is called first
            // and then the constructor of the derived class is called.
            // The constructor of the base class is called implicitly
            // and the constructor of the derived class is called explicitly.

            // The constructor of the base class is called before the constructor of the derived class.
            
            // Concept of Polymorphism is based on the concept of inheritance.
        }
    }
}