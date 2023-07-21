using System;

namespace ArraysCollections
{
    class MultidimArrays
    {
        static void Main(string[] args)
        {
            // 2D array
            int[,] arr2D = new int[3, 4];
            arr2D[0, 0] = 1;
            arr2D[0, 1] = 2;
            arr2D[0, 2] = 3;
            arr2D[0, 3] = 4;
            arr2D[1, 0] = 5;
            arr2D[1, 1] = 6;
            arr2D[1, 2] = 7;
            arr2D[1, 3] = 8;
            arr2D[2, 0] = 9;
            arr2D[2, 1] = 10;
            arr2D[2, 2] = 11;
            arr2D[2, 3] = 12;

            // 3D array
            int[,,] arr3D = new int[3, 4, 2];
            arr3D[0, 0, 0] = 1;
            arr3D[0, 0, 1] = 2;
            arr3D[0, 1, 0] = 3;
            arr3D[0, 1, 1] = 4;
            arr3D[0, 2, 0] = 5;
            arr3D[0, 2, 1] = 6;
            arr3D[0, 3, 0] = 7;
            arr3D[0, 3, 1] = 8;
            arr3D[1, 0, 0] = 9;
            arr3D[1, 0, 1] = 10;
            arr3D[1, 1, 0] = 11;
            arr3D[1, 1, 1] = 12;
            arr3D[1, 2, 0] = 13;
            arr3D[1, 2, 1] = 14;
            arr3D[1, 3, 0] = 15;
            arr3D[1, 3, 1] = 16;
            arr3D[2, 0, 0] = 17;
            arr3D[2, 0, 1] = 18;
            arr3D[2, 1, 0] = 19;
            arr3D[2, 1, 1] = 20;
            arr3D[2, 2, 0] = 21;
            arr3D[2, 2, 1] = 22;
            arr3D[2, 3, 0] = 23;
            arr3D[2, 3, 1] = 24;

            int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] r2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] r3 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // GetLength() returns the number of elements in the specified dimension
            for (int i = 0; i < r2.GetLength(0); i++)
            {
                for (int j = 0; j < r2.GetLength(1); j++)
                {
                    Console.Write(r2[i, j] + " "); // r2[i, j] is the same as r2.GetValue(i, j)
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // GetUpperBound() returns the upper bound of the specified dimension
            for (int i = 0; i <= r2.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= r2.GetUpperBound(1); j++)
                {
                    Console.Write(r2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // GetLowerBound() returns the lower bound of the specified dimension
            for (int i = r2.GetLowerBound(0); i <= r2.GetUpperBound(0); i++)
            {
                for (int j = r2.GetLowerBound(1); j <= r2.GetUpperBound(1); j++)
                {
                    Console.Write(r2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // GetLength() returns the number of elements in the specified dimension
            for (int i = 0; i < arr3D.GetLength(0); i++)
            {
                for (int j = 0; j < arr3D.GetLength(1); j++)
                {
                    for (int k = 0; k < arr3D.GetLength(2); k++)
                    {
                        Console.Write(arr3D[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}