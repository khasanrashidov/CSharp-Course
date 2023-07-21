using System;
using System.Text;

namespace PracticalTasks.TicTacToeGame
{
    internal class Program
    {
        private static TicTacToeGame tttg = new TicTacToeGame();
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(GetBoardState());
            Console.ResetColor();
            while (tttg.GetWinner() == Winner.Ongoing)
            {
                int index = Convert.ToInt32(Console.ReadLine());
                tttg.MakeMove(index);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(GetBoardState());
                Console.ResetColor();
            }

            Console.WriteLine($"Result: {tttg.GetWinner()}");
            Console.ReadKey();
        }

        static string GetBoardState()
        {
            var sb = new StringBuilder();
            sb.AppendLine(" _____ _____ _____");
            for (int i = 1; i <= 7; i += 3)
            {
                sb.AppendLine("|     |     |     |")
                  .AppendLine($"|  {GetBoardChars(i)}  |  {GetBoardChars(i + 1)}  |  {GetBoardChars(i + 2)}  |")
                  .AppendLine("|_____|_____|_____|");
            }

            return sb.ToString();
        }

        private static string GetBoardChars(int index)
        {
            State state = tttg.GetState(index);
            if (state == State.Unset)
            {
                return index.ToString();
            }
            return state == State.Cross ? "X" : "O";
        }
    }
}
