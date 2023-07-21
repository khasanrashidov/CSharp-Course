using System; // for Console
using System.Collections.Generic; // for List<T>

namespace ArraysCollections
{
    class ListDemo
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            // Empty list
            List<int> intList0 = new List<int>();
            // List with initial capacity
            var intList = new List<int> { 1, 4, 2, 7, 5, 9, 2, 12 };
            intList.Add(3); // Add()

            foreach (int item in intList)
            {
                Console.Write(item + " ");
            }

            System.Console.WriteLine();

            int[] intArray = { 1, 2, 3 };
            // AddRange() - adds the elements of the specified collection to the end of the List<T>.
            intList.AddRange(intArray);

            foreach (int item in intList)
            {
                Console.Write(item + " ");
            }

            System.Console.WriteLine();

            // Removes the first occurrence of a specific object from the List<T>.
            // Returns bool value indicating whether the element is successfully removed.
            if (intList.Remove(1)) // Remove()
            {
                // do smth
                System.Console.WriteLine("Success");
            }
            else
            {
                // do smth
                System.Console.WriteLine("Failure");
            }

            intList.RemoveAt(0); // RemoveAt() - removes the element at the specified index of the List<T>.

            intList.Reverse(); // Reverse() - reverses the order of the elements in the entire List<T>.

            intList.Sort(); // Sort() - sorts the elements in the entire List<T> in ascending order.

            intList.Insert(0, 1); // Insert() - inserts an element into the List<T> at the specified index.

            intList.InsertRange(0, intArray); // InsertRange() - inserts the elements of a collection into the List<T> at the specified index.

            intList.RemoveRange(0, 2); // RemoveRange() - removes a range of elements from the List<T>.

            // Contains() - determines whether an element is in the List<T>.
            bool contains = intList.Contains(6);
            Console.WriteLine($"Contains 6: {contains}");

            int count = intList.Count; // Count - gets the number of elements contained in the List<T>.
            Console.WriteLine($"Count: {count}");

            // Capacity - gets or sets the number of elements that the List<T> can contain.
            // Capacity is different from Count.
            // Capacity is the size of the internal array used to hold items.
            // It is dynamically increased as needed.
            int capacity = intList.Capacity;
            Console.WriteLine($"Capacity: {capacity}");

            // Min() - returns the minimum value in a generic sequence.
            // Max() - returns the maximum value in a generic sequence.
            int min = intList.Min();
            int max = intList.Max();
            Console.WriteLine($"Min: {min}, Max: {max}");

            // BinarySearch() - searches a range of elements in a sorted List<T> for an element using the specified comparer and returns the zero-based index of the element.
            int binarySearch = intList.BinarySearch(2);
            Console.WriteLine($"Binary search: {binarySearch}");

            // IndexOf() - returns the zero-based index of the first occurrence of a value in a generic sequence.
            // LastIndexOf() - returns the zero-based index of the last occurrence of a value in a generic sequence.
            var newList0 = new List<int> { 1, 2, 3, 2, 4, 5, 2, 6, 7, 8, 9 };
            int firstIndex = newList0.IndexOf(2);
            int lastIndex = newList0.LastIndexOf(2);
            foreach (int item in newList0)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine($"First index: {firstIndex}, Last index: {lastIndex}");
            
            Console.WriteLine();
            
            // Count is a property of the List<T> class. It returns the number of elements in the list.
            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{intList[i]} ");
            }

            System.Console.WriteLine();

            foreach (int item in intList)
            {
                Console.Write($"{item} ");
            }

            System.Console.WriteLine();

            intList.Clear(); // Clear() - removes all elements from the List<T>.
            Console.WriteLine(intList.Count);

            var newList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var subList = newList.GetRange(2, 3); // GetRange() - returns a read-only List<T> that contains a range of elements from the source List<T>.
            foreach (int item in subList)
            {
                Console.Write($"{item} ");
            }

            System.Console.WriteLine();

            // RemoveAll() - removes all the elements that match the conditions defined by the specified predicate.
            newList.RemoveAll(x => x % 2 == 0);
            foreach (int item in newList)
            {
                Console.Write($"{item} ");
            }

            System.Console.WriteLine();

            // Find() - returns the first element that matches the conditions defined by the specified predicate, if found; otherwise, the default value for type T.
            int firstOdd = newList.Find(x => x % 2 != 0);
            Console.WriteLine($"First odd: {firstOdd}");

            // FindAll() - returns a read-only List<T> that contains all the elements that match the conditions defined by the specified predicate.
            var oddList = newList.FindAll(x => x % 2 != 0);
            foreach (int item in oddList)
            {
                Console.Write($"{item} ");
            }

            System.Console.WriteLine();

            // FindIndex() - returns the zero-based index of the first occurrence of an element that matches the conditions defined by the specified predicate, if found; otherwise, -1.
            int firstOddIndex = newList.FindIndex(x => x % 2 != 0);
            Console.WriteLine($"First odd index: {firstOddIndex}");

            // FindLast() - returns the last element that matches the conditions defined by the specified predicate, if found; otherwise, the default value for type T.
            int lastOdd = newList.FindLast(x => x % 2 != 0);
            Console.WriteLine($"Last odd: {lastOdd}");

            // FindLastIndex() - returns the zero-based index of the last occurrence of an element that matches the conditions defined by the specified predicate, if found; otherwise, -1.
            int lastOddIndex = newList.FindLastIndex(x => x % 2 != 0);
            Console.WriteLine($"Last odd index: {lastOddIndex}");

            // TrueForAll() - determines whether every element in the List<T> matches the conditions defined by the specified predicate.
            bool allOdd = newList.TrueForAll(x => x % 2 != 0);
            Console.WriteLine($"All odd: {allOdd}");

            // Convert List<T> to array
            int[] array = newList.ToArray();
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }

            System.Console.WriteLine();

            // Convert array to List<T>
            List<int> list = new List<int>(array);
            foreach (int item in list)
            {
                Console.Write($"{item} ");
            }

            System.Console.WriteLine();

            // Convert List<T> to string
            string listString = string.Join(", ", list);
            Console.WriteLine($"List string: {listString}");

            // Convert string to List<T>
            List<int> listFromString = listString.Split(", ").Select(int.Parse).ToList();
            foreach (int item in listFromString)
            {
                Console.Write($"{item} ");
            }

            System.Console.WriteLine();

            // Convert List<T> to Dictionary<TKey, TValue>
            var dictionary = list.ToDictionary(x => x, x => x * 2);
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            // Convert Dictionary<TKey, TValue> to List<T>
            var listFromDictionary = dictionary.Select(x => x.Key).ToList();
            foreach (int item in listFromDictionary)
            {
                Console.Write($"{item} ");
            }

            System.Console.WriteLine();
        }
    }
}
