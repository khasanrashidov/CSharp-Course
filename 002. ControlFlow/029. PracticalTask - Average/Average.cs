using System;

namespace ControlFlow
{
    class Average
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int counter = 0;
            int sum = 0;
            int divisor = 0;
            double average = 0;

            Console.WriteLine("==============================");
            Console.WriteLine("Enter 10 numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                if (numbers[i] == 0)
                    break;
                counter++;
            }

            Console.WriteLine("==============================");
            Console.Write("Entered numbers: ");
            for (int j = 0; j < counter; j++)
            {
                Console.Write(numbers[j] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("==============================");
            for (int k = 0; k < counter; k++)
            {
                if (numbers[k] % 3 == 0)
                {
                    sum += numbers[k];
                    divisor++;
                }
            }
            // We can use number[k] > 0 in the if statement
            // then we don't need to use counter variable


            average = (double)sum / divisor;
            Console.WriteLine("Average of numbers divisible by three: " + average);
            Console.WriteLine("==============================");

            // Solution 2

            // int[] numbers = new int[10];
            // int sum = 0;
            // int count = 0;

            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     Console.Write("Enter a number: ");
            //     numbers[i] = Convert.ToInt32(Console.ReadLine());

            //     if (numbers[i] == 0)
            //     {
            //         break;
            //     }

            //     if (numbers[i] % 3 == 0)
            //     {
            //         sum += numbers[i];
            //         count++;
            //     }
            // }

            // Console.WriteLine("Average: {0}", sum / count);
        }
    }
}
