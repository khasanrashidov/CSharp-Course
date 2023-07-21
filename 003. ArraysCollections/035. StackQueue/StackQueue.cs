using System;
using System.Collections.Generic;

namespace ArraysCollections
{
    class StackQueue
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // Abstract Data type (ADT) is a type (or class) for objects 
            // whose behavior is defined by a set of values and a set of operations. 
            // The definition of ADT only mentions what operations are to be performed 
            // but not how these operations will be implemented.

            // Stack is a LIFO (Last In First Out) data structure.
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);

            Console.WriteLine("Stack: ");
            foreach (var item in stack)
            {
                Console.WriteLine($"Item in stack: {item}");
            }

            Console.WriteLine();

            // The Peek method returns the object at the top of the Stack<T> without removing it.
            Console.WriteLine("Top of stack: " + stack.Peek());
            // The Pop method removes and returns the object at the top of the Stack<T>.
            Console.WriteLine("Pop: " + stack.Pop());

            Console.WriteLine("Top of stack: " + stack.Peek());

            // The Count property returns the number of elements in the Stack<T>.
            int countStack = stack.Count;
            Console.WriteLine($"Count: {countStack}");

            // The Contains method determines whether an element is in the Stack<T>.
            bool contains = stack.Contains(2); // true
            Console.WriteLine($"Contains 2: {contains}");

            // The ToArray method copies the Stack<T> elements to a new array.
            int[] arrayStack = stack.ToArray();
            foreach (var item in arrayStack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            // The CopyTo method copies the Stack<T> elements to an existing one-dimensional Array,
            // starting at the specified array index.
            int[] arrayStack2 = new int[9];
            stack.CopyTo(arrayStack2, 0);
            foreach (var item in arrayStack2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            // The GetEnumerator method returns an enumerator that iterates through the Stack<T>.
            var enumeratorStack = stack.GetEnumerator();
            while (enumeratorStack.MoveNext())
            {
                Console.WriteLine(enumeratorStack.Current);
            }
            System.Console.WriteLine();

            // The TrimExcess method sets the capacity to the actual number of elements in the Stack<T>,
            // if that number is less than 90 percent of current capacity.
            stack.TrimExcess();
            int capacity = stack.Count;
            Console.WriteLine($"Capacity after TrimExcess: {capacity}");

            // Clear method removes all objects from the Stack<T>.
            stack.Clear();
            Console.WriteLine($"Count: {stack.Count}"); // 0

            Console.WriteLine();

            //////////////////////////////////////////////////////////////////////////////

            // Queue is a FIFO (First In First Out) data structure.
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);

            Console.WriteLine("Queue: ");
            foreach (var item in queue)
            {
                Console.WriteLine($"Item in queue: {item}");
            }

            Console.WriteLine();

            // The Peek method returns the object at the beginning of the Queue<T> without removing it.
            Console.WriteLine("Top of queue: " + queue.Peek());
            // The Dequeue method removes and returns the object at the beginning of the Queue<T>.
            Console.WriteLine("Dequeue: " + queue.Dequeue());

            Console.WriteLine("Top of queue: " + queue.Peek());

            // The Count property returns the number of elements in the Queue<T>.
            int countQueue = queue.Count;
            Console.WriteLine($"Count: {countQueue}");

            // The Contains method determines whether an element is in the Queue<T>.
            bool containsQueue = queue.Contains(2); // true
            Console.WriteLine($"Contains 2: {containsQueue}");

            // The ToArray method copies the Queue<T> elements to a new array.
            int[] arrayQueue = queue.ToArray();
            foreach (var item in arrayQueue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            // The CopyTo method copies the Queue<T> elements to an existing one-dimensional Array,
            // starting at the specified array index.
            int[] arrayQueue2 = new int[9];
            queue.CopyTo(arrayQueue2, 0);
            foreach (var item in arrayQueue2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            // The GetEnumerator method returns an enumerator that iterates through the Queue<T>.
            var enumeratorQueue = queue.GetEnumerator();
            while (enumeratorQueue.MoveNext())
            {
                Console.WriteLine(enumeratorQueue.Current);
            }
            System.Console.WriteLine();

            // The TrimExcess method sets the capacity to the actual number of elements in the Queue<T>,
            // if that number is less than 90 percent of current capacity.
            queue.TrimExcess();
            int capacityQueue = queue.Count;
            Console.WriteLine($"Capacity after TrimExcess: {capacityQueue}");

            // Clear method removes all objects from the Queue<T>.
            queue.Clear();
            Console.WriteLine($"Count: {queue.Count}"); // 0

            Console.WriteLine();
        }
    }
}
