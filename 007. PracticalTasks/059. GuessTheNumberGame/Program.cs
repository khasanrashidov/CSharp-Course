using System;

namespace PracticalTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Guess the number game");
            Console.ResetColor();

            var game = new GuessTheNumberGame();
            game.Start();

            var game2 = new GuessTheNumberGame(guessingPlayer: GuessingPlayer.Computer);
            game2.Start();

            var game3 = new GuessTheNumberGame(1000, 10, GuessingPlayer.Computer);
            game3.Start();

            Console.ReadKey();

        }
    }
}