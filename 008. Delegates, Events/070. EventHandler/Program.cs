using System;
using System.Timers;

namespace EventHandler
{
    // Arguments should be packed in a class that inherits from EventArgs
    public class CarArgs : EventArgs
    {
        public int CurrentSpeed { get; set; }

        public CarArgs(int speed)
        {
            CurrentSpeed = speed;
        }
    }

    public class Car
    {
        int speed = 0;

        public event EventHandler<CarArgs>? TooFastDriving;

        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            speed += 10;

            if (speed > 80)
            {
                if (TooFastDriving != null)
                    TooFastDriving!(this, new CarArgs(speed));
            }
        }

        public void Stop()
        {
            speed = 0;
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += Timer_Elapsed!;
            timer.Interval = 5000;
            timer.Start();

            Car car = new Car();

            car.TooFastDriving += HandleOnTooFast!;
            car.TooFastDriving += HandleOnTooFast!;

            car.TooFastDriving -= HandleOnTooFast!;

            car.Start();

            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }

            Console.ReadKey();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // This event will be triggered every 1 second (1000 milliseconds)
            // You can add any logic here that should be executed periodically
            Console.WriteLine("Handling timer elapsed event");
        }


        public static void HandleOnTooFast(object obj, CarArgs speed)
        {
            var car = obj as Car; // or var car = (Car)obj;
            Console.WriteLine($"Oh, I got it, calling stop! Current Speed = {speed}");
            car!.Stop();
        }
    }
}
