// Задача 48. Создайте 2-хмерный массив n*m и заполните его 
// элементами по формуле Amn=m+n
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
int[,] matrix = CreateArray2D(3, 4);
PrintArray2D(matrix);

void PrintArray2D(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j],3}");
        Console.WriteLine("]");
    }
}

int[,] CreateArray2D(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = i + j;
    }
    return matrix;
}