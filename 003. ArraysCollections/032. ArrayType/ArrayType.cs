using System;

namespace ArraysCollections
{
    class ArrayType
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Array myArray = new int[5];
            Array myArray2 = new int[5] { 1, 2, 3, 4, 5 };
            Array myArray3 = new int[] { 1, 2, 3, 4, 5 };
            Array myArray4 = new[] { 1, 2, 3, 4, 5 };

            Array myArray5 = Array.CreateInstance(typeof(int), 5); // 1D array
            myArray5.SetValue(1, 0);
            myArray5.SetValue(2, 1);
            myArray5.SetValue(3, 2);
            myArray5.SetValue(4, 3);
            myArray5.SetValue(5, 4);

            Console.WriteLine(myArray5.GetValue(0));
            Console.WriteLine(myArray5.GetValue(1));
            Console.WriteLine(myArray5.GetValue(2));
            Console.WriteLine(myArray5.GetValue(3));
            Console.WriteLine(myArray5.GetValue(4));

            Console.WriteLine();

            Array myArray6 = Array.CreateInstance(typeof(int), 5, 5); // 2D array
            Array myArray7 = Array.CreateInstance(typeof(int), 5, 5, 5); // 3D array


            int[,] myArray8 = new int[5, 5]; // 2D array
            int[,,] myArray9 = new int[5, 5, 5]; // 3D array

            int[][] myArray10 = new int[5][]; // Jagged array (array of arrays)
            myArray10[0] = new int[5];
            myArray10[1] = new int[5];
            myArray10[2] = new int[5];
            myArray10[3] = new int[5];
            myArray10[4] = new int[5];

            int[][] myArray11 = new int[5][] { new int[5], new int[5], new int[5], new int[5], new int[5] };

            int[][] myArray12 = new int[5][] {
                                                new int[] { 1, 2, 3, 4, 5 },
                                                new int[] { 1, 2, 3, 4, 5 },
                                                new int[] { 1, 2, 3, 4, 5 },
                                                new int[] { 1, 2, 3, 4, 5 },
                                                new int[] { 1, 2, 3, 4, 5 }
                                            };
            
            int[][] myArray13 = new int[][] {
                                                new int[] { 1, 2, 3, 4, 5 },
                                                new int[] { 1, 2, 3, 4, 5 },
                                                new int[] { 1, 2, 3, 4, 5 },
                                                new int[] { 1, 2, 3, 4, 5 },
                                                new int[] { 1, 2, 3, 4, 5 }
                                            };
            
            // numbers till 100
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                             11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                             21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
                             31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
                             41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                             51, 52, 53, 54, 55, 56, 57, 58, 59, 60,
                             61, 62, 63, 64, 65, 66, 67, 68, 69, 70,
                             71, 72, 73, 74, 75, 76, 77, 78, 79, 80,
                             81, 82, 83, 84, 85, 86, 87, 88, 89, 90,
                             91, 92, 93, 94, 95, 96, 97, 98, 99, 100};
            
            int index = Array.BinarySearch(numbers, 66);
            Console.WriteLine(index);

            int[] copy = new int[100];
            Array.Copy(numbers, copy, numbers.Length);
            Console.WriteLine(copy[65]);
            foreach (int number in copy)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            int[] anotherCopy = new int[100];
            copy.CopyTo(anotherCopy, 0);
            Console.WriteLine(anotherCopy[65]);
            foreach (int number in anotherCopy)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Array.Reverse(copy);
            Console.WriteLine(copy[0]);
            foreach (int number in copy)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Array.Sort(copy);
            Console.WriteLine(copy[0]);
            foreach (int number in copy)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Array.Clear(copy, 0, copy.Length);
            Console.WriteLine(copy[0]);
            foreach (int number in copy)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}