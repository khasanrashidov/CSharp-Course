using System;

namespace CSBasics
{
    class VariableScope
    {
        static void Main(string[] args)
        {
            var a = 1;
            {
                var b = 2;
                {
                    var c = 3;
                    Console.WriteLine("var a = " + a);
                    Console.WriteLine("var b = " + b);
                    Console.WriteLine("var c = " + c);
                }
                Console.WriteLine("var a = " + a);
                Console.WriteLine("var b = " + b);
                // Console.WriteLine("var c = " + c); // Error: The name 'c' does not exist in the current context
            }
            Console.WriteLine("var a = " + a);
            // Console.WriteLine("var b = " + b); // Error: The name 'b' does not exist in the current context
            // Console.WriteLine("var c = " + c); // Error: The name 'c' does not exist in the current context
        }
    }
}