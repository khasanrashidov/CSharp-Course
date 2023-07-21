using System;
using System.Text;

namespace CSBasics
{
    class StringBuilderDemo
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello, ");
            sb.Append("my");
            sb.Append(" name");
            sb.Append(" is");
            sb.Append(" John");
            sb.AppendLine("!");
            sb.AppendLine("I am");
            sb.AppendLine(" a");
            sb.AppendLine(" software-engineer");

            string str = sb.ToString();
            Console.WriteLine(str);

            Console.ReadKey();

            // String Builder is a mutable string and 
            // it is more efficient when we add a lot of strings.
            // It is not thread-safe.
            // Thread-safe means that the object can be used by multiple threads at the same time.
            
            // String Builder is a class and it is in the System.Text namespace.

        }
    }
}