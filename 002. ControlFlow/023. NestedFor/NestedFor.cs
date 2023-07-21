using System;

namespace ControlFlow
{
    class NestedFor
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Clear the console
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;

            // Nested For loops
            // Program that finds all pairs and triplets of numbers that sum to 0
            // For example, the pair (-2, 2) and the triplet (-2, 2, 0) sum to 0
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            // We use nested for loops to compare each number with all the other numbers
            // We use the length of the array minus 1 because we don't want to compare the last number with itself
            for (int i = 0; i < numbers.Length - 1; i++) 
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int numI = numbers[i]; // We store the value of the first number in a variable
                    int numJ = numbers[j]; // We store the value of the second number in a variable

                    if (numI + numJ == 0) 
                    {
                        Console.WriteLine($"Pair: ({numI,2}, {numJ,2}). Index: [{i,2}][{j,2}]");
                    }
                }
            }

            Console.WriteLine();

            // For triplets, we use the length of the array minus 2 
            // because we don't want to compare the last two numbers with themselves
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                // We use the length of the array minus 1 
                // because we don't want to compare the last number with itself
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        // We store the value of the first, second and third number in a variable
                        int numI = numbers[i];
                        int numJ = numbers[j];
                        int numK = numbers[k];

                        if (numI + numJ + numK == 0)
                        {
                            Console.WriteLine($"Triplet: ({numI,2}, {numJ,2}, {numK,2}). Index: [{i,2}][{j,2}][{k,2}]");
                        }  
                    }
                }
            }

            Console.WriteLine();
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}