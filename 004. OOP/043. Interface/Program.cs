using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // We cannot create an instance of an interface
            // But we can create an instance of a class that implements an interface
            IBaseCollection collection = new BaseList(20);
            collection.Add("Hello");
            collection.Add("World");
            collection.Remove("World");
            collection.Add("!");
            collection.Add(1);

            Console.WriteLine();

            // We can call the default implementation of the Clear method
            collection.Clear();

            // We can call the static Print method
            IBaseCollection.Print();

            Console.WriteLine();

            // We can call the AddRange extension method
            // We can call the extension method on the interface
            // because the extension method is defined in the same namespace as the interface
            collection.AddRange(new object[] { "Hello", "World", "!" });
            collection.Remove("!");

            Console.WriteLine();

            List<object> objects = new List<object>() { "This", "is", "a", "list", "of", "objects" };
            collection.AddRange(objects);

            Console.WriteLine();

            // count how much full is out of the default capacity
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Count: {collection.Count}");
            Console.WriteLine($"Capacity: {collection.Capacity}");
            Console.WriteLine($"Full: {collection.Count / (double)collection.Capacity * 100 : 0.00} %");
            Console.ResetColor();
            
        }
    }
}