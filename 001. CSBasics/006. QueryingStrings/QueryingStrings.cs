using System;
using System.Collections.Generic;

namespace CSBasics
{
    class QueryingStrings
    {
        static void Main(string[] args)
        {
            string name = "James";
            bool containsA = name.Contains("a"); // Contains() is an instance method.
            bool containsT = name.Contains("T"); // Contains() is an instance method.

            Console.WriteLine($"name is {name}"); // James
            Console.WriteLine($"Contains a: {containsA}"); // Contains a: True
            Console.WriteLine($"Contains t: {containsT}"); // Contains t: False

            bool endsWithMes = name.EndsWith("mes"); // EndsWith() is an instance method.
            Console.WriteLine($"Ends with mes: {endsWithMes}"); // Ends with mes: True

            bool startsWithJa = name.StartsWith("Ja"); // StartsWith() is an instance method.
            Console.WriteLine($"Starts with Ja: {startsWithJa}"); // Starts with Ja: True

            int indexOfA = name.IndexOf("a"); // IndexOf() is an instance method.
            Console.WriteLine($"Index of a: {indexOfA}"); // Index of a: 1

            int indexOfA2 = name.IndexOf("a", 2); // IndexOf() is an instance method.
            Console.WriteLine($"Index of a: {indexOfA2}"); // returns -1 if not found

            int lastIndexOfE = name.LastIndexOf("e"); // LastIndexOf() is an instance method.
            Console.WriteLine($"Last index of e: {lastIndexOfE}"); // Last index of e: 3

            Console.WriteLine($"Length of name: {name.Length}"); // Length is a property. Length of name: 5
            
            string subStringFrom2 = name.Substring(2); // Substring() is an instance method.
            Console.WriteLine($"Substring from 2: {subStringFrom2}"); // Substring from 2: mes
            string subStringFrom1To3 = name.Substring(1, 3); // Substring() is an instance method.
            Console.WriteLine($"Substring from 1 to 3: {subStringFrom1To3}"); // Substring from 1 to 3: ame

            string fullName = "James Bond";
            string[] names = fullName.Split(' '); // Split() is an instance method.
            Console.WriteLine($"First name: {names[0]}"); // First name: James
            Console.WriteLine($"Last name: {names[1]}"); // Last name: Bond

            string lowerCaseName = name.ToLower(); // ToLower() is an instance method.
            Console.WriteLine($"Lower case name: {lowerCaseName}"); // Lower case name: james

            string upperCaseName = name.ToUpper(); // ToUpper() is an instance method.
            Console.WriteLine($"Upper case name: {upperCaseName}"); // Upper case name: JAMES

            string trimmedName = " James ".Trim(); // Trim() is an instance method.
            Console.WriteLine($"Trimmed name: {trimmedName}"); // Trimmed name: James

            string nameWithSpaces = "James Bond";
            string trimmedNameWithSpaces = nameWithSpaces.Trim(); // Trim() is an instance method.
            Console.WriteLine($"Trimmed name with spaces: {trimmedNameWithSpaces}"); // Trimmed name with spaces: James Bond

            // String interpolation
            string firstName = "James";
            string lastName = "Bond";
            string fullName2 = $"{firstName} {lastName}"; // String interpolation
            Console.WriteLine($"Full name: {fullName2}"); // Full name: James Bond

            // String Replace method
            string nameWithSpaces2 = "James Bond";
            string nameWithoutSpaces = nameWithSpaces2.Replace(" ", ""); // Replace() is an instance method.
            Console.WriteLine($"Name without spaces: {nameWithoutSpaces}"); // Name without spaces: JamesBond

            string nameWithSpaces3 = "James Bond";
            string nameWithoutSpaces2 = nameWithSpaces3.Replace(" ", string.Empty); // Replace() is an instance method.
            Console.WriteLine($"Name without spaces: {nameWithoutSpaces2}"); // Name without spaces: JamesBond

            string nameWithSpaces4 = "James Bond";
            string nameWithoutSpaces3 = nameWithSpaces4.Replace(" ", null); // Replace() is an instance method.
            Console.WriteLine($"Name without spaces: {nameWithoutSpaces3}"); // Name without spaces: JamesBond

            // String comparison
            string name1 = "James";
            string name2 = "James";
            bool isEqual = name1 == name2; // String comparison
            Console.WriteLine($"Is equal: {isEqual}"); // Is equal: True

            string name3 = "James";
            string name4 = "james";
            bool isEqual2 = name3 == name4; // String comparison
            Console.WriteLine($"Is equal: {isEqual2}"); // Is equal: False

            string name5 = "James";
            string name6 = "james";
            bool isEqual3 = name5.Equals(name6); // String comparison
            Console.WriteLine($"Is equal: {isEqual3}"); // Is equal: False

        }
    }
}
