using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectBasedStack stack = new ObjectBasedStack();
            Console.WriteLine("Count: {0}", stack.Count);
            Console.WriteLine("Capacity: {0}", stack.Capacity);
            Console.WriteLine();

            stack = new ObjectBasedStack(8);
            Console.WriteLine("Count: {0}", stack.Count);
            Console.WriteLine("Capacity: {0}", stack.Capacity);
            Console.WriteLine();

            ObjectBasedStack myStack = new ObjectBasedStack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            Console.WriteLine("Peek: {0}", myStack.Peek());

            myStack.Pop();

            Console.WriteLine("Peek: {0}", myStack.Peek());

            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);
            myStack.Push(7);
            myStack.Push(8);
            myStack.Push(9);
            myStack.Push(10);
            myStack.Push(11);
            myStack.Push("Hello");
            myStack.Push(false);
            myStack.Push(12.34);
            myStack.Push('A');
            myStack.Push(new Character(Race.Elf));


            Console.WriteLine("Peek: {0}", myStack.Peek());

            Console.WriteLine("Count: {0}", myStack.Count);
            Console.WriteLine("Capacity: {0}", myStack.Capacity);

            Console.WriteLine();

            myStack.Clear();

            Console.WriteLine("Count: {0}", myStack.Count);
            Console.WriteLine("Capacity: {0}", myStack.Capacity);

            Console.WriteLine();
        }
    }
}