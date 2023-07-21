using System;

namespace ControlFlow
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            // 0, 1, 1, 2, 3, 5, 8, 13, 21
            int firstNum = 0;
            int secondNum = 1;
            int temp = 0;
            Console.Write("Enter the number of Fibonacci numbers you want to generate: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] fibonacciNumbers = new int[num];

            if (num == 1)
            {
                fibonacciNumbers[0] = firstNum;
                Console.Write("Fibonacci numbers: ");
                Console.WriteLine($"|{fibonacciNumbers[0]}|");
            }
            else if (num == 2)
            {
                fibonacciNumbers[0] = firstNum;
                fibonacciNumbers[1] = secondNum;
                Console.Write("Fibonacci numbers: ");
                Console.WriteLine($"|{fibonacciNumbers[0]}| |{fibonacciNumbers[1]}|");
            }
            else if (num > 2)
            {
                fibonacciNumbers[0] = firstNum;
                fibonacciNumbers[1] = secondNum;
                for (int i = 2; i < num; i++)
                {
                    temp = firstNum + secondNum;
                    fibonacciNumbers[i] = temp;
                    firstNum = secondNum;
                    secondNum = temp;
                }
                Console.Write("Fibonacci numbers: ");
                for (int i = 0; i < fibonacciNumbers.Length; i++)
                {
                    Console.Write("|" + fibonacciNumbers[i] + "| ");
                }
            }

            Console.ReadKey();
 
            // Another solution
            // int n = int.Parse(Console.ReadLine());
            // int a = 0;
            // int b = 1;
            // int c = 0;
            // for (int i = 0; i < n; i++)
            // {
            //     Console.Write("{0} ", a);
            //     c = a + b;
            //     a = b;
            //     b = c;
            // }
        }
    }
}
