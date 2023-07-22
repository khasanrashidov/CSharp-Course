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
                // or .Select(ChessPlayer.ParseFideCsv)
                .Select(x => ChessPlayer.ParseFideCsvLine(x))
                // Old-style anonymous method syntax:
                //.Where(delegate (ChessPlayer player) { return player.BirthYear >= 1988; })
                .Where(player => player.BirthYear >= 1988)
                .OrderByDescending(player => player.Rating)
                .ThenBy(player => player.Country)
                .Take(10)
                .ToList(); // if no ToList() then it returns IEnumerable<ChessPlayer>


            // SQL-like syntax:
            IEnumerable<ChessPlayer> playersList3 = File.ReadAllLines(file)
                                                        .Skip(1)
                                                        .Select(ChessPlayer.ParseFideCsvLine);

            var filtered = from player in playersList3
                           where player.BirthYear >= 1988
                           orderby player.Rating descending, player.Country
                           select player;


            // Multiple Enumerations
            // E.g.: when we don't have ToList() (greedy loading)
            // and we enumerate over the collection multiple times, the query is executed multiple times.
            // If we enumerate over the same collection multiple times, the query is executed multiple times.
            // To avoid this, we can store the result in a list and then enumerate over the list.
            // Example of a problem:
            foreach (var player in playersList)
            {
                Console.WriteLine(player);
            }

            foreach (var player in playersList)
            {
                Console.WriteLine(player);
            }
            // So above code executes the query twice.
            // To avoid this, we can store the result in a list and then enumerate over the list.
            // Example of a solution:
            List<ChessPlayer> playersList2 = playersList.ToList();
            foreach (var player in playersList2)
            {
                Console.WriteLine(player);
            }

            foreach (var player in playersList2)
            {
                Console.WriteLine(player);
            }
            // So above code executes the query only once.


            Console.WriteLine($"The lowest rating in TOP 10 is {playersList.Min(player => player.Rating)}");
            Console.WriteLine($"The highest rating in TOP 10 is {playersList.Max(player => player.Rating)}");
            Console.WriteLine($"The average rating in TOP 10 is {playersList.Average(player => player.Rating):F0}");
            Console.WriteLine($"The sum of ratings in TOP 10 is {playersList.Sum(player => player.Rating)}");

            // First() and Last() throw exception if there is no such element
            // FirstOrDefault() and LastOrDefault() return default value if there is no such element
            // Single() and SingleOrDefault() throw exception if there is more than one element
            // ElementAt() returns element at specified position
            // ElementAtOrDefault() returns default value if there is no such element
            // Count() returns number of elements
            // Any() returns true if there is at least one element
            // All() returns true if all elements satisfy the condition
            // Contains() returns true if there is an element that equals to the specified value
            // Distinct() returns distinct elements

            // First() and Last()
            Console.WriteLine($"USA players count is {playersList.Count(player => player.Country == "USA")}");
            Console.WriteLine($"First USA player is {playersList.First(player => player.Country == "USA")}");
            Console.WriteLine($"Last USA player is {playersList.Last(player => player.Country == "USA")}");

            // FirstOrDefault()
            Console.WriteLine($"First Russian player is {playersList.FirstOrDefault(player => player.Country == "RUS")}");
            Console.WriteLine($"Last Russian player is {playersList.LastOrDefault(player => player.Country == "RUS")}");

            // Just calling First() and Last() without any parameters returns first and last elements
            Console.WriteLine($"First player is {playersList.First()}");
            Console.WriteLine($"Last player is {playersList.Last()}");
            // Above code is an example of Multiple Enumerations.

            // Just calling FirstOrDefault() and LastOrDefault() without any parameters returns first and last elements or null
            Console.WriteLine($"First player is {playersList.FirstOrDefault()}");
            Console.WriteLine($"Last player is {playersList.LastOrDefault()}");

            ChessPlayer firstPlayer = playersList.First();
            Console.WriteLine($"First player is {firstPlayer.FirstName} {firstPlayer.LastName}");

            // Single() and SingleOrDefault()
            Console.WriteLine($"The only player from Norway is {playersList.Single(player => player.Country == "NOR")}");
            Console.WriteLine($"The only player from Norway is {playersList.SingleOrDefault(player => player.Country == "NOR")}");

            // As there are two players from USA, both Single() and SingleOrDefault() throw exception
            //Console.WriteLine($"The only player from USA is {playersList.SingleOrDefault(player => player.Country == "USA")}");

            // ElementAt() and ElementAtOrDefault()
            Console.WriteLine($"The 3rd player is {playersList.ElementAt(2)}");
            Console.WriteLine($"The 3rd player is {playersList.ElementAtOrDefault(2)}");

            // Any() and All() return bool
            Console.WriteLine($"Are there any players from China? {playersList.Any(player => player.Country == "CHN")}");
            Console.WriteLine($"Are all players from Russia? {playersList.All(player => player.Country == "RUS")}");


            // Practical Task - Chess Players
            Console.WriteLine("Practical Task - Chess Players");
            var players = File.ReadAllLines("Top100ChessPlayers.csv")
                            .Skip(1)
                            .Select(ChessPlayer.ParseFideCsvLine)
                            .Where(player => player.Country == "RUS")
                            .OrderBy(player => player.BirthYear)
                            .ToList(); // materialize the query using ToList()

            foreach (var player in players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
