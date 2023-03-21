﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double[,] matrix = CreateArray2D(3, 4, -10, 10);
PrintArray2D(matrix);

double[,] CreateArray2D(int rows, int cols, double min, double max)
{
    double[,] matrix = new double[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num = rand.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(num, 1);
        }
    }
    return matrix;
}

void PrintArray2D(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j],7}");
        Console.WriteLine("|");
    }
    Console.WriteLine();
}
