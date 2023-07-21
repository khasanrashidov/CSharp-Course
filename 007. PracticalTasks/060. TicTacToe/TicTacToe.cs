using System;

namespace PracticalTasks
{
    public class TicTacToe
    {
        char[][] board = new char[3][]
        {
            new char[3] { '1', '2', '3' },
            new char[3] { '4', '5', '6' },
            new char[3] { '7', '8', '9' },
        };

        int choice;
        int raw;
        int column;
        char turn = 'X';
        bool draw = false;


        // Display board method
        public void DisplayBoard()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("        _____ _____ _____");
            Console.WriteLine("       |     |     |     |");
            Console.WriteLine($"       |  {board[0][0]}  |  {board[0][1]}  |  {board[0][2]}  |");
            Console.WriteLine("       |_____|_____|_____|");
            Console.WriteLine("       |     |     |     |");
            Console.WriteLine($"       |  {board[1][0]}  |  {board[1][1]}  |  {board[1][2]}  |");
            Console.WriteLine("       |_____|_____|_____|");
            Console.WriteLine("       |     |     |     |");
            Console.WriteLine($"       |  {board[2][0]}  |  {board[2][1]}  |  {board[2][2]}  |");
            Console.WriteLine("       |_____|_____|_____|");
            Console.ResetColor();
            Console.WriteLine();

        }

        // Player choice method
        public void PlayerChoice()
        {
            if (turn == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Player 1 [X] turn");
                Console.ResetColor();
            }
            else if (turn == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Player 2 [O] turn");
                Console.ResetColor();
            }

            try
            {
                Console.Write("Enter a number: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a number!");
                Console.ResetColor();
                PlayerChoice();
            }

            switch (choice)
            {
                case 1:
                    raw = 0; column = 0; break;
                case 2:
                    raw = 0; column = 1; break;
                case 3:
                    raw = 0; column = 2; break;
                case 4:
                    raw = 1; column = 0; break;
                case 5:
                    raw = 1; column = 1; break;
                case 6:
                    raw = 1; column = 2; break;
                case 7:
                    raw = 2; column = 0; break;
                case 8:
                    raw = 2; column = 1; break;
                case 9:
                    raw = 2; column = 2; break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number between 1 and 9!");
                    Console.ResetColor();
                    PlayerChoice();
                    break;
            }

            if (board[raw][column] != 'X' && board[raw][column] != 'O')
            {
                board[raw][column] = turn;
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry the row {0} and column {1} is already marked with {2}", raw, column, board[raw][column]);
                Console.WriteLine("Please try another row and column!");
                Console.ResetColor();
                PlayerChoice();
            }

            DisplayBoard();
        }

        // Game Status method
        public bool GameStatus()
        {
            // Horizontal win
            for (int i = 0; i < 3; i++)
            {
                if (board[i][0] == board[i][1] && board[i][0] == board[i][2])
                {
                    return false;
                }
            }

            // Vertical win
            for (int i = 0; i < 3; i++)
            {
                if (board[0][i] == board[1][i] && board[0][i] == board[2][i])
                {
                    return false;
                }
            }

            // Diagonal win
            if (board[0][0] == board[1][1] && board[0][0] == board[2][2] ||
                board[0][2] == board[1][1] && board[0][2] == board[2][0])
            {
                return false;
            }

            // Draw
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i][j] != 'X' && board[i][j] != 'O')
                    {
                        return true;
                    }
                }
            }

            draw = true;
            return false;

        }


        // Check winner method
        public void CheckWinner()
        {
            if (draw)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Draw!");
                Console.ResetColor();
            }
            else
            {
                if (turn == 'X')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Player 2 [O] is the winner!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Player 1 [X] is the winner!");
                    Console.ResetColor();
                }
            }
        }

        // Game Intro method
        public void GameIntro()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("======= Tic Tac Toe Game =======");
            Console.WriteLine("| Player 1 - X || Player 2 - O |");
            Console.WriteLine("================================");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}