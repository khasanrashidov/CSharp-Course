namespace Action
{
    public class Car
    {
        int speed = 0;

        // Action is a delegate type defined in System namespace
        // It can be used to reference a method that has a void return type and takes zero or more arguments
        // Action can be used instead of defining a custom delegate
        public event Action<int>? TooFastDriving;

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
                    TooFastDriving!(speed);
            }
        }

        public void Stop()
        {
            speed = 0;
        }

    }

    public class Program
    {
        public static Car? car;
        public static void Main(string[] args)
        {
            car = new Car();

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

        public static void HandleOnTooFast(int speed)
        {
            Console.WriteLine($"Oh, I got it, calling stop! Current Speed = {speed}");
            car!.Stop();
        }
    }
}
