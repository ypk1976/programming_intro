// Задача 53. Создайте двухмерный массив и напишите программу,
// которая поменяет первую и последнюю строки местами.

int[,] matrix = CreateArray2D(6, 9, 0, 10);
PrintArray2D(matrix);
SwitchRowsInArray2D(matrix);
PrintArray2D(matrix);

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
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j],3}");
        Console.WriteLine("]");
    }
    Console.WriteLine();
}

int[,] SwitchRowsInArray2D(int[,] matr){
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        int temp=matr[0,i];
        matr[0,i]=matr[matr.GetLength(0)-1,i];
        matr[matr.GetLength(0)-1,i]=temp;
    }
    Console.WriteLine();
    return matr;
}