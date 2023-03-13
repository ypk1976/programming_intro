// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] array = FillArrayDouble(5, 0, 100);
GetArrayDouble(array);
Console.Write(FindDiff(FindMin(array),FindMax(array)));

double[] FillArrayDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rand.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void GetArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < (arr.Length - 1)) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}] -> ");
    }
}

double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++) if (arr[i] < min) min = arr[i];
    return min;
}

double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++) if (arr[i] > max) max = arr[i];
    return max;
}

double FindDiff(double  min, double max)
{
    double result = Math.Round(max - min, 1);
    return result;
}