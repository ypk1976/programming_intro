// Задача 49. Создайте 2-х мерный массив, найдите в нем элементы с обоими четными инексами
// и возведите значения элементов с этими индексами в квадрат.
int[,] matrix = CreateArray2D(3, 4, 0, 10);
PrintArray2D(matrix);
SquareEvenElements(matrix);
PrintArray2D(matrix);

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

void SquareEvenElements(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0) matr[i, j] *= matr[i, j];
    }
    //return matr;
}