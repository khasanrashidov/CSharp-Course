using System.IO;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MinMaxSumAverage("Top100ChessPlayers.csv");
        }

        public static void MinMaxSumAverage(string file)
        {
            List<ChessPlayer> playersList = File.ReadAllLines(file)
                .Skip(1)
                .Select(x => ChessPlayer.ParseFideCsv(x)) // or .Select(ChessPlayer.ParseFideCsv)
                .Where(player => player.BirthYear >= 1988)
                .OrderByDescending(player => player.Rating)
                .ThenBy(player => player.Country)
                .Take(10) 
                .ToList(); // if no ToList() then it returns IEnumerable<ChessPlayer>

            Console.WriteLine($"The lowest rating in TOP 10 is {playersList.Min(player => player.Rating)}");
            Console.WriteLine($"The highest rating in TOP 10 is {playersList.Max(player => player.Rating)}");
            Console.WriteLine($"The average rating in TOP 10 is {playersList.Average(player => player.Rating):F0}");
            Console.WriteLine($"The sum of ratings in TOP 10 is {playersList.Sum(player => player.Rating)}");
        }
    }
}