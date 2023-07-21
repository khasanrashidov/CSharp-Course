using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelXTerminal terminal = new ModelXTerminal("123");
            terminal.Connect();
        }
    }
}