using System;

namespace CSBasics
{
    class DateTimeIntro
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("DateTime.Now = " + now);
            Console.WriteLine("DateTime.Now = " + now.ToString());
            Console.WriteLine("DateTime.Now = " + now.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("DateTime.Now = " + now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            Console.WriteLine($"It's {now.Hour} o'clock and {now.Minute} minutes.");
            Console.WriteLine($"Today is {now.DayOfWeek}.");
            Console.WriteLine($"Today is {now.DayOfYear}th day of the year.");
            Console.WriteLine($"Today is {now.Day}th day of the month.");
            Console.WriteLine($"Today's date is {now.Day}/{now.Month}/{now.Year}.");
            Console.WriteLine($"Today's date is {now.Date}.");

            Console.WriteLine();

            DateTime today = DateTime.Today;
            Console.WriteLine("DateTime.Today = " + today);

            Console.WriteLine();

            DateTime tomorrow = now.AddDays(1);
            Console.WriteLine("Tomorrow = " + tomorrow);

            Console.WriteLine();

            DateTime yesterday = now.AddDays(-1);
            Console.WriteLine("Yesterday = " + yesterday);

            Console.WriteLine();

            DateTime dt = new DateTime(2022, 2, 22, 22, 22, 22); // 22nd Feb 2022 22:22:22
            Console.WriteLine("DateTime = " + dt);

            DateTime newDt = dt.AddDays(1);
            Console.WriteLine("DateTime = " + newDt);

            Console.WriteLine();

            TimeSpan ts = now - dt;
            // or ts = now.Subtract(dt);
            Console.WriteLine("TimeSpan = " + ts);
            Console.WriteLine("Days = " + ts.Days);
            Console.WriteLine("TotalDays = " + ts.TotalDays);
            Console.WriteLine("Hours = " + ts.Hours);
            Console.WriteLine("Minutes = " + ts.Minutes);
            Console.WriteLine("Seconds = " + ts.Seconds);
            Console.WriteLine("Ticks = " + ts.Ticks);

        }
    }
}
