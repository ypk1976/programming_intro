// Задайте двухмерный массив m * n и заполните его случайными числами

int[,] matrix = CreateArray2D(3, 4, -10, 10);
PrintArray2D(matrix);

void PrintArray2D(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++) 
            Console.Write($"{matr[i, j], 3}");
        Console.WriteLine("]");
    }
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