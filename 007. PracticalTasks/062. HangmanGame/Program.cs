using System;

namespace PracticalTasks.HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Welcome to Hangman Game!");
            Console.ResetColor();
            Console.WriteLine();

            HangmanGame hangmanGame = new HangmanGame();

            string word = hangmanGame.GenerateWord();
            Console.ForegroundColor = ConsoleColor.Blue;
            // Console.WriteLine("The word is: {0}", word); // for testing purposes
            Console.WriteLine("The word consists of {0} letters.", word.Length);
            Console.WriteLine("Try to guess it!");
            Console.WriteLine("You have {0} attempts.", hangmanGame.maxAttempts);
            Console.ResetColor();
            Console.WriteLine();

            while (hangmanGame.GameStatus == HangmanGameStatus.InProgress)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Enter a letter: ");
                Console.ResetColor();

                char letter = Console.ReadLine().ToCharArray()[0];
            
                string currentStatus = hangmanGame.GuessLetter(letter);

                hangmanGame.DrawHangman();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Word: {currentStatus}");
                Console.WriteLine("You have {0} attempts left.", hangmanGame.AttemptsLeft);
                Console.WriteLine("You have tried the following letters: {0}", hangmanGame.TriedLetters);
                Console.ResetColor();
                Console.WriteLine();
            }

            if (hangmanGame.GameStatus == HangmanGameStatus.Won)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations! You won!");
                Console.WriteLine("The word was: {0}", hangmanGame.Word);
                Console.ResetColor();
            }
            else if (hangmanGame.GameStatus == HangmanGameStatus.Lost)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lost! The word was: {0}", hangmanGame.Word);
                Console.ResetColor();

            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Press any key to exit...");
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}