namespace TrueOrFalse
{
    public class Game
    {
        private readonly List<Question> questions;
        private readonly int allowedMistakes;
        private int counter;
        private int mistakes;
        public GameStatus GameStatus { get; private set; }
        public event EventHandler<GameResultEventArgs>? GameOver;

        public Game(string filePath, int allowedMistakes = 2)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException(nameof(filePath)); // nameof(filePath) returns "filePath"
            }

            if (filePath == "")
            {
                throw new ArgumentException("File path cannot be empty.", nameof(filePath));
            }

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found.", filePath);
            }

            if (allowedMistakes < 2)
            {
                throw new ArgumentException("Allowed mistakes must be greater than or equal to two.", nameof(allowedMistakes));
            }

            if (allowedMistakes > 5)
            {
                throw new ArgumentException("Allowed mistakes must be less than or equal to five.", nameof(allowedMistakes));
            }

            // Generally, in constructors, we usually don't launch/do lengthy operations.
            // Files, databases, network, etc. are all lengthy operations.
            // We should do them in methods, not in constructors.

            // But for the sake of simplicity, we'll do it here. :)
            List<Question> questions = File.ReadAllLines(filePath)
                                                .Select(x =>
                                                {
                                                    string[] parts = x.Split(';');
                                                    string text = parts[0];
                                                    bool correctAnswer = parts[1] == "Yes"; // "Yes" -> true, "No" -> false
                                                    string explanation = parts[2];

                                                    return new Question(text, correctAnswer, explanation);
                                                }).ToList();

            this.questions = questions;
            this.allowedMistakes = allowedMistakes;
            GameStatus = GameStatus.GameIsInProgress;
        }

        public Question GetNextQuestion()
        {
            return questions[counter];
        }

        public void GiveAnswer(bool answer)
        {
            if (questions[counter].CorrectAnswer != answer)
            {
                mistakes++;
            }

            if (counter == questions.Count - 1 || mistakes > allowedMistakes)
            {
                GameStatus = GameStatus.GameIsOver;
                if (GameOver != null)
                {
                    GameOver(this, new GameResultEventArgs(counter, counter - mistakes, mistakes, mistakes <= allowedMistakes));
                }

            }
            counter++;
        }
    }
}