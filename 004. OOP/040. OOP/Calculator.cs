using System;

namespace OOP
{
    public class Calculator
    {
        // Method overloading:
        // We can have multiple methods with the same name, but different parameters.
        // The compiler will choose the correct method based on the parameters.
        // This is called method overloading.
        // Method overloading is not possible with properties.

        public double CalcTriangleArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public double CalcTriangleArea(double a, double h)
        {
            return a * h / 2;
        }

        // Optional parameters:
        // We can use optional parameters to make the method more flexible.
        // Optional parameters must be after the required parameters.
        // Optional parameters must have a default value.
        // Optional parameters must be the last parameters.
        // Default values in optional parameters must be compile-time constants.
        // Not all programming languages support optional parameters in .NET framework. 
        // Using optional parameters is not bad practice,
        // but it is not recommended to use them 
        // if one does not know the restrictions of using optional parameters.
        // It is better to use method overloading instead.
        public double CalcTriangleArea(double a, double b, int alpha, bool isInRadians = false)
        {
            if (isInRadians)
            {
                return a * b * Math.Sin(alpha) / 2;
            }
            else
            {
                double alphaInRadians = alpha * Math.PI / 180;
                return a * b * Math.Sin(alphaInRadians) / 2;
            }
        }

        // Params keyword:
        // We can use the "params" keyword to pass an array of parameters.
        // The "params" keyword must be the last parameter.
        // The "params" keyword can be used only once in a method.

        public double Average(params double[] numbers)
        {
            double sum = 0;
            foreach (var number in numbers)
                sum += number;
            return sum / numbers.Length;
        }

        // without "params" keyword
        public double Average2(double[] numbers)
        {
            double sum = 0;
            foreach (var number in numbers)
                sum += number;
            return sum / numbers.Length;
        }

        // out parameters:
        // There can be more than one out parameter in a method. 
        public bool TryDivide(double dividend, double divisor, out double result)
        {
            if (divisor == 0)
            {
                result = 0;
                return false;
            }
            result = dividend / divisor;
            return true;
        }

    }
}
