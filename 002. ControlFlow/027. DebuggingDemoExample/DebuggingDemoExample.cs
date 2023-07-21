using System;

namespace ControlFlow
{
    class DebuggingDemoExample
    {
        static void Main(string[] args)
        {
            // Debugging is the process of finding and fixing bugs in a program.
            // A bug is an error in a program.

            // There are two types of bugs:
            // 1. Syntax errors - errors in the syntax of the code
            // 2. Logical errors - errors in the logic of the code

            // Following changes are made to JSON file to debug the program in VS Code
            // In .vscode folder, open launch.json file and make the following changes:
            // "console": "integratedTerminal"


            Console.WriteLine("Enter the length of the first side:");
            double a = GetDouble();
            Console.WriteLine("Enter the length of the second side:");
            double b = GetDouble();
            Console.WriteLine("Enter the length of the third side:");
            double c = GetDouble();

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine($"The area of the triangle is {area:f2}.");

        }
        static double GetDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}