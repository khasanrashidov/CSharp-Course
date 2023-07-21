namespace Events
{
    public class Car
    {
        int speed = 0;

        // Multiple methods can be assigned to a delegate
        // We assign the methods using the += operator
        // To remove a method from the delegate, we use the -= operator

        public event TooFast? TooFastDriving;
        // Event is a special type of delegate
        // It can only be invoked from within the class that declared it

        public delegate void TooFast(int currentSpeed);

        // private TooFast? tooFast; // now we use event instead of delegate

        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            speed += 10;

            if (speed > 80)
            {
                // Events should be checked for null before invoking them
                // If no methods are assigned to the event, it will be null
                // If we try to invoke a null event, we will get a NullReferenceException
                if (TooFastDriving != null)
                    TooFastDriving!(speed);
            }
        }

        public void Stop()
        {
            speed = 0;
        }

        // As we are using event, we don't need these methods anymore
        // public void RegisterOnTooFast(TooFast tooFast)
        // {
        //     // this.tooFast = tooFast; // for single method (override)
        //     this.tooFast += tooFast; // for multiple methods
        // }

        // public void UnregisterOnTooFast(TooFast tooFast)
        // {
        //     this.tooFast -= tooFast;
        // }
    }

    public class Program
    {
        public static Car? car;
        public static void Main(string[] args)
        {
            car = new Car();

            // car.RegisterOnTooFast(HandleOnTooFast);
            car.TooFastDriving += HandleOnTooFast; // now we use event instead of delegate
            // car.RegisterOnTooFast(HandleOnTooFast); // now we use event instead of delegate
            car.TooFastDriving += HandleOnTooFast;

            // car.UnregisterOnTooFast(HandleOnTooFast); // now we use event instead of delegate
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
