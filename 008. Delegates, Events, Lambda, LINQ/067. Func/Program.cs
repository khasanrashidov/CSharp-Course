namespace Func
{
    public class Car
    {
        int speed = 0;

        // Func is a delegate type defined in System namespace
        // It can be used to reference a method that has a non-void return type and takes zero or more arguments
        // Func can be used instead of defining a custom delegate
        public event Func<int, bool>? TooFastDriving;

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
                {
                    // Check if any subscriber of TooFastDriving event returns true (which means stop)
                    if (TooFastDriving(speed))
                        Stop();
                }
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

            // Subscribe the HandleOnTooFast method to the TooFastDriving event
            car.TooFastDriving += HandleOnTooFast;

            car.Start();

            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }

            Console.ReadKey();
        }

        public static bool HandleOnTooFast(int speed)
        {
            Console.WriteLine($"Oh, I got it, calling stop! Current Speed = {speed}");
            // Return true to indicate that the car should stop
            return true;
        }
    }
}
