using System;
using System.Collections;

namespace OOP
{
    // To make the class generic, we add the <T> after the class name
    // T is a placeholder for the type of the items in the stack
    // <T> is called a type parameter
    class GenericStack<T> : IEnumerable<T>
    {
        private T[] items; // instead of object[] items; we use T[] items; because we want to store items of type T
        // Count is the number of items in the stack
        // By default, it is 0
        public int Count { get; private set; }
        // Capacity is the number of items the stack can hold
        // By default, it is 4
        public int Capacity { get { return items.Length; } } // read-only property

        public GenericStack()
        {
            const int defaultCapacity = 4;
            items = new T[defaultCapacity];
        }

        public GenericStack(int capacity)
        {
            items = new T[capacity];
        }

        public void Push(T item)
        {
            if (Count == Capacity) // Here both of them are equal numbers
            {
                // Create a new array with double the capacity
                T[] largerArray = new T[Capacity * 2]; // or new object[Count * 2]; 
                // Copy the items from the old array to the new array
                Array.Copy(items, largerArray, Count);
                // Set the items array to the new array
                items = largerArray;
            }
            // Add the item to the array and increment the Count
            items[Count++] = item; // items[Count] = item; Count++;   
        }

        public void Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }
            // After throwing the exception, the code below will not be executed

            // Remove the item from the array and decrement the Count
            items[--Count] = default(T); // items[Count - 1] = default(T); Count--;
            // default(T) is the default value of the type T
            // For example, if T is int, then default(T) is 0
            // If T is string, then default(T) is null
            // default(T) we can write as default (without (T))
        }

        public T Peek() // instead of object Peek() we use T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
                // After throwing the exception, the code below will not be executed
            }

            // Return the item from the array
            return items[Count - 1];
        }

        public void Clear()
        {
            // Set the Count to 0
            Count = 0;

            // Set all the items to null
            Array.Clear(items, 0, Count);
            // Array.Clear is a static method of the Array class and it takes 3 parameters:
            // 1. The array to clear
            // 2. The index of the first element to clear
            // 3. The number of elements to clear

            // Reset the array to the default capacity
            items = new T[4];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return items[i];
                // yield return is a keyword that returns an item and remembers the current position
                // The next time the method is called, it continues from the next item  
                // yield return is similar to return, but it returns an IEnumerable<T> instead of void
                // yield keyword is used only in iterators (methods that return IEnumerable<T>)
            }

            // In the loop above we don't generate the list and return whole list at once
            // We return one item at a time and remember the current position
            // This is called lazy evaluation - the list is generated only when it is needed
            // It is more efficient than generating the whole list at once

            // Lazy evaluation is used in LINQ (Language Integrated Query)
            // LINQ is a query language that is integrated into C#

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}