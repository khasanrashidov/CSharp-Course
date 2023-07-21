using System;

namespace PracticalTasks
{
    public class Complex
    {
        public double Real { get; private set; }
        public double Imaginary { get; private set; }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

       // This method is type of Complex, and it returns object of Complex type
        public Complex Plus(Complex other)
        {
            return new Complex(Real + other.Real, Imaginary + other.Imaginary);
        }

        public Complex Minus(Complex other)
        {
            return new Complex(Real - other.Real, Imaginary - other.Imaginary);
        }

        // We override ToString() method to return string representation of object
        // We can use it in Console.WriteLine() method to print object in correct format
        public override string ToString()
        {
            return string.Format("{0} + {1}i", Real, Imaginary);
        }

        // We override Equals() method to compare two objects of Complex type
        // We can use it in Console.WriteLine() method to print object in correct format
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Complex? other = obj as Complex;
            if (other == null)
                return false;

            return Real == other.Real && Imaginary == other.Imaginary;
        }

        // We override GetHashCode() method to return hash code of object
        // We can use it in Console.WriteLine() method to print object in correct format
        public override int GetHashCode()
        {
            return Real.GetHashCode() ^ Imaginary.GetHashCode();
        }
    }
}