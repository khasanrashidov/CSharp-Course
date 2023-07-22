namespace TrueOrFalse
{
    public class Question
    {
        public string Text { get; set; } = null!;
        public bool CorrectAnswer { get; set; }
        public string Explanation { get; set; } = null!;

        public Question(string text, bool correctAnswer, string explanation)
        {
            Text = text;
            CorrectAnswer = correctAnswer;
            Explanation = explanation;
        }
    }
}