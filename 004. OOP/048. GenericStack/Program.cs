using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericStack<int> stack = new GenericStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push('a');
            // stack.Push("Hello"); // Error
            // stack.Push(1.2); // Error
            // stack.Push(true); // Error

            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);

            Console.WriteLine("Count: " + stack.Count);
            Console.WriteLine("Capacity: " + stack.Capacity);

            int number = stack.Peek();
            Console.WriteLine(number);

            Console.WriteLine();

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Peek());
                stack.Pop();
                // or in one line: Console.WriteLine(stack.Pop());
            }

            Console.WriteLine("Count: " + stack.Count);
            Console.WriteLine("Capacity: " + stack.Capacity);

            Console.WriteLine();

            GenericStack<string> stack2 = new GenericStack<string>();
            stack2.Push("Hello");
            stack2.Push("World");
            stack2.Push("!");

            Console.WriteLine();

            Console.WriteLine("Count: " + stack2.Count);
            Console.WriteLine("Capacity: " + stack2.Capacity);

            while (stack2.Count > 0)
            {
                Console.WriteLine(stack2.Peek());
                stack2.Pop();
            }
            
            // We can use the GenericStack class to create a stack of object type as well
            // Earlier users had no choice to create a stack of any type,
            // users could only create a stack of object type.
            // Now users can create a stack of any type.
        }
    }
}