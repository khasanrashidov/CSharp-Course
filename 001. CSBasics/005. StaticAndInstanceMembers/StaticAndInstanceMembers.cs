using System;

namespace CSBasics
{
    class StaticAndInstanceMembers
    {
        static void Main(string[] args)
        {
            string name = "James";
            bool containsA = name.Contains("a"); // Contains() is an instance method.
            bool containsT = name.Contains("t");

            Console.WriteLine($"name is {name}"); // James
            Console.WriteLine($"Contains a: {containsA}"); // Contains a: True
            Console.WriteLine($"Contains t: {containsT}"); // Contains t: False

            string abcdf = string.Concat("a", "b", "c", "d", "f"); // Concat() is a static method.
            Console.WriteLine(abcdf); // abcdf

            Console.WriteLine(int.MinValue); // MinValue is a static field.

            int x = 12345;
            string xString = x.ToString(); // ToString() is an instance method.
            Console.WriteLine(xString); // 12345
            Console.WriteLine(xString.GetType().Name); // String
            Console.WriteLine(x); // 12345
            Console.WriteLine(x.GetType().Name); // Int32

            // Static members are accessed using the class name.
            // Instance members are accessed using the instance name.

        }
    }
}