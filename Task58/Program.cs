// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Две матрицы можно перемножить, если количество столбцов первой матрицы равно количеству строк второй матрицы.
int[,] matrix1 = CreateArray2D(2, 3, 0, 10);
int[,] matrix2 = CreateArray2D(3, 2, 0, 10);
PrintArray2D(matrix1);
PrintArray2D(matrix2);
if (ValidateMatrixMultiply(matrix1, matrix2))
{
    int[,] result_matrix = MatrixMultiply(matrix1, matrix2);
    PrintArray2D(result_matrix);
}
else    Console.WriteLine("Данные матрицы нельзя перемножить");

int[,] MatrixMultiply(int[,] matr1, int[,] matr2)
{
    int[,] result_matrix = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr2.GetLength(0); k++)
            {
                result_matrix[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return result_matrix;
}

bool ValidateMatrixMultiply(int[,] matr1, int[,] matr2)
{
    if (matr1.GetLength(1) == matr2.GetLength(0)) return true;
    else return false;
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
            Console.Write($"{matr[i, j],4}");
        Console.WriteLine("|");
    }
    Console.WriteLine();
}