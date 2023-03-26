// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] matrix = CreateArray2D(3, 5, 0, 10);
PrintArray2D(matrix);
int[] array = GetSumOfElements(matrix);
PrintArray(array);
Console.WriteLine($"{FindMinElement(array)} строка");

int FindMinElement(int[] arr)
{
    int min = arr[0], index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min){
            min = arr[i];
            index = i;
        }

    }
    return index;
}

int[] GetSumOfElements(int[,] matr)
{
    int sum = 0;
    int[] arr = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }
        arr[i] = sum;
    }
    return arr;
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

void PrintArray2D(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j],3}");
        Console.WriteLine("|");
    }
    Console.WriteLine();
}

void PrintArray(int[] matr)
{
    Console.Write("[");
    for (int i = 0; i < matr.Length; i++)
        Console.Write($"{matr[i],3}");
    Console.WriteLine("]");
    Console.WriteLine();
}