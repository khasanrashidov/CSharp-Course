namespace LINQ
{
    public class ChessPlayer
    {
        public string Country { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int BirthYear { get; set; }
        public int Rating { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"Full name: {FirstName} {LastName}, Country: {Country}, Birth year: {BirthYear}, Rating: {Rating}";
        }

        public static ChessPlayer ParseFideCsv(string line)
        {
            string[] parts = line.Split(';');
            return new ChessPlayer
            {
                Id = int.Parse(parts[0]),
                LastName = parts[1].Split(',')[0].Trim(), // Trim() removes spaces
                FirstName = parts[1].Split(',')[1].Trim(),
                Country = parts[3],
                Rating = int.Parse(parts[4]),
                BirthYear = int.Parse(parts[6])
            };
        }

    }
}