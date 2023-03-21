// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет
int[,] matrix = CreateArray2D(3, 4, 0, 10);
PrintArray2D(matrix);
Console.WriteLine("Введите ряд элемента:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колонку элемента:");
int column = Convert.ToInt32(Console.ReadLine());
Get2DArrayElement(row, column, matrix);

void Get2DArrayElement(int row, int column, int[,] matr)
{
    if (row < matr.GetLength(0) && column < matr.GetLength(1))
        Console.WriteLine($"Элемент в {row} рядке и {column} колонке = {matr[row, column]}");
    else
        Console.WriteLine("Такого элемента в массиве нет");
}

void PrintArray2D(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j],5}");
        Console.WriteLine("]");
    }
    Console.WriteLine();
}

int[,] CreateArray2D(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rand.Next(min, max);
    }
    return matrix;
}