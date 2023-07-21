using System;

namespace CSBasics
{
    class StringEmptiness
    {
        static void Main(string[] args)
        {
            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " A";
            string? nullString = null;
            string str = string.Empty; // string.Empty is a static field.
            // string.Empty is same as "".

            Console.WriteLine("IsNullOrEmpty");
            bool isNullOrEmpty = string.IsNullOrEmpty(nullString); // IsNullOrEmpty() is a static method.
            Console.WriteLine($"nullString is null or empty: {isNullOrEmpty}"); // True

            isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced); 
            Console.WriteLine($"whiteSpaced is null or empty: {isNullOrEmpty}"); // False

            isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine($"notEmpty is null or empty: {isNullOrEmpty}"); // False

            isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine($"empty is null or empty: {isNullOrEmpty}"); // True

            Console.WriteLine();

            Console.WriteLine("IsNullOrWhiteSpace");
            bool IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString); // IsNullOrWhiteSpace() is a static method.
            Console.WriteLine($"nullString is null or white space: {IsNullOrWhiteSpace}"); // True

            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine($"whiteSpaced is null or white space: {IsNullOrWhiteSpace}"); // True

            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine($"notEmpty is null or white space: {IsNullOrWhiteSpace}"); // False

            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine($"empty is null or white space: {IsNullOrWhiteSpace}"); // True

            // Difference between IsNullOrEmpty and IsNullOrWhiteSpace
            // IsNullOrEmpty returns true if the string is null or empty.
            // IsNullOrWhiteSpace returns true if the string is null or white space.
            // White space is a string that contains only white space characters.
            // White space characters are: space, tab, new line, carriage return, form feed, and vertical tab.

        }
    }
}