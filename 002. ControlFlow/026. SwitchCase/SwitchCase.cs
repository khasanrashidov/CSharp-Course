using System;

namespace ControlFlow
{
    class SwitchCase
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of years of your wedding: ");
            int weddingYears = int.Parse(Console.ReadLine());
            string name = string.Empty; // string.Empty is the same as ""

            // Switch is used to select one of many code blocks to be executed
            // It is similar to if-else-if-else, but it is more readable
            // It is faster than if-else-if-else
            switch (weddingYears)
            {
                case 5:
                    name = "Wood anniversary";
                    break;
                case 10:
                    name = "Tin anniversary";
                    break;
                case 15:
                    name = "Crystal anniversary";
                    break;
                case 20:
                    name = "China anniversary";
                    break;
                case 25:
                    name = "Silver anniversary";
                    break;
                case 30:
                    name = "Pearl anniversary";
                    break;
                case 35:
                    name = "Coral anniversary";
                    break;
                case 40:
                    name = "Ruby anniversary";
                    break;
                case 45:
                    name = "Sapphire anniversary";
                    break;
                case 50:
                    name = "Gold anniversary";
                    break;
                case 55:
                    name = "Emerald anniversary";
                    break;
                case 60:
                    name = "Diamond anniversary";
                    break;
                case 65:
                    name = "Blue Sapphire anniversary";
                    break;
                case 70:
                    name = "Platinum anniversary";
                    break;
                default:
                    name = "Unknown anniversary";
                    break;
            }

            Console.WriteLine($"Your {weddingYears} years wedding is called {name}.");

            Console.WriteLine();

            // Example, using switch to find the season of a month
            Console.Write("Enter the number of the month: ");
            int month = int.Parse(Console.ReadLine());
            string season = string.Empty; // string.Empty is the same as ""

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;
                default:
                    season = "Unknown season";
                    throw new ArgumentException("Invalid month number.");
                    break;
            }

            Console.WriteLine($"The season of the month {month} is {season}.");

            Console.WriteLine();

            // Example, using switch to find the name of a day
            Console.Write("Enter the number of the day: ");
            int day = int.Parse(Console.ReadLine());
            string dayName = string.Empty; // string.Empty is the same as ""

            switch (day)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Unknown day";
                    throw new ArgumentException("Invalid day number.");
                    break;
            }

            Console.WriteLine($"The name of the day {day} is {dayName}.");

        }
    }
}
