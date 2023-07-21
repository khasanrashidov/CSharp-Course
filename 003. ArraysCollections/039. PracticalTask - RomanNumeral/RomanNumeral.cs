using System;
using System.Collections.Generic;

namespace ArraysCollections
{
    class RomanNumeral
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(Parse("I"));
            Console.WriteLine(Parse("II"));
            Console.WriteLine(Parse("III"));
            Console.WriteLine(Parse("IV"));
            Console.WriteLine(Parse("V"));
            Console.WriteLine(Parse("VI"));
            Console.WriteLine(Parse("VII"));
            Console.WriteLine(Parse("VIII"));
            Console.WriteLine(Parse("IX"));
            Console.WriteLine(Parse("X"));
            Console.WriteLine(Parse("XI"));
            Console.WriteLine(Parse("XII"));
            Console.WriteLine(Parse("XIII"));
            Console.WriteLine(Parse("XIV"));
            Console.WriteLine(Parse("XV"));
            Console.WriteLine(Parse("XCIX"));
            Console.WriteLine(Parse("IC")); // Invalid
            Console.WriteLine(Parse("MCMXC"));
            Console.WriteLine(Parse("MCMXCIV"));
            Console.WriteLine(Parse("MCMXCVI"));
            Console.WriteLine(Parse("MCMXCVII"));
            Console.WriteLine(Parse("MCMXCVIII"));
            Console.WriteLine(Parse("MCMXCIX"));
            Console.WriteLine(Parse("MM"));

            Console.WriteLine(Parse("XLIX")); // 49
            Console.WriteLine(Parse("IL")); // Invalid

            // 40
            Console.WriteLine(Parse("XL")); // 40
            // 41
            Console.WriteLine(Parse("XLI")); // 41
            // 42
            Console.WriteLine(Parse("XLII")); // 42
            // 43
            Console.WriteLine(Parse("XLIII")); // 43
            // 44
            Console.WriteLine(Parse("XLIV")); // 44
            // 45
            Console.WriteLine(Parse("XLV"));
            // 46
            Console.WriteLine(Parse("XLVI"));
            // 47
            Console.WriteLine(Parse("XLVII"));
            // 48
            Console.WriteLine(Parse("XLVIII"));
            // 49
            Console.WriteLine(Parse("XLIX"));
            // 50
            Console.WriteLine(Parse("L"));
            // 51
            Console.WriteLine(Parse("LI"));
            // 52
            Console.WriteLine(Parse("LII"));
            // 53
            Console.WriteLine(Parse("LIII"));
            // 54
            Console.WriteLine(Parse("LIV"));
            // 55
            Console.WriteLine(Parse("LV"));
            // 56
            Console.WriteLine(Parse("LVI"));
            // 57
            Console.WriteLine(Parse("LVII"));
            // 58
            Console.WriteLine(Parse("LVIII"));
            // 59
            Console.WriteLine(Parse("LIX"));
            // 60
            Console.WriteLine(Parse("LX"));
            // 61
            Console.WriteLine(Parse("LXI"));
            // 62
            Console.WriteLine(Parse("LXII"));
            // 63
            Console.WriteLine(Parse("LXIII"));
            // 64
            Console.WriteLine(Parse("LXIV"));
            // 65
            Console.WriteLine(Parse("LXV"));
            // 66
            Console.WriteLine(Parse("LXVI"));
            // 67
            Console.WriteLine(Parse("LXVII"));
            // 68
            Console.WriteLine(Parse("LXVIII"));
            // 69
            Console.WriteLine(Parse("LXIX"));
            // 70
            Console.WriteLine(Parse("LXX"));
            // 71
            Console.WriteLine(Parse("LXXI"));
            // 72
            Console.WriteLine(Parse("LXXII"));
            // 73
            Console.WriteLine(Parse("LXXIII"));
            // 74
            Console.WriteLine(Parse("LXXIV"));
            // 75
            Console.WriteLine(Parse("LXXV"));
            // 76
            Console.WriteLine(Parse("LXXVI"));
            // 77
            Console.WriteLine(Parse("LXXVII"));
            // 78
            Console.WriteLine(Parse("LXXVIII"));
            // 79
            Console.WriteLine(Parse("LXXIX"));
            // 80
            Console.WriteLine(Parse("LXXX"));
            // 81
            Console.WriteLine(Parse("LXXXI"));
            // 82
            Console.WriteLine(Parse("LXXXII"));
            // 83
            Console.WriteLine(Parse("LXXXIII"));
            // 84
            Console.WriteLine(Parse("LXXXIV"));
            // 85
            Console.WriteLine(Parse("LXXXV"));
            // 86
            Console.WriteLine(Parse("LXXXVI"));
            // 87
            Console.WriteLine(Parse("LXXXVII"));
            // 88
            Console.WriteLine(Parse("LXXXVIII"));
            // 89
            Console.WriteLine(Parse("LXXXIX"));
            // 90
            Console.WriteLine(Parse("XC"));
            // 91
            Console.WriteLine(Parse("XCI"));
            // 92
            Console.WriteLine(Parse("XCII"));
            // 93
            Console.WriteLine(Parse("XCIII"));
            // 94
            Console.WriteLine(Parse("XCIV"));
            // 95
            Console.WriteLine(Parse("XCV"));
            // 96
            Console.WriteLine(Parse("XCVI"));
            // 97
            Console.WriteLine(Parse("XCVII"));
            // 98
            Console.WriteLine(Parse("XCVIII"));
            // 99
            Console.WriteLine(Parse("XCIX"));
            // 100
            Console.WriteLine(Parse("C"));
            // 101
            Console.WriteLine(Parse("CI"));
            // 102
            Console.WriteLine(Parse("CII"));
            // 103
            Console.WriteLine(Parse("CIII"));
            // 104
            Console.WriteLine(Parse("CIV"));

            // Invalid Roman Numbers
            Console.WriteLine(Parse("IL"));
            Console.WriteLine(Parse("IC"));
            Console.WriteLine(Parse("ID"));
            Console.WriteLine(Parse("IM"));
            Console.WriteLine(Parse("XD"));
            Console.WriteLine(Parse("XM"));
            Console.WriteLine(Parse("VX"));
            Console.WriteLine(Parse("LC"));
            Console.WriteLine(Parse("LD"));
            Console.WriteLine(Parse("LM"));
            Console.WriteLine(Parse("DM"));
            Console.WriteLine(Parse("DD"));
            Console.WriteLine(Parse("LL"));
            Console.WriteLine(Parse("VV"));
            Console.WriteLine(Parse("IIII"));
            Console.WriteLine(Parse("XXXX"));
            Console.WriteLine(Parse("CCCC"));

            Console.WriteLine(Parse("VIV"));
            Console.WriteLine(Parse("LXL"));
            Console.WriteLine(Parse("DCD"));
            Console.WriteLine(Parse("IIX"));
            Console.WriteLine(Parse("IIV"));
            Console.WriteLine(Parse("IIL"));
            Console.WriteLine(Parse("IIC"));
            Console.WriteLine(Parse("IID"));
            Console.WriteLine(Parse("IIM"));
            Console.WriteLine(Parse("XXC"));
            Console.WriteLine(Parse("XXL"));
            Console.WriteLine(Parse("XXD"));
            Console.WriteLine(Parse("XXM"));
            Console.WriteLine(Parse("CCM"));
        }

        public static int Parse(string roman)
        {
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };

            int arabic = 0;

            // loop through the string
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && (map[roman[i]] < map[roman[i + 1]]))
                {
                    // if the next character is greater than the current character
                    // subtract the current character from the total
                    arabic -= map[roman[i]];
                }
                else
                {
                    // otherwise add the current character to the total
                    arabic += map[roman[i]];
                }
            }

            if (roman.Length > 1 && (roman[1] == 'L' || roman[1] == 'C' || roman[1] == 'D' || roman[1] == 'M'))
            {
                if (roman[0] == 'I' || roman[0] == 'V')
                {
                    Console.Write($"Error: {roman} is not a valid roman numeral: ");
                    return 0;
                }
            }

            // if length is 2 and second element is D
            // then first element cannot be X, I, V, L
            if (roman.Length == 2 && roman[1] == 'D')
            {
                if (roman[0] == 'X' || roman[0] == 'I' || roman[0] == 'V' || roman[0] == 'L')
                {
                    Console.Write($"Error: {roman} is not a valid roman numeral: ");
                    return 0;
                }
            }

            // if length is 2 and second element is M
            // then first element cannot be X, I, V, L, D
            if (roman.Length == 2 && roman[1] == 'M')
            {
                if (roman[0] == 'X' || roman[0] == 'I' || roman[0] == 'V' || roman[0] == 'L' || roman[0] == 'D')
                {
                    Console.Write($"Error: {roman} is not a valid roman numeral: ");
                    return 0;
                }
            }

            // VV is not valid
            // LL is not valid
            // DD is not valid
            // IIII is not valid
            // XXXX is not valid
            // CCCC is not valid
            if (roman.Length > 1)
            {
                if (roman[0] == 'V' && roman[1] == 'V')
                {
                    Console.Write($"Error: {roman} is not a valid roman numeral: ");
                    return 0;
                }
                else if (roman[0] == 'L' && roman[1] == 'L')
                {
                    Console.Write($"Error: {roman} is not a valid roman numeral: ");
                    return 0;
                }
                else if (roman[0] == 'D' && roman[1] == 'D')
                {
                    Console.Write($"Error: {roman} is not a valid roman numeral: ");
                    return 0;
                }
                else if (roman.Length > 3)
                {
                    if (roman[0] == 'I' && roman[1] == 'I' && roman[2] == 'I' && roman[3] == 'I')
                    {
                        Console.Write($"Error: {roman} is not a valid roman numeral: ");
                        return 0;
                    }
                    else if (roman[0] == 'X' && roman[1] == 'X' && roman[2] == 'X' && roman[3] == 'X')
                    {
                        Console.Write($"Error: {roman} is not a valid roman numeral: ");
                        return 0;
                    }
                    else if (roman[0] == 'C' && roman[1] == 'C' && roman[2] == 'C' && roman[3] == 'C')
                    {
                        Console.Write($"Error: {roman} is not a valid roman numeral: ");
                        return 0;
                    }
                }

                // if length is 2 and second number is X
                // then first number cannot be V
                if (roman.Length == 2 && roman[1] == 'X')
                {
                    if (roman[0] == 'V')
                    {
                        Console.Write($"Error: {roman} is not a valid roman numeral: ");
                        return 0;
                    }
                }

                // if length is 2 and second number is C
                // then first number cannot be L
                if (roman.Length == 2 && roman[1] == 'C')
                {
                    if (roman[0] == 'L')
                    {
                        Console.Write($"Error: {roman} is not a valid roman numeral: ");
                        return 0;
                    }
                }

                // if length is 2 and both numbers are VV, LL, DD
                // then it is invalid
                if (roman.Length == 2 && roman[0] == roman[1] && (roman[0] == 'V' || roman[0] == 'L' || roman[0] == 'D'))
                {
                    Console.Write($"Error: {roman} is not a valid roman numeral: ");
                    return 0;
                }
            }

            // return the total
            return arabic;
        }
    }
}
