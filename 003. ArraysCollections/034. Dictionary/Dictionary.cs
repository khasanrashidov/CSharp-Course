using System;
using System.Collections.Generic;

namespace ArraysCollections
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // Dictionary<TKey, TValue> is a collection of key-value pairs.
            var people = new Dictionary<int, string>();
            people.Add(1, "John");
            people.Add(2, "Bob");
            people.Add(3, "Alice");


            var people2 = new Dictionary<int, string>()
            {
                {1, "John"},
                {2, "Bob"},
                {3, "Alice"},
                {4, "James"},
                {5, "Mary"},
                {6, "Jane"},
                {7, "Peter"}, // The last comma is optional.
            };

            // The indexer can be used to access the value associated with a key.
            string name = people[1]; // John
            Console.WriteLine(name);
            System.Console.WriteLine();


            System.Console.WriteLine("Iterating over keys");
            // Or var keys = people.Keys;
            Dictionary<int, string>.KeyCollection keys = people.Keys;
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }

            System.Console.WriteLine();

            System.Console.WriteLine("Iterating over values");
            // Or var values = people.Values;
            Dictionary<int, string>.ValueCollection values = people.Values;
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            System.Console.WriteLine();

            System.Console.WriteLine("Iterating over key-value pairs");
            foreach (var pair in people2)
            {
                Console.WriteLine($"Key: {pair.Key}. Value: {pair.Value}.");
            }

            System.Console.WriteLine();

            // The Count property returns the number of key-value pairs in the dictionary.
            Console.WriteLine($"Count = {people.Count}");

            // The ContainsKey and ContainsValue methods can be used 
            // to check if a key or value exists in the dictionary.
            bool containsKey = people.ContainsKey(2);
            bool containsValue = people.ContainsValue("John");

            System.Console.WriteLine($"Contains key: {containsKey}. Contains value: {containsValue}.");

            // The Remove method removes the key-value pair with the specified key.
            bool deleted = people.Remove(1);
            System.Console.WriteLine("Deleted key 1 and its value: " + deleted);

            // The TryAdd method adds a key-value pair to the dictionary.
            // If the key already exists, the method returns false.
            // If the key does not exist, the method adds the key-value pair and returns true.
            if (people.TryAdd(2, "Elias"))
            {
                System.Console.WriteLine("Added successfully!");
            }
            else
            {
                System.Console.WriteLine("Failed to add using key 2");
            }

            // The TryGetValue method gets the value associated with the specified key.
            // If the key exists, the method returns true and the value is assigned to the out parameter.
            // If the key does not exist, the method returns false and the out parameter is assigned the default value of the value type.
            // The out parameter is optional.
            // Default value of string is null.
            // Default value of int is 0.
            if (people.TryGetValue(2, out string? val))
            {
                System.Console.WriteLine($"Key = 2, Value = {val}");
            }
            else
            {
                System.Console.WriteLine("Failed to get the value of key 2.");
            }

            people.Clear(); // Removes all key-value pairs from the dictionary.
            Console.WriteLine($"Count = {people.Count}");
        }
    }
}