using System;

namespace PracticalTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe game = new TicTacToe();
            game.GameIntro();
            game.DisplayBoard();
            while (game.GameStatus())
            {
                game.PlayerChoice();
                game.GameStatus();
            }
            game.CheckWinner();

        }
    }
}
