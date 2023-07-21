using System;
using System.Threading;

namespace ReminderApp
{
    public class Reminder
    {
        private Timer timer;
        private string taskName;
        private DateTime reminderTime;

        // Action is a delegate type defined in System namespace
        // It can be used to reference a method that has a void return type and takes zero or more arguments
        public event Action<string>? ReminderElapsed;

        public Reminder(string taskName, DateTime reminderTime)
        {
            this.taskName = taskName;
            this.reminderTime = reminderTime;

            // Initialize the timer
            var timeDifference = reminderTime - DateTime.Now;
            var dueTime = (int)timeDifference.TotalMilliseconds;
            timer = new Timer(Timer_Elapsed, null, dueTime, Timeout.Infinite);
        }

        private void Timer_Elapsed(object? state)
        {
            Console.WriteLine($"Reminder: {taskName} - Time: {reminderTime}");
            OnReminderElapsed();
        }

        protected virtual void OnReminderElapsed()
        {
            // Check if any subscriber of the ReminderElapsed event exists
            // and invoke the event to notify subscribers
            ReminderElapsed?.Invoke(taskName);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create reminders
            var reminder1 = new Reminder("Meeting", DateTime.Now.AddSeconds(10));
            var reminder2 = new Reminder("Dinner", DateTime.Now.AddSeconds(20));
            var reminder3 = new Reminder("Gym", DateTime.Now.AddSeconds(30));

            // Subscribe to the ReminderElapsed event using lambda expressions
            reminder1.ReminderElapsed += task => Console.WriteLine($"Time to attend the {task}!");
            reminder2.ReminderElapsed += task => Console.WriteLine($"Don't forget about the {task}!");
            reminder3.ReminderElapsed += task => Console.WriteLine($"It's time for the {task}!");

            Console.WriteLine("Reminders set. Waiting for reminders to elapse...");
            Console.ReadKey();
        }
    }
}
