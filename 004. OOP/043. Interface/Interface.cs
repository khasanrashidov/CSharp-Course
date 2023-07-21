using System;

namespace OOP
{
    public interface IBaseCollection // by default, interfaces are public
    {
        // Interfaces vs Abstract Classes
        // Interfaces cannot have fields, constructors, destructors, and static members
        // Interface members cannot have access modifiers as they are public by default
        // Interface members (methods, properties, events, indexers) cannot have implementation details (no body)
        // Interfaces cannot be instantiated (cannot create an instance of an interface)
        // Multiple inheritance is allowed in interfaces
        // The main difference between interfaces and abstract classes is that
        // interfaces cannot have implementation details (no body)
        // and abstract classes can have implementation details (can have a body)
        // Interfaces should be fully implemented in derived classes.

        // No need to use override keyword when implementing interface members
        // But in abstract classes, we need to use override keyword when implementing abstract members

        // Abstract classes - "is a" relationship (a class can only inherit from one abstract class)
        // Interfaces - "can do" relationship (a class can implement multiple interfaces)
        void Add(object obj);
        void Remove(object obj);

        // Default implementation is allowed in interfaces (C# 8.0)
        // No need to override the default implementation in derived classes
        public void Clear()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Clearing...");
            Console.ResetColor();
        }

        // Static members are allowed in interfaces (C# 8.0)
        public static void Print()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Printing...");
            Console.ResetColor();
        }

        // Count and capacity properties
        int Count { get; }
        int Capacity { get; }
        
    }

    // Extension methods
    // Extension methods are static methods of a static class
    // Extension methods are defined in a static class
    // The first parameter of an extension method must be preceded by the this keyword
    // and its type must be the type that we want to extend (in this case, IBaseCollection)
    // Extension methods are in the same namespace as the type that we want to extend
    // Extension methods cannot be overridden (cannot be virtual, abstract, or override)
    public static class BaseCollectionExtensions
    {
        public static void AddRange(this IBaseCollection collection, IEnumerable<object> objects)
        {
            // IEnumerable is a generic interface that represents a collection of objects
            // that can be enumerated (looped through)
            // It allows us to iterate through a collection of objects (e.g. an array, a list, etc.)
            // using the foreach loop
            foreach (var item in objects)
            {
                collection.Add(item);
            }
        }
    }

    public class BaseList : IBaseCollection
    {
        private object[]? items;
        private int count = 0;

        public BaseList(int initialCapacity)
        {
            items = new object[initialCapacity];
        }

        public void Add(object obj)
        {
            // Dereference of a possibly null reference.
            if (items == null) return;
            items[count] = obj;
            count++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Added {obj}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Count: {count}");
            Console.ResetColor();
        }

        public void Remove(object obj)
        {
            // Dereference of a possibly null reference.
            if (items == null) return;
            items[count] = null;
            count--;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Removed {obj}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Count: {count}");
            Console.ResetColor();
        }

        public int Count => count; // expression-bodied property
        // => is called the lambda operator and is used to define expression-bodied members
        // public int Count
        // {
        //     get
        //     {
        //         return count;
        //     }
        // }

        public int Capacity => items?.Length ?? 0; // expression-bodied property
        // public int Capacity
        // {
        //     get
        //     {
        //         return items?.Length ?? 0; // null-coalescing operator (??)
        //     }
        // }
        // // null-coalescing operator (??) - returns the left-hand operand if it is not null; otherwise, returns the right-hand operand
        // // null-conditional operator (?.) - returns the value of the operand if it is not null; otherwise, returns null
        // expansion of the code above
        // public int Capacity
        // {
        //     get
        //     {
        //         if (items != null)
        //         {
        //             return items.Length;
        //         }
        //         else
        //         {
        //             return 0;
        //         }
        //     }
        // }
    }
}