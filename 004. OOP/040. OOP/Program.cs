using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Character c = new Character();
            c.Hit(10);
            Console.WriteLine($"Health: {c.Health}"); //Console.WriteLine(c.health);
            c.Hit(120);
            Console.WriteLine($"Health: {c.Health}"); //Console.WriteLine(c.health);

            // We can set health to any number
            // c.health = 1000; // This is not good.
            // Console.WriteLine(c.health);
            // To avoid this, we can make health private,
            // but we will not be able to print it (read it).
            // To solve this, we can use properties.
            // Properties are methods that look like fields.
            // Properties allow us to set access modifiers separately for reading and writing.

            // Console.WriteLine(c.GetHealth());

            // Method overloading
            Calculator calc = new Calculator();
            double area = calc.CalcTriangleArea(3.0, 4.0, 5.0);
            Console.WriteLine($"Area: {area}");

            area = calc.CalcTriangleArea(3.0, 4.0);
            Console.WriteLine($"Area: {area}");

            area = calc.CalcTriangleArea(3, 4, 90);
            Console.WriteLine($"Area: {area}");

            // Params keyword
            double average = calc.Average(1, 2, 3, 4, 5);
            Console.WriteLine($"Average: {average}");

            double average2 = calc.Average2(new double[] { 1, 2, 3, 4, 5 });
            Console.WriteLine($"Average: {average2}");

            // Named arguments
            // We can use named arguments to make the code more readable.
            // We can also use named arguments to change the order of the arguments.
            // Named arguments must be after the positional arguments.
            area = calc.CalcTriangleArea(a: 3.0, b: 4.0, alpha: 60);
            Console.WriteLine($"Area: {area}");

            area = calc.CalcTriangleArea(alpha: 60, a: 3.0, b: 4.0, isInRadians: false);
            Console.WriteLine($"Area: {area}");

            // out parameters
            // There can be more than one out parameter in a method. 
            Console.Write("Enter a number: ");
            string? @string = Console.ReadLine();

            bool wasParsed = int.TryParse(@string, out int number);
            if (wasParsed)
            {
                Console.WriteLine("Number: " + number);
            }
            else
            {
                Console.WriteLine("Failed to parse.");
            }

            if (calc.TryDivide(10, 2, out double result))
            {
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Failed to divide.");
            }

            if (calc.TryDivide(10, 0, out result))
            {
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Failed to divide.");
            }

            // static keyword
            Character c1 = new Character();
            Character c2 = new Character();

            Console.WriteLine($"c1.Speed: {c1.GetSpeed()}. c2.Speed: {c2.GetSpeed()}");

            // We can change the speed of all characters by changing the speed of one character.
            c1.IncreaseSpeed();

            Console.WriteLine($"c1.Speed: {c1.GetSpeed()}. c2.Speed: {c2.GetSpeed()}"); // c2.Speed is also changed.


            // Value and reference types
            PointValue p1; // same as PointValue p1 = new PointValue();
            p1.x = 3;
            p1.y = 5;

            PointValue p2 = p1; // p2 is a copy of p1
            p2.x = 7;
            p2.y = 10;

            p1.Points();
            p2.Points();

            Console.WriteLine();

            PointReference p3 = new PointReference(); // should be initialized
            p3.x = 3;
            p3.y = 5;

            PointReference p4 = p3; // p4 is a reference to p3, it is not a copy
            p4.x = 7;
            p4.y = 10;

            p3.Points();
            p4.Points();

            // Struct Reference
            StructReference s1 = new StructReference();
            s1.PointReference = new PointReference() { x = 1, y = 2 };
            // same as s1.PointReference = new PointReference();
            // s1.PointReference.x = 1;
            // s1.PointReference.y = 2;

            StructReference s2 = s1;

            Console.WriteLine($"s1.PointReference.x: {s1.PointReference.x}. s1.PointReference.y: {s1.PointReference.y}");
            Console.WriteLine($"s2.PointReference.x: {s2.PointReference.x}. s2.PointReference.y: {s2.PointReference.y}");

            s2.PointReference.x = 3;
            s2.PointReference.y = 4;

            Console.WriteLine($"s1.PointReference.x: {s1.PointReference.x}. s1.PointReference.y: {s1.PointReference.y}");
            Console.WriteLine($"s2.PointReference.x: {s2.PointReference.x}. s2.PointReference.y: {s2.PointReference.y}");


            // Passing reference types and value types to methods
            var list = new List<int>();
            AddNumbers(list);

            foreach (var item in list)
            {
                Console.WriteLine($"list item: {item}");
            }

            Console.WriteLine();

            int a = 1;
            int b = 2;
            Swap(a, b);
            // Changes to a and b are not reflected in the original variables.
            Console.WriteLine($"Original a: {a}. Original b: {b}");

            Console.WriteLine();

            Swap2(ref a, ref b);
            // Changes to a and b are reflected in the original variables.
            Console.WriteLine($"Original a: {a}. Original b: {b}");

            Console.WriteLine();
            // NullReferenceException
            // PointReference p5 = null;
            // Console.WriteLine(p5.x); // NullReferenceException

            // No exception
            //PointValue p5; // by default, p5 is initialized to null
            //Console.WriteLine(p5.x); // 0

            PointValue? p5 = null;
            Console.WriteLine(p5?.x); // null - empty

            if (p5.HasValue)
            {
                PointValue p6 = p5.Value;
                Console.WriteLine(p5.Value.x); // empty
                Console.WriteLine(p6.x); // empty
            }
            else
            {
                Console.WriteLine("p5 is null.");
            }

            PointValue p7 = p5.GetValueOrDefault(); // p7 is initialized to default(PointValue)
            Console.WriteLine(p7.x); // 0

            PointValue p8 = p5.GetValueOrDefault(new PointValue() { x = 1, y = 2 }); // p8 is initialized to new PointValue() {x = 1, y = 2}
            Console.WriteLine(p8.x); // 1
            Console.WriteLine(p8.y); // 2

            Console.WriteLine();

            // Boxing and unboxing
            int i = 5;
            object obj = i; // boxing
            int y = (int)obj; // unboxing

            // Boxing and unboxing with nullable types  
            int? x = 5;
            object obj2 = x; // boxing
            int? z = (int?)obj2; // unboxing

            // Boxing and unboxing with reference types
            PointValue p9 = new PointValue() { x = 1, y = 2 };
            object obj3 = p9; // boxing
            PointValue p10 = (PointValue)obj3; // unboxing

            // Boxing and unboxing with reference types and nullable types
            PointValue? p11 = new PointValue() { x = 1, y = 2 };
            object obj4 = p11; // boxing
            PointValue? p12 = (PointValue?)obj4; // unboxing

            double pi = 3.14;
            object obj5 = pi; // boxing

            // InvalidCastException
            //int pi2 = (int) obj5; // unboxing
            // correct way
            int pi2 = (int)(double)obj5; // unboxing
            Console.WriteLine(pi2); // 3

            Do(p9); // p9 is a reference type
            Do(p11); // p11 is a value type
            Do(pi); // pi is a value type
            Do(p3); // p3 is a reference type

            // Constructors
            Character c3 = new Character("Elf"); // calls the constructor with one parameter
            Console.WriteLine(c3.Race); // Elf

        }

        static void Do(object obj)
        {
            // We want to check if the object is of type PointReference,
            bool isPointReference = obj is PointReference;
            // if it is, we want to cast it to PointReference and use it.
            if (isPointReference)
            {
                PointReference p = (PointReference)obj; // casting
                Console.WriteLine($"x: {p.x}, y: {p.y}");
            }
            else
            {
                Console.WriteLine("obj is not of type PointReference");
            }

            PointReference? p2 = obj as PointReference; // as keyword is used to cast an object to a specific type
            // If the object is of type PointReference, it will be casted to PointReference and assigned to p2. 
            // If the object is not of type PointReference, p2 will be assigned to null.
            if (p2 != null)
            {
                Console.WriteLine($"x: {p2.x}, y: {p2.y}");
            }
            else
            {
                Console.WriteLine("obj is not of type PointReference");
            }

            // as is used more often than is because it is more convenient.
            // is is used when we want to check if an object is of a specific type without casting it.
            // as is used when we want to cast an object to a specific type and check if the cast was successful.
        }

        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }

        static void Swap(int a, int b)
        {
            Console.WriteLine($"Before swap: a = {a}, b = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After swap: a = {a}, b = {b}");
        }

        // ref keyword is used to pass a reference to a variable to a method.
        static void Swap2(ref int a, ref int b)
        {
            Console.WriteLine($"Before swap: a = {a}, b = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After swap: a = {a}, b = {b}");
        }

    }
}
