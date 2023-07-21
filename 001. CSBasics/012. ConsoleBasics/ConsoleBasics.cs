using System;

namespace CSBasics
{
    class ConsoleBasics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, what's your name?");
            string? name = Console.ReadLine();
            Console.WriteLine("Hi, {0}!", name);

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine()); // int.Parse() is a static method of the int class
            // int.Parse() converts a string to an int
            Console.WriteLine("You are {0} years old.", age);

            Console.Clear(); // clears the console

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Enter your name: ");
            string? name2 = Console.ReadLine();
            Console.Write("Your name is {0}\n", name2);
            
            Console.Write("Enter your age: ");
            // TryParse() is a static method of the int class, it returns a bool
            // TryParse() converts a string to an int and returns true if the conversion was successful
            int age2 = int.TryParse(Console.ReadLine(), out age2) ? age2 : 0;
            Console.Write("Your age is {0}\n", age2);

            Console.ResetColor(); // resets the console colors to the default ones

            Console.ReadKey(); // waits for a key to be pressed

        }
    }
}