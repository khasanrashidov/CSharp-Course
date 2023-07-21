using System;

namespace ControlFlow
{
    class ForForeach
    {
        static void Main(string[] args)
        {
            // declare an array of integers
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // for loop: iterate over an array in ascending order
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            // for loop: iterate over an array in descending order
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            // foreach loop: iterate over an array
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            // foreach loop: iterate over a string
            string str = "Hello World";
            foreach (char c in str)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            // Print even numbers
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine();

            // Print odd numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
