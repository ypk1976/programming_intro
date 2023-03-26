// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
int[,,] matrix3d = CreateArray3D(2, 2, 2);
PrintArray3D(matrix3d);

int[,,] CreateArray3D(int rows, int cols, int depth)
{
    int[,,] matrix3d = new int[rows, cols, depth];
    Random rand = new Random();
    int start_value = 10;
    for (int i = 0; i < matrix3d.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3d.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3d.GetLength(2); k++)
            {
                start_value += rand.Next(1, 5);
                matrix3d[i, j, k] = start_value;
            }
        }
    }
    return matrix3d;
}

void PrintArray3D(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.WriteLine($"{matr[i, j, k],5}({i},{j},{k})");
            }
        }
    }
}