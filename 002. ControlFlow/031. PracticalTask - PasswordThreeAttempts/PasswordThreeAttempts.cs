using System;

namespace ControlFlow
{
    class PasswordThreeAttempts
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Title = "Password Three Attempts"; // Title of the console window
            
            string correctUsername = "johnsilver"; // string - reference type
            string correctPassword = "qwerty";
            string? password; // ? - nullable
            string? login; // ? - nullable
            int attempts = 0; // int - value type

            Console.WriteLine("____________________________________________________");
            while (attempts < 3)
            {
                Console.Write("Enter your username:   ");
                login = Console.ReadLine();

                Console.Write("Enter your password:   ");
                // taking password from the console
                // without displaying it on the screen
                // hiding the password using asterisks
                password = string.Empty; // string.Empty - empty string
                ConsoleKeyInfo key;
                do
                {
                    key = Console.ReadKey(true);
                    // Backspace Should Not Work
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        password += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                        {
                            password = password.Substring(0, (password.Length - 1));
                            Console.Write("\b \b");
                        }
                    }
                } while (key.Key != ConsoleKey.Enter);                
            
                if (login == correctUsername && password == correctPassword)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("[Access granted! - Enter the System!]");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("[Incorrect username or password!]");
                    attempts++;
                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("____________________________________________________");
            }

            Console.WriteLine("____________________________________________________");
            if (attempts == 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The number of available tries have been exceeded!");
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Press any key to exit... ");
            Console.ReadKey();

        }
    }
}
