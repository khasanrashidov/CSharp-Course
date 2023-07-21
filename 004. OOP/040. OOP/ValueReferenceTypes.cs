using System;

namespace OOP
{
    public struct StructReference
    {
        public int x;
        public int y;

        public PointReference PointReference;
        public readonly PointReference PointReference2;
        // public const PointReference PointReference3;

        public StructReference(int x, int y)
        {
            this.x = x;
            this.y = y;
            PointReference = new PointReference();
            // We can initialize readonly fields in the constructor.
            PointReference2 = new PointReference();
        }

        public void Do()
        {
            // A readonly field cannot be assigned to (except in a constructor or a variable initializer)
            // PointReference2 = new PointReference(); // error 
        }
    }
    public struct PointValue
    {
        public int x;
        public int y;

        public void Points()
        {
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
    }

    public class PointReference
    {
        public int x;
        public int y;

        public void Points()
        {
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
    }

    // Value types are stored on the stack.
    // Reference types are stored on the heap.
    // Value types are copied when passed as parameters.
    // Reference types are passed by reference.
    // Value types are destroyed when they go out of scope.
    // Reference types are destroyed when they are no longer referenced.
    // Value types are faster than reference types.
    
    // Structs are value types, allocated either on the stack or inline in containing types. 
    // Classes are reference types, allocated on the heap and garbage-collected. 
    // Allocations and de-allocations of value types are in general cheaper than allocations 
    // and de-allocations of reference types.

    // Member functions inside the structure: 
    // Structures in C cannot have member functions inside a structure 
    // but Structures in C++ and C# can have member functions along with data members.

    // Structures can have constructors.    
}