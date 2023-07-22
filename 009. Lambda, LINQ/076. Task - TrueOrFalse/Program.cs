using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TrueOrFalse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game("Questions.csv", 2);
            game.GameOver += (sender, eventArgs) =>
            {
                Console.WriteLine("Game over!");
                Console.WriteLine($"Questions asked: {eventArgs.QuestionsPassed}");
                Console.WriteLine($"You answered {eventArgs.CorrectAnswers} question(s) correctly.");
                Console.WriteLine($"You made {eventArgs.WrongAnswers} mistake(s).");
                Console.WriteLine(eventArgs.IsWin ? "You won!" : "You lost!");
            };
            
            while (game.GameStatus == GameStatus.GameIsInProgress)
            {
                Question q = game.GetNextQuestion();
                Console.WriteLine("Do you think the following statement is true or false?");
                Console.WriteLine("Enter 'y' for true and 'n' for false.");
                Console.WriteLine(q.Text);

                string? input = Console.ReadLine();
                bool answer = input == "y";

                if (q.CorrectAnswer == answer)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Oops! Wrong answer.");
                    Console.WriteLine("Here's the explanation:");
                    Console.WriteLine(q.Explanation);
                }

                game.GiveAnswer(answer);
            }
        }
    }
}