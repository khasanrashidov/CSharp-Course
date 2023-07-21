using System;

namespace ArraysCollections
{
    class CustomIndexBasedArrays
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Array myArray = Array.CreateInstance(typeof(int), new[] { 5 }, new[] { 1 });
            myArray.SetValue(2019, 1);
            myArray.SetValue(2020, 2);
            myArray.SetValue(2021, 3);
            myArray.SetValue(2022, 4);
            myArray.SetValue(2023, 5);

            Console.WriteLine($"Starting Index: {myArray.GetLowerBound(0)}");
            Console.WriteLine($"Ending Index:{myArray.GetUpperBound(0)}");

            Console.WriteLine();

            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            {
                Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
            }

            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
            }

            Console.WriteLine();

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
        }
    }
}
