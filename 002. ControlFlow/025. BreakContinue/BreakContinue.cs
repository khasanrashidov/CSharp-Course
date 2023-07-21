using System;

namespace ControlFlow
{
    class BreakContinue
    {
        static void Main(string[] args)
        {
            // Break is used to exit a loop
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // Continue is used to skip the current iteration
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine(i);
            }

            Console.WriteLine();

            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };
            int counter = 0;

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        int numI = numbers[i];
                        int numJ = numbers[j];
                        int numK = numbers[k];

                        if (numI + numJ + numK == 0)
                        {
                            Console.WriteLine($"Triplet: ({numI,2}, {numJ,2}, {numK,2}). Index: [{i,2}][{j,2}][{k,2}]");
                            counter++;
                        }

                    }
                    if (counter == 3)
                        break;
                }
                if (counter == 3)
                    break;
            }

            Console.WriteLine();

            // The same as above, but using continue
            counter = 0;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (counter == 3)
                    continue;
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    if (counter == 3)
                        continue;
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        int numI = numbers[i];
                        int numJ = numbers[j];
                        int numK = numbers[k];

                        if (numI + numJ + numK == 0)
                        {
                            Console.WriteLine($"Triplet: ({numI,2}, {numJ,2}, {numK,2}). Index: [{i,2}][{j,2}][{k,2}]");
                            counter++;
                        }
                        if (counter == 3)
                            continue;
                    }
                }
            }

            Console.WriteLine();

            // The same as above, but using goto
            counter = 0;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        int numI = numbers[i];
                        int numJ = numbers[j];
                        int numK = numbers[k];

                        if (numI + numJ + numK == 0)
                        {
                            Console.WriteLine($"Triplet: ({numI,2}, {numJ,2}, {numK,2}). Index: [{i,2}][{j,2}][{k,2}]");
                            counter++;
                        }
                        if (counter == 3)
                            goto End;
                    }
                }
            }
        End:

            Console.WriteLine();

            int[] numbers2 = { 0, 3, 2, 1, 5, 4, 6, 7, 8, 9 };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine($"Number = {numbers2[i]}");

                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers2[i] == j)
                        break;
                    Console.Write($" {letters[j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Print only even numbers - using continue
            foreach (int n in numbers)
            {
                if (n % 2 != 0)
                    continue;
                Console.Write(n + " ");
            }

            Console.WriteLine();

            // Print only even numbers - using goto

            foreach (int n in numbers)
            {
                if (n % 2 != 0)
                    goto Next;
                Console.Write(n + " ");
            Next:
                continue;
            }
        }
    }
}
