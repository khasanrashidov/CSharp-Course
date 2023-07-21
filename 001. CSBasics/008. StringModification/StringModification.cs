using System;

namespace CSBasics
{
    class StringModification
    {
        static void Main(string[] args)
        {
            string nameConcat = string.Concat("My ", "name ", "is ", "John");
            Console.WriteLine(nameConcat);

            nameConcat = string.Join(" ", "My", "name", "is", "John");
            Console.WriteLine(nameConcat);

            nameConcat = "My " + "name " + "is " + "John";
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Insert(0, "Hello, ");
            Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Remove(0, 10);
            Console.WriteLine(nameConcat);

            string replaced = nameConcat.Replace("John", "Jack");
            Console.WriteLine(replaced);

            string data = "12;34;56;78;90";
            string[] dataSplit = data.Split(';');
            foreach (string item in dataSplit)
            {
                Console.WriteLine(item);
            }
            string first = dataSplit[0];
            string last = dataSplit[dataSplit.Length - 1];
            Console.WriteLine("First: {0}, Last: {1}", first, last);

            char[] chars = nameConcat.ToCharArray();
            foreach (char item in chars)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("First: {0}, Last: {1}", chars[0], chars[chars.Length - 1]);
            Console.WriteLine("First: {0}, Last: {1}", nameConcat[0], nameConcat[nameConcat.Length - 1]);

            // Difference between string and char array
            // is that string is immutable
            // and char array is mutable
            chars[0] = 'H';
            Console.WriteLine(chars);

            // string is immutable
            // nameConcat[0] = 'H';
            // Console.WriteLine(nameConcat); // Error

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            string trim = "   Hello, John   ";
            Console.WriteLine("Before trim: {0}", trim);
            trim = trim.Trim();
            Console.WriteLine("After trim: {0}", trim);

            string sub = nameConcat.Substring(7);
            Console.WriteLine(sub);

            sub = nameConcat.Substring(7, 4);
            Console.WriteLine(sub);

            string[] names = { "John", "Jack", "Jill" };
            string namesConcat = string.Join(", ", names);
            Console.WriteLine(namesConcat);


        }
    }
}
