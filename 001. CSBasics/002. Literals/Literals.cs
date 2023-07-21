using System;

namespace CSBasics
{
    class Literals
    {
        static void Main(string[] args)
        {
            int x = 0b11; // 3 in binary
            int y = 0b1001; // 9 in binary
            int k = 0b10001001; // 137 in binary
            int z = 0b1000_1001; // 137 in binary, _ is ignored

            Console.WriteLine("x = {0}\ny = {1}\nk = {2}\nz = {3}", x, y, k, z);
            Console.WriteLine();

            x = 0x1F; // 31 in hexadecimal
            y = 0xFF0D; // 65261 in hexadecimal
            k = 0x1FAB30EF; // 530, 000, 239 in hexadecimal
            z = 0x1FAB_30EF; // 530, 000, 239 in hexadecimal, _ is ignored

            Console.WriteLine("x = {0}\ny = {1}\nk = {2}\nz = {3}", x, y, k, z);
            Console.WriteLine();

            Console.WriteLine(4.5e2); // 4.5 * 10^2 = 450
            Console.WriteLine(3.1e-2); // 3.1 * 10^-2 = 0.031
            Console.WriteLine(1.2e+3); // 1.2 * 10^3 = 1200
            Console.WriteLine(1.2e3); // 1.2 * 10^3 = 1200
            Console.WriteLine();

            Console.WriteLine(0.1 + 0.2); // 0.30000000000000004
            Console.WriteLine(0.1 + 0.2 == 0.3); // false
            Console.WriteLine();

            // \x - hexadecimal escape sequence
            Console.WriteLine('\x78'); // x
            Console.WriteLine('\x5A'); // Z

            // \u - unicode escape sequence
            Console.WriteLine('\u0420'); // Р
            Console.WriteLine('\u0421'); // С
            Console.WriteLine('\u0422'); // Т
            Console.WriteLine('\u0423'); // У
            Console.WriteLine('\u0424'); // Ф
        }
    }
}