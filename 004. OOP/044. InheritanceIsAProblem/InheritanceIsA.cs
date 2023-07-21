using System;

namespace OOP
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

    }

    public class Square : Rectangle
    {
        
    }

    public class CalculateArea
    {
        public static int Area(Square square)
        {
            return square.Width * square.Width; // or square.Height * square.Height
        }

        public static int Area(Rectangle rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }
    }
}