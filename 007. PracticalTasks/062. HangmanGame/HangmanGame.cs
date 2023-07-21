using System;
using System.IO;

namespace PracticalTasks.HangmanGame
{
    class HangmanGame
    {
        public readonly int maxAttempts;
        private bool[]? guessedLetters; // open indexes
        private int attemptsCount;
        private string triedLetters;

        public HangmanGameStatus GameStatus { get; private set; } = HangmanGameStatus.NotStarted;

        public string Word { get; private set; }

        public string TriedLetters
        {
            get
            {
                var chars = triedLetters.ToCharArray();
                Array.Sort(chars);
                return new string(chars);
            }
        }

        public HangmanGame(int maxAttempts = 6)
        {
            if (maxAttempts < 5 || maxAttempts > 8)
            {
                throw new ArgumentException("Number of attempts must be between 5 and 8", nameof(maxAttempts));
                // nameof(maxAttempts) - returns the name of the parameter
                // We can use nameof() to avoid hardcoding the name of the parameter in the exception message
                // Hardcoding means that if we change the name of the parameter, 
                // we will have to change the message as well
                // so it's better to use nameof() to avoid this
            }
            this.maxAttempts = maxAttempts;
        }

        public string GenerateWord()
        {
            string[] allWords = File.ReadAllLines("EnglishWords.txt");
            Random random = new Random(DateTime.Now.Millisecond);
            // DateTime.Now.Millisecond - returns the current time in milliseconds
            // Random(int seed) - creates a new instance of the Random class, using the specified seed value
            // The seed value is used to calculate a starting value for the pseudo-random number sequence
            // If we use the same seed value, we will get the same sequence of random numbers
            // So we use DateTime.Now.Millisecond to get a different seed value every time we run the program
            int randomIndex = random.Next(0, allWords.Length - 1);
            Word = allWords[randomIndex];
            guessedLetters = new bool[Word.Length]; // all indexes are false by default
            GameStatus = HangmanGameStatus.InProgress; // the game has started

            return Word;
        }

        public string GuessLetter(char letter)
        {
            if (GameStatus != HangmanGameStatus.InProgress)
            {
                throw new InvalidOperationException($"The game is not in progress. Current status: {GameStatus}");
            }
            if (attemptsCount == maxAttempts)
            {
                GameStatus = HangmanGameStatus.Lost;
                return Word;
            }

            bool isLetterGuessed = false;
            string result = string.Empty; // the same as ""
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == letter)
                {
                    guessedLetters[i] = true;
                    isLetterGuessed = true;
                }
                if (guessedLetters[i])
                {
                    result += " " + Word[i] + " ";
                }
                else
                {
                    result += " _ ";
                }
            }

            if (!isLetterGuessed)
            {
                attemptsCount++;
            }

            triedLetters += letter;

            if (IsWordGuessed())
            {
                GameStatus = HangmanGameStatus.Won;
            }
            else if (attemptsCount == maxAttempts)
            {
                GameStatus = HangmanGameStatus.Lost;
            }

            return result;
        }

        private bool IsWordGuessed()
        {
            foreach (bool isLetterGuessed in guessedLetters)
            {
                // if at least one letter is not guessed, the word is not guessed
                // in this case we return false
                if (!isLetterGuessed)
                {
                    return false;
                }
            }
            // if all letters are guessed, the word is guessed
            // in this case we return true
            return true;
        }

        public void Reset()
        {
            GameStatus = HangmanGameStatus.NotStarted;
            Word = string.Empty;
            guessedLetters = null;
            attemptsCount = 0;
            triedLetters = string.Empty;
        }

        public int AttemptsLeft => maxAttempts - attemptsCount;

        public void DrawHangman()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            if (attemptsCount > 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine("Hangman Game");
            Console.WriteLine("============");
            Console.WriteLine();
            Console.WriteLine("  +---+");
            Console.WriteLine("  |   |");
            Console.WriteLine("  {0}   |", attemptsCount > 0 ? "O" : " ");
            Console.WriteLine(" {0}{1}{2}  |", attemptsCount > 3 ? "/" : " ", attemptsCount > 1 ? "|" : " ", attemptsCount > 4 ? "\\" : " ");
            Console.WriteLine(" {0} {1}  |", attemptsCount > 2 ? "/" : " ", attemptsCount > 5 ? "\\" : " ");
            Console.WriteLine("      |");
            Console.WriteLine("============");
            Console.WriteLine();
        }
    }
}