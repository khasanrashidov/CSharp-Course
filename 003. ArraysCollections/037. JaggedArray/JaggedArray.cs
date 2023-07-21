using System;

namespace ArraysCollections
{
    class JaggedArrays
    {
        static void Main(string[] args)
        {
            // Jagged array
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
            jaggedArray[3] = new int[4];

            Console.WriteLine("Enter the numbers for a jagged array:");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    string? str = Console.ReadLine();
                    jaggedArray[i][j] = int.Parse(str);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Printing the elements");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int[][] arrJagged = new int[4][];
            arrJagged[0] = new int[] { 1, 2, 3, 4, 5 };
            arrJagged[1] = new int[] { 6, 7, 8, 9, 0 };
            arrJagged[2] = new int[] { 9, 8, 7, 6, 5 };
            arrJagged[3] = new int[] { 4, 3, 2, 1, 0 };

            for (int i = 0; i < arrJagged.Length; i++)
            {
                for (int j = 0; j < arrJagged[i].Length; j++)
                {
                    Console.Write(arrJagged[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int[][] arrJagged2 = new int[4][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 6, 7, 8, 9, 0 },
                new int[] { 9, 8, 7, 6, 5 },
                new int[] { 4, 3, 2, 1, 0 }
            };

            for (int i = 0; i < arrJagged2.Length; i++)
            {
                for (int j = 0; j < arrJagged2[i].Length; j++)
                {
                    Console.Write(arrJagged2[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int[][] arrJagged3 = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 6, 7, 8, 9, 0 },
                new int[] { 9, 8, 7, 6, 5 },
                new int[] { 4, 3, 2, 1, 0 }
            };

            for (int i = 0; i < arrJagged3.Length; i++)
            {
                for (int j = 0; j < arrJagged3[i].Length; j++)
                {
                    Console.Write(arrJagged3[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int[][] jaggedArray2 = new int[3][];
            jaggedArray2[0] = new int[3];
            jaggedArray2[1] = new int[2];
            jaggedArray2[2] = new int[4];

            jaggedArray2[0][0] = 1;
            jaggedArray2[0][1] = 2;
            jaggedArray2[0][2] = 3;

            jaggedArray2[1][0] = 4;
            jaggedArray2[1][1] = 5;

            jaggedArray2[2][0] = 6;
            jaggedArray2[2][1] = 7;
            jaggedArray2[2][2] = 8;
            jaggedArray2[2][3] = 9;

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.Write(jaggedArray2[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
