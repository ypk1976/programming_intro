// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int size = 4;
int[,] matrix = CreateEmptyArray2D(size);
MakeSpiral(size);
PrintArray2D(matrix);

void MakeSpiral(int n)
{
    int i = 0, j = 0, value = 1;
    while (n != 0)
    {
        int k = 0;
        do
            matrix[i, j++] = value++;
        while (++k < n - 1);
        for (k = 0; k < n - 1; k++)
            matrix[i++, j] = value++;
        for (k = 0; k < n - 1; k++)
            matrix[i, j--] = value++;
        for (k = 0; k < n - 1; k++)
            matrix[i--, j] = value++;
        ++i; ++j; n = n < 2 ? 0 : n - 2;
    }
}

int[,] CreateEmptyArray2D(int size)
{
    int[,] matrix = new int[size, size];
    return matrix;
}

void PrintArray2D(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j],4}");
        Console.WriteLine("|");
    }
    Console.WriteLine();
}