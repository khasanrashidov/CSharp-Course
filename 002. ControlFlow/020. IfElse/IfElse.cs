using System;

namespace ControlFlow
{
    class IfElse
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("====================================");
            // Get the user's weight and height
            Console.WriteLine("BMI Calculator");
            Console.WriteLine("====================================");
            Console.Write("Enter your age:   ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your weight in kg:   ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your height in cm:   ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Calculate BMI
            double bmi = weight / Math.Pow(height / 100, 2);

            Console.Clear(); // Clear the console
            Console.ForegroundColor = ConsoleColor.Green; // Set the foreground color to green
            Console.BackgroundColor = ConsoleColor.Black; // Set the background color to black

            // BMI Categories
            bool isLow = bmi < 18.5;
            bool isNormal = bmi >= 18.5 && bmi < 25;
            bool isHigh = bmi >= 25 && bmi < 30;
            bool isVeryHigh = bmi >= 30;

            Console.WriteLine("====================================");

            // Display the user's age: adult or not
            string ageCategory = age >= 18 ? "an adult" : "not an adult";
            Console.WriteLine("You are {0}.", ageCategory);

            // Display the BMI
            Console.WriteLine($"Your BMI is {bmi:f2}.");
            
            // Display the BMI Category
            if (isLow)
            {
                Console.WriteLine("You are underweight.");
            }
            else if (isNormal)
            {
                Console.WriteLine("Your weight is normal.");
            }
            else if (isHigh)
            {
                Console.WriteLine("You are overweight.");
            }
            else if (isVeryHigh)
            {
                Console.WriteLine("You are obese.");
            }
            else
            {
                Console.WriteLine("Invalid BMI.");
            }

            Console.WriteLine("====================================");
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
