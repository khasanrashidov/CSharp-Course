using System;

namespace OOP
{
    class ObjectBasedStack
    {
        private object[] items;
        // Count is the number of items in the stack
        // By default, it is 0
        public int Count { get; private set; }
        // Capacity is the number of items the stack can hold
        // By default, it is 4
        public int Capacity { get { return items.Length; } } // read-only property

        public ObjectBasedStack()
        {
            const int defaultCapacity = 4;
            items = new object[defaultCapacity];
        }

        public ObjectBasedStack(int capacity)
        {
            items = new object[capacity];
        }

        public void Push(object item)
        {
            if (Count == Capacity) // Here both of them are equal numbers
            {
                // Create a new array with double the capacity
                object[] largerArray = new object[Capacity * 2]; // or new object[Count * 2]; 
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
            items[--Count] = null; // Count--; items[Count] = null;
        }

        public object Peek()
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
            items = new object[4];
        }
    }
}
