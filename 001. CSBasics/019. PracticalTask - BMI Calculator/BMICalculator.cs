using System;

namespace CSBasics
{
    class BMICalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User's data with BMI calculator");
            Console.WriteLine("Enter your first name:");
            string? firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string? lastName = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your weight in kg:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in cm:");
            double height = Convert.ToDouble(Console.ReadLine());
            double bmi = weight / Math.Pow(height / 100, 2);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            string profile =
                $"User's Profile:{Environment.NewLine}" +
                $"Full Name: {firstName} {lastName}{Environment.NewLine}" +
                $"Age: {age}{Environment.NewLine}" +
                $"Weight: {weight} kg{Environment.NewLine}" +
                $"Height: {height} cm{Environment.NewLine}" +
                $"Body Mass Index: {bmi}{Environment.NewLine}";

            Console.WriteLine(profile);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
