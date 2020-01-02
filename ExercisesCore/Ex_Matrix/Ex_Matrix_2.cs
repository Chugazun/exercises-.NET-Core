using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Ex_Matrix
{
    class Ex_Matrix_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the Matrix Dimentions");
            int[,] mat = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("\nEnter a number to search its position: ");
            NumSearch(int.Parse(Console.ReadLine()), mat);
        }

        static void NumSearch(int num, int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == num)
                    {
                        Console.WriteLine($"Posistion: ({i}, {j})");
                        if (i - 1 >= 0) Console.WriteLine("Up: " + mat[i - 1, j]);
                        if (j + 1 < mat.GetLength(1)) Console.WriteLine("Right: " + mat[i, j + 1]);
                        if (i + 1 < mat.GetLength(0)) Console.WriteLine("Down: " + mat[i + 1, j]);
                        if (j - 1 >= 0) Console.WriteLine("Left: " + mat[i, j - 1]);
                    }
                }
            }
        }
    }
}
