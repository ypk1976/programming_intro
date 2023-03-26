// Задача 57. Составить частотный словарь двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается тот или иной элемент массива.
// {0, 1, 5, 2, 0, 1, 5} - 0 содержится 2 раза, 1 - 2 раза, 2 - один раз и 5 - 2 раза

int[,] matrix = CreateArray2D(3, 10, 0, 5);
PrintArray2D(matrix);
Convert2DArray(matrix);
int[] new_matrix = Convert2DArray(matrix);
Array.Sort(new_matrix);
PrintArray(new_matrix);
CountElements(new_matrix);

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

int[] Convert2DArray(int[,] matr)
{
    int size = matr.Length;
    int[] new_matr = new int[size];
    int n = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            new_matr[n++] = matr[i, j];
        }
    }
    return new_matr;
}

void CountElements(int[] arr)
{
    int element = arr[0];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == element)
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{element} встречается {count} раз");
            element = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{element} встречается {count} раз");
}

void PrintArray(int[] matr)
{
    Console.Write("[");
    for (int i = 0; i < matr.Length; i++)
        Console.Write($"{matr[i],3}");
    Console.WriteLine("]");
    Console.WriteLine();
}