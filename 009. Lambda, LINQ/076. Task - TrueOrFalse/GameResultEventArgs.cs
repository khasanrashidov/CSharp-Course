namespace TrueOrFalse
{
    public class GameResultEventArgs: EventArgs
    {
        public int QuestionsPassed { get; set; }
        public int CorrectAnswers { get; set; }
        public int WrongAnswers { get; set; }
        public bool IsWin { get; set; }

        public GameResultEventArgs(int questionsPassed, int correctAnswers, int wrongAnswers, bool isWin)
        {
            QuestionsPassed = questionsPassed;
            CorrectAnswers = correctAnswers;
            WrongAnswers = wrongAnswers;
            IsWin = isWin;
        }
    }
}