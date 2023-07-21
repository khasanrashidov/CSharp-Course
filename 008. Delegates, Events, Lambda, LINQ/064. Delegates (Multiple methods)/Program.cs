namespace Events
{
    public class Car
    {
        int speed = 0;

        // Multiple methods can be assigned to a delegate
        // We assign the methods using the += operator
        // To remove a method from the delegate, we use the -= operator

        public delegate void TooFast(int currentSpeed);

        private TooFast? tooFast;

        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            speed += 10;

            if (speed > 80)
            {
                tooFast!(speed);
            }
        }

        public void Stop()
        {
            speed = 0;
        }

        public void RegisterOnTooFast(TooFast tooFast)
        {
            // this.tooFast = tooFast; // for single method (override)
            this.tooFast += tooFast; // for multiple methods
        }

        public void UnregisterOnTooFast(TooFast tooFast)
        {
            this.tooFast -= tooFast;
        }
    }

    public class Program
    {
        public static Car? car;
        public static void Main(string[] args)
        {
            car = new Car();

            car.RegisterOnTooFast(HandleOnTooFast);
            car.RegisterOnTooFast(HandleOnTooFast);

            car.UnregisterOnTooFast(HandleOnTooFast);

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
