using System;

namespace ControlFlow
{
    class MaxOfTwoNumbers
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Clear the console
            Console.ForegroundColor = ConsoleColor.Green; // Set the foreground color to green
            Console.BackgroundColor = ConsoleColor.Black; // Set the background color to black

            Console.WriteLine("====================================");
            Console.WriteLine("Max of Two Numbers");
            Console.WriteLine("====================================");
            Console.Write("Enter the first number:   ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:   ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            // Compare the two numbers
            bool isFirstNumberGreater = firstNumber > secondNumber;
            bool isSecondNumberGreater = secondNumber > firstNumber;
            bool areEqual = firstNumber == secondNumber;

            Console.WriteLine("====================================");

            // Display the result
            if (isFirstNumberGreater)
            {
                Console.WriteLine($"{firstNumber} is greater than {secondNumber}."); // String interpolation
            }
            else if (isSecondNumberGreater)
            {
                Console.WriteLine("{0} is greater than {1}.", firstNumber, secondNumber); // String formatting
            }
            else if (areEqual)
            {
                Console.WriteLine($"{firstNumber} is equal to {secondNumber}."); // String interpolation
            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }

            Console.WriteLine("====================================");
            Console.Write("Press any key to exit...");
            Console.ReadKey();


            // Max of two numbers: other solutions
            
            // int max = 0;
            // if (firstNumber > secondNumber)
            // {
            //     max = firstNumber;
            // }
            // else
            // {
            //     max = secondNumber;
            // }
            // Console.WriteLine("The max number is {0}.", max);

            // int max = firstNumber > secondNumber ? firstNumber : secondNumber;
            // Console.WriteLine("The max number is {0}.", max);

            // int max = Math.Max(firstNumber, secondNumber);
            // Console.WriteLine("The max number is {0}.", max);

            // int max = firstNumber;
            // if (secondNumber > firstNumber)
            // {
            //     max = secondNumber;
            // }
            // Console.WriteLine("The max number is {0}.", max);

        }
    }
}
