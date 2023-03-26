// Задача 59. Задайте массив заполненный натуральными числами. 
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых находится наименьший элемент.
int[,] matrix = CreateArray2D(5, 5, 0, 10);
PrintArray2D(matrix);
int[] array = MinimalElement(matrix);
PrintArray(array);
int[,] new_matrix = DeleteMinElemRowColumn(matrix, array);
PrintArray2D(new_matrix);

int[,] DeleteMinElemRowColumn(int[,] matr, int[] arr)
{
    int[,] new_matr = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    int sourceX = 0, sourceY = 0;
    for (int i = 0; i < new_matr.GetLength(0); i++)
    {
        if (sourceX == arr[0]) 
            sourceX++;
        for (int j = 0; j < new_matr.GetLength(1); j++)
        {
            if (sourceY == arr[1]) 
                sourceY++;
            new_matr[i, j] = matr[sourceX, sourceY];
            sourceY++;
        }
        sourceY = 0;
        sourceX++;
    }
    return new_matr;
}

int[] MinimalElement(int[,] matr)
{
    int min = matr[0, 0];
    int[] arr = new int[2];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                arr[0] = i;
                arr[1] = j;
            }
        }
    }
    Console.WriteLine($"Наименьший элемент {min} и находится в {arr[0]},{arr[1]}");
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