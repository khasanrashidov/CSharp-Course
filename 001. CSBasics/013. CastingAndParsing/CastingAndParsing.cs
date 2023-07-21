using System;

namespace CSBasics
{
    class CastingAndParsing
    {
        static void Main(string[] args)
        {
            // Implicit casting
            int i = 123;
            double d = i;
            Console.WriteLine(d);

            // Explicit casting
            double d2 = 123.45;
            int i2 = (int)d2;
            Console.WriteLine(i2);

            // Parsing
            string s = "123";
            int i3 = int.Parse(s); // int.Parse() is a static method
            Console.WriteLine(i3);

            // Parsing with exception handling
            string s2 = "123.45";
            try
            {
                int i4 = int.Parse(s2);
                Console.WriteLine(i4);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // Input string was not in a correct format.
            }

            // TryParse method
            string s3 = "123.45";
            int i5;
            bool result = int.TryParse(s3, out i5);
            if (result)
            {
                Console.WriteLine(i5);
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }

            // TryParse method with exception handling
            string s4 = "123.45";
            int i6;
            try
            {
                bool result2 = int.TryParse(s4, out i6);
                if (result2)
                {
                    Console.WriteLine(i6);
                }
                else
                {
                    Console.WriteLine("Conversion failed.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            byte b = 3; // 0000 0011
            int i7 = b; // 0000 0000 0000 0000 0000 0000 0000 0011
            long l = i7; // 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

            float f = i7; // 3.0

            Console.WriteLine(b);
            Console.WriteLine(i7);
            Console.WriteLine(l);
            Console.WriteLine(f);

            b = (byte)i7;
            Console.WriteLine(b);

            i7 = (int)f;
            Console.WriteLine(i7);

            f = 3.1415926535897932384626433832795f;
            i7 = (int)f;
            Console.WriteLine(i7);

            string str = "1";
            //int i8 = (int)str; // Error
            i7 = Convert.ToInt32(str);
            Console.WriteLine(i7);

            i7 = int.Parse(str);
            Console.WriteLine(i7);

            int x = 7;
            double result3 = (double)x / 2;
            Console.WriteLine(result3);

        }
    }
}
