using System;

namespace ControlFlow
{
    class WhileDoWhile
    {
        static void Main(string[] args)
        {
            int age = 30;
            // While loop
            while (age < 18)
            {
                Console.WriteLine("While Loop");
                Console.WriteLine("How old are you?");
                age = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Cool!");

            // Do While loop
            do
            {
                Console.WriteLine("Do While Loop");
                Console.WriteLine("How old are you?");
                age = int.Parse(Console.ReadLine());
            } while (age < 18);

            Console.WriteLine("Great!");

            // We use the while loop when we don't know how many times we want to loop
            // We use the do while loop when we want to loop at least once
            // For example, while asking to enter a password, we don't know how many times the user will try to enter it
            // For example, when asking the user to enter a number, we want to loop at least once

        }
    }
}
