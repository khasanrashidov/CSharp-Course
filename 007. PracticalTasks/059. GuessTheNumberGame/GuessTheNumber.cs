using System;

namespace PracticalTasks
{
    public enum GuessingPlayer
    {
        Human, // 0
        Computer // 1
    }

    public class GuessTheNumberGame
    {
        private readonly int max;
        private readonly int attempts;
        private readonly GuessingPlayer guessingPlayer;

        public GuessTheNumberGame(int max = 100, int attempts = 5, GuessingPlayer guessingPlayer = GuessingPlayer.Human)
        {
            this.max = max;
            this.attempts = attempts;
            this.guessingPlayer = guessingPlayer;
            this.attempts = attempts;
            this.guessingPlayer = guessingPlayer;
            this.max = max;
        }

        public void Start()
        {
            if (guessingPlayer == GuessingPlayer.Human)
            {
                HumanGuessing();
            }
            else
            {
                ComputerGuessing();
            }
        }

        private void HumanGuessing()
        {
            int number = new Random().Next(0, max);
            int attempt = 0;
            int guess = -1;

            while (attempt < attempts)
            {   
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.ForegroundColor =  ConsoleColor.Green;
                    Console.WriteLine("You win! Congratulations! You guessed the number!");
                    Console.ResetColor();
                    break;
                }
                else if (guess < number)
                {
                    Console.ForegroundColor =  ConsoleColor.DarkYellow;
                    Console.WriteLine("Your guess is less than the number.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor =  ConsoleColor.DarkYellow;
                    Console.WriteLine("Your guess is greater than the number.");
                    Console.ResetColor();
                }

                Console.ForegroundColor =  ConsoleColor.DarkGreen;
                Console.WriteLine($"Attempts left: {attempts - attempt - 1}");
                attempt++;
                Console.ResetColor();
            }

            if (attempt == attempts)
            {   
                Console.ForegroundColor =  ConsoleColor.Red;
                Console.WriteLine("You lose! You did not guess the number!");
                Console.ForegroundColor =  ConsoleColor.Green;
                Console.WriteLine($"The number was: {number}");
                Console.ResetColor();
            }
        }

        private void ComputerGuessing()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Enter the number for the computer to guess: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int attempt = 0;
            int guess = -1;
            int min = 0;
            int max = this.max;

            while (attempt < attempts)
            {
                guess = (min + max) / 2;

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Computer guess: {guess}");

                if (guess == number)
                {
                    Console.ForegroundColor =  ConsoleColor.Green;
                    Console.WriteLine("Computer wins! Congratulations! Computer guessed the number!");
                    Console.ResetColor();
                    break;
                }
                else if (guess < number)
                {
                    Console.ForegroundColor =  ConsoleColor.DarkYellow;
                    Console.WriteLine("Computer guess is less than the number.");
                    Console.ResetColor();
                    min = guess;
                }
                else
                {
                    Console.ForegroundColor =  ConsoleColor.DarkYellow;
                    Console.WriteLine("Computer guess is greater than the number.");
                    Console.ResetColor();
                    max = guess;
                }

                Console.ForegroundColor =  ConsoleColor.DarkGreen;
                Console.WriteLine($"Attempts left: {attempts - attempt - 1}");
                Console.ResetColor();
                attempt++;
            }

            if (attempt == attempts)
            {   
                Console.ForegroundColor =  ConsoleColor.Red;
                Console.WriteLine("Computer loses! Computer did not guess the number!");
                Console.ForegroundColor =  ConsoleColor.Green;
                Console.WriteLine($"The number was: {number}");
                Console.ResetColor();
            }
        }
    }
}