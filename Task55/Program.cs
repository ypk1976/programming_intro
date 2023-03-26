// Задача 55. Задайте двухмерный массив. Напишите программу, поменяет рядки и столбцы местами.
// Если это невозможно, то выдаст пользователю сообщение

int[,] matrix = CreateArray2D(3, 4, 0, 10);
PrintArray2D(matrix);
int[,] switched_matrix = SwitchRowsWithColumns(matrix);
PrintArray2D(switched_matrix);

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

int[,] SwitchRowsWithColumns(int[,] matr){
    int[,] new_matr = new int[matr.GetLength(1), matr.GetLength(0)];
    for (int i = 0; i < new_matr.GetLength(0); i++)
    {
        for (int j = 0; j < new_matr.GetLength(1); j++){
            new_matr[i,j]=matr[j,i];
        }
    }
    return new_matr;
}