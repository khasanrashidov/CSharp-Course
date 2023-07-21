using System;
using System.Text;

namespace CSBasics
{
    class StringComparison
    {
        static void Main(string[] args)
        {
            string str1 = "abcd";
            string str2 = "abcd";

            bool areEqual = str1 == str2;
            Console.WriteLine(areEqual);

            areEqual = str1.Equals(str2);
            Console.WriteLine(areEqual);

            areEqual = string.Equals(str1, str2);
            Console.WriteLine(areEqual);

            areEqual = string.Equals(str1, str2, System.StringComparison.Ordinal);
            Console.WriteLine(areEqual);

            Console.WriteLine("--------------------");

            string str3 = "Strasse";
            string str4 = "Straße";

            areEqual = str3 == str4;
            Console.WriteLine(areEqual);
            areEqual = string.Equals(str3, str4, System.StringComparison.Ordinal);
            Console.WriteLine(areEqual);
            areEqual = string.Equals(str3, str4, System.StringComparison.InvariantCulture);
            Console.WriteLine(areEqual);
            areEqual = string.Equals(str3, str4, System.StringComparison.CurrentCulture);
            Console.WriteLine(areEqual);

            // Ordinal is the fastest, but it is case-sensitive and culture-sensitive.
            // It is good for comparing strings that are known to be in the same culture.
            // It compares strings by comparing the numeric values of the corresponding Char objects in each string.

            // InvariantCulture is culture-insensitive and case-insensitive.
            // It is good for comparing strings that are known to be in the same culture, and whose case may differ.
   
            // CurrentCulture is culture-sensitive and case-sensitive.
        }
    }
}