using System;
using System.Collections.Generic;

namespace CSBasics
{
    class Variables
    {
        static void Main(string[] args)
        {
            int x = -1;
            int y; // 0 by default
            y = 2; // now y is 2

            Int32 x1 = -1; // same as int

            uint x2 = 1; // unsigned int
            // uint x3 = -1; // error

            float f = 1.1f; // 32-bit float, f in the end of the number is required
            double d = 2.3; // 64-bit float

            int x4 = 0;
            int x5 = new int(); // 0 by default, the same as x4

            var x6 = 1; // int
            var x7 = 1.2; // double
            var x8 = "Hello"; // string
            // var x9; // error, var must be initialized

            Dictionary<int, string> dict = new Dictionary<int, string>();
            // can be written as
            var dict1 = new Dictionary<int, string>();

            decimal money = 1.2m; // 128-bit float, m in the end of the number is required

            char character = 'A'; // single character

            string name = "John"; // string

            bool canDrive = true; // boolean
            bool canDraw = false;

            object obj1 = 1; // object can hold any type of data
            object obj2 = "Object 2";

            // cw is a shortcut for Console.WriteLine()

            char @char = 'A'; // @ is used to escape keywords
            int @int = 1;
            string @string = "String";
            double @double = 1.23456789;
            float @float = 1.2345f;
            decimal @decimal = 3.0m;

            Console.WriteLine("x = {0}, y = {1}", x, y);
            Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
            Console.WriteLine("f = {0}, d = {1}", f, d);
            Console.WriteLine("x4 = {0}, x5 = {1}", x4, x5);
            Console.WriteLine("x6 = {0}, x7 = {1}, x8 = {2}", x6, x7, x8);
            Console.WriteLine("money = {0}", money);
            Console.WriteLine("character = {0}", character);
            Console.WriteLine("name = {0}", name);
            Console.WriteLine("canDrive = {0}, canDraw = {1}", canDrive, canDraw);
            Console.WriteLine("obj1 = {0}, obj2 = {1}", obj1, obj2);
            Console.WriteLine("@char = {0}, @int = {1}, @string = {2}, @double = {3}, @float = {4}, @decimal = {5}",
                                @char, @int, @string, @double, @float, @decimal);

            Console.ReadKey();
        }

    }
}