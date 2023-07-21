using System;

namespace CSBasics
{
    class Overflow
    {
        static void Main(string[] args)
        {
            uint x = uint.MaxValue; // 4294967295

            Console.WriteLine(x); // 4294967295

            x = x + 1; // 0

            Console.WriteLine(x); // 0

            x = x - 1; // 4294967295

            Console.WriteLine(x); // 4294967295

            // It will not give an error or throw an exception,
            // it will just wrap around to the other side of the range.
            // This is called overflow.

            // We can use checked keyword to throw an exception if overflow occurs.
            checked
            {
                uint y = uint.MaxValue; // 4294967295

                Console.WriteLine($"y  = {y}"); // 4294967295

                y = y + 1; // OverflowException is thrown: Arithmetic operation resulted in an overflow.

                Console.WriteLine(y); // 0

                y = y - 1; // 4294967295

                Console.WriteLine(y); // 4294967295
            }

            // Checked keyword usually slows down the program.
            // So, we should use it only when we are sure that overflow will occur.

            // We can also use unchecked keyword to disable overflow checking.

            /*
                In .csproj file:

                <PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Debug|AnyCPU'">
                <CheckForOverflowUnderflow>True</CheckForOverflowUnderflow>
                </PropertyGroup>
 
                <PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Release|AnyCPU'">
                <CheckForOverflowUnderflow>True</CheckForOverflowUnderflow>
                </PropertyGroup>

            */
        }

    }
}
