using System;

namespace CSBasics
{
    class IntroToArrays
    {
        static void Main(string[] args)
        {
            int[] numbers;
            numbers = new int[6];

            int[] numbers2 = new int[6];

            int[] numbers3 = new int[6] { 1, 2, 3, 4, 5, 6 };

            int[] numbers4 = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("numbers[0] = {0}", numbers[0]);

            int number = numbers[4];
            Console.WriteLine("number = {0}", number);

            numbers[5] = 10;
            Console.WriteLine("numbers[5] = {0}", numbers[5]);

            // Length of the array: Length property
            Console.WriteLine("numbers.Length = {0}", numbers.Length);

            // First element (index = 0)
            Console.WriteLine("numbers[0] = {0}", numbers[0]);
            // Last element (index = length - 1)
            Console.WriteLine("numbers[numbers.Length - 1] = {0}", numbers[numbers.Length - 1]);

            string text = "Hello";
            char firstLetter = text[0];
            char lastLetter = text[text.Length - 1];

            Console.WriteLine($"First letter: {firstLetter}, Last letter: {lastLetter}");

            // Impossible to change the value of a character in a strings
            //text[0] = 'h'; // Error

            // Possible to change the value of a character in a char array
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            letters[0] = 'h';
            Console.WriteLine(letters);
        }
    }
}
