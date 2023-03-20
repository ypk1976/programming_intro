string[,] table = new string[2, 5];
table[0, 2] = "word";

// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         Console.WriteLine($"-{table[i, j]}-");
//     }

// }

// int[,] matrix = new int[3, 4];
// matrix[1, 2] = 21;
// FillArray2D(matrix);
// PrintArray2D(matrix);

// void PrintArray2D(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();

//     }
// }

// void FillArray2D(int[,] matr){
//     Random rand = new Random();
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j]=rand.Next(1,10);
//         }
//     }
// }

// double Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! {Factorial(i)}");
// }


for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"{i}! {Fibonacci(i)}");
}

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}