// Задача 51. Создайте 2-х мерный массив и выведете 
// сумму элементов, находящихся на диагональных позициях (0,0), (1,1) и т.д.
int[,] matrix = CreateArray2D(3, 4, 0, 10);
PrintArray2D(matrix);
SumOfDiagonalElements(matrix);

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

void SumOfDiagonalElements(int[,] matr)
{
    int result = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            if (i == j) result += matr[i, j];
    }
    Console.WriteLine(result);
}