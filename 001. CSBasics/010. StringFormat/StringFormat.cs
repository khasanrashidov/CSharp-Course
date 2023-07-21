using System;
using System.Text;

namespace CSBasics
{
    class StringFormat
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 25;
            string str1 = string.Format("My name is {0} and I am {1} years old.", name, age);
            string str2 = string.Format("My name is {0} and I am {1} years old.", "John", 25);
            string str3 = $"My name is {name} and I am {age} years old.";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);

            string str4 = "My name is \nJohn.";
            string str5 = "I am \t25 years old.";
            Console.WriteLine(str4);
            Console.WriteLine(str5);

            // Environment.NewLine is a constant that represents the newline character for the current operating system.
            // It is equivalent to \r\n on Windows and \n on Unix.
            // It is good to use Environment.NewLine for cross-platform compatibility.

            string str6 = $"My name is {Environment.NewLine}John.";
            Console.WriteLine(str6);

            string str7 = "I am John and I am a \"good\" programmer.";
            Console.WriteLine(str7);

            string path = "C:\\Windows\\System32";
            string path2 = @"C:\Windows\System32";
            Console.WriteLine(path);
            Console.WriteLine(path2);
            
            int answer = 42;
            string str8 = string.Format("The answer is {0:D}", answer);
            Console.WriteLine(str8);
            string str9 = string.Format("The answer is {0:D4}", answer);
            Console.WriteLine(str9);

            double pi = 3.14159265359;
            string str10 = string.Format("Pi is {0:F}", pi); // By default, the number of decimal places is 2.
            Console.WriteLine(str10);
            string str11 = string.Format("Pi is {0:F4}", pi);
            Console.WriteLine(str11);

            double money = 123456789.123456789;
            string str12 = string.Format("Money is {0:C}", money); // By default, the number of decimal places is 2.
            Console.WriteLine(str12);
            string str13 = string.Format("Money is {0:C5}", money);
            Console.WriteLine(str13);

            Console.WriteLine("Money is " + money.ToString("C4"));

            Console.WriteLine($"Money is {money:C3}");
            
    
            Console.OutputEncoding = Encoding.UTF8;
            // Change the current culture to Russian.
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");
            Console.WriteLine($"Money is {money:C3}");

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("uz-Cyrl-UZ");
            Console.WriteLine($"Money is {money:C3}");

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("eu-ES");
            Console.WriteLine($"Money is {money:C3}");
            
            
        }
        
    }
}