using System;

namespace OOP
{
    public interface IShape
    {
        double Area();
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return Width * Height;
        }
    }

    public class Square : IShape
    {
        public double Side { get; set; }

        public double Area()
        {
            return Side * Side;
        }
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

}