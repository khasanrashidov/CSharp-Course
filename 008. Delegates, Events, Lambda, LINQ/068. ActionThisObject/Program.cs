namespace ActionThisObject
{
    public class Car
    {
        int speed = 0;

        // In Action<object, int>, object is the type of the sender, and int is the type of the event arguments.
        public event Action<object, int>? TooFastDriving;

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
                    TooFastDriving!(this, speed);
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
            Car car = new Car();

            car.TooFastDriving += HandleOnTooFast;
            car.TooFastDriving += HandleOnTooFast;

            car.TooFastDriving -= HandleOnTooFast;

            car.Start();

            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }

            Console.ReadKey();
        }

        public static void HandleOnTooFast(object obj, int speed)
        {
            var car = obj as Car; // or var car = (Car)obj;
            Console.WriteLine($"Oh, I got it, calling stop! Current Speed = {speed}");
            car!.Stop();
        }
    }
}
