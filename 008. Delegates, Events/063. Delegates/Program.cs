namespace Events
{
    public class Car
    {
        int speed = 0;

        // Delegates are used to create callback methods
        // A delegate is a type that represents references to methods with a particular parameter list and return type.
        // When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type.
        // You can invoke (or call) the method through the delegate instance.
        // Delegates are used to pass methods as arguments to other methods.

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
            this.tooFast = tooFast;
        }

    }

    public class Program
    {
        public static Car? car;
        public static void Main(string[] args)
        {
            car = new Car();

            car.RegisterOnTooFast(HandleOnTooFast);

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
