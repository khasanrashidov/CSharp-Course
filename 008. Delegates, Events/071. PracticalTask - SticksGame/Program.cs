namespace SticksGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var game = new SticksGame(10, Player.Human);
            game.ComputerPlayed += Game_ComputerPlayed;
            game.HumanTurnToPlay += Game_HumanTurnToPlay;
            game.EndOfGame += Game_EndOfGame;

            game.Start();
        }

        private static void Game_EndOfGame(Player player)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine($"Game is over. Winner is {player}");
            Console.WriteLine("=====================================");
        }

        private static void Game_HumanTurnToPlay(object? sender, int remainingSticks)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine($"Remaining sticks: {remainingSticks}");
            Console.WriteLine("=====================================");
            Console.WriteLine("Your turn to play");

            bool takenCorrectly = false;
            while (!takenCorrectly)
            {
                Console.Write("How many sticks do you want to take?: ");
                if (int.TryParse(Console.ReadLine(), out int takenSticks))
                {
                   var game = (SticksGame?)sender;
                    
                    try
                    {
                        game?.HumanTakes(takenSticks);
                        takenCorrectly = true;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("=====================================");
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("=====================================");
                    }
                }
            }
        }

        private static void Game_ComputerPlayed(int numberOfSticks)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine($"Computer took {numberOfSticks} sticks");
            Console.WriteLine("=====================================");
        }
    }
}